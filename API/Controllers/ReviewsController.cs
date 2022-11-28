using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entities;
using API.DTOs;
using AutoMapper;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly DataContext _context;

        private readonly IMapper _mapper;

        public ReviewsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewDto>>> GetReviews()
        {
            var allReviews = await _context.Reviews.ToListAsync();
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Review>> PostReview(CreateReviewDto createReview)
        {
            var review = new Review
            {
                ReviewerName = createReview.ReviewerName,
                ReviewerEmail = createReview.ReviewerEmail,
                Content = createReview.Content,
            };
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            return Ok(review);
        }
    }
}
