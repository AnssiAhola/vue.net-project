import type { Review } from "@/models/Review";

export class ReviewService {

    // TODO: Implement API calls to backend

    submit(review: Review) {
        let reviewsJson = localStorage.getItem("reviews")
        let reviews: Review[] = []
        if (reviewsJson) {
            reviews = JSON.parse(reviewsJson)    
        }
        reviews.push(review)
        localStorage.setItem("reviews", JSON.stringify(reviews))
    }

    fetch(amount: number): Review[] {
        let reviewsJson = localStorage.getItem("reviews")
        let reviews: Review[] = JSON.parse(reviewsJson ?? "{}")
        return reviews.slice(0, amount);
    }
}