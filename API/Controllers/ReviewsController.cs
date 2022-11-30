using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entities;
using API.DTOs;
using AutoMapper;
using Ganss.Xss;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly DataContext _context;

        private readonly IMapper _mapper;
        private readonly HtmlSanitizer _sanitizer;

        public ReviewsController(
            DataContext context,
            IMapper mapper,
            HtmlSanitizer sanitizer
        )
        {
            _context = context;
            _mapper = mapper;
            _sanitizer = sanitizer;
        }

        // GET: api/reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewDto>>> GetReviews(int limit = 9, int offset = 0)
        {
            var allReviews = await _context.Reviews
                .OrderByDescending(review => review.CreatedAt)
                .Skip(offset)
                .Take(limit)
                .ToListAsync();

            if (allReviews == null)
            {
                return Ok();
            }

            return _mapper.Map<List<ReviewDto>>(allReviews);
        }

        // GET: api/reviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReviewDto>> GetReview(int id)
        {
            var review = await _context.Reviews.FindAsync(id);

            if (review == null)
            {
                return NotFound();
            }

            return _mapper.Map<ReviewDto>(review);
        }

        // POST: api/reviews
        [HttpPost]
        public async Task<ActionResult<ReviewDto>> PostReview(CreateReviewDto createReview)
        {
            var sanitizedName = _sanitizer.Sanitize(createReview.ReviewerName);
            var sanitizedEmail = _sanitizer.Sanitize(createReview.ReviewerEmail);
            var sanitizedContent = _sanitizer.Sanitize(createReview.Content);

            if (sanitizedName.Trim().Length == 0 ||
                sanitizedEmail.Trim().Length == 0 ||
                sanitizedContent.Trim().Length == 0)
            {
                return BadRequest();
            }

            var review = new Review
            {
                ReviewerName = sanitizedName,
                ReviewerEmail = sanitizedEmail,
                Content = sanitizedContent,
                CreatedAt = DateTime.UtcNow,
            };
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(PostReview),
                new { id = review.Id },
                 _mapper.Map<ReviewDto>(review)
            );
        }
    }
}
