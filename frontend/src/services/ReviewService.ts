import type { Review } from "@/models/Review";
import axios, { type AxiosInstance } from "axios";

export class ReviewService {

    private httpClient: AxiosInstance;
    private ENDPOINT = "/reviews";


    constructor() {
        this.httpClient = axios.create({
            baseURL: "https://localhost:7161/api",
            headers: {
                "Content-Type": "application/json",
            }
        })
    }

    // TODO: Implement API calls to backend

    async submit(reviewerName: string, reviewerEmail: string, content: string): Promise<boolean> {
        return this.httpClient.post(this.ENDPOINT, {
            reviewerName: reviewerName,
            reviewerEmail: reviewerEmail,
            content: content
        }).then(result => result.status == 200)
    }

    async fetch(limit: number, offset: number): Promise<Review[]> {
        let params = {
            limit: limit,
            offset: offset
        }

        return this.httpClient.get(this.ENDPOINT, { params })
            .then(result => {
                if (result.status == 200) {
                    return result.data
                }
                return [];
            }).catch(() => [])
    }
}