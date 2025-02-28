package com.orcrobert.movierecommendation.model;

import java.util.List;

import com.fasterxml.jackson.annotation.JsonProperty;

public class MovieRecommendationResponse {

    @JsonProperty("recommended_movies")
    private List<String> recommendedMovies;

    public MovieRecommendationResponse(List<String> recommendedMovies) {
        this.recommendedMovies = recommendedMovies;
    }

    public List<String> getRecommendedMovies() {
        return this.recommendedMovies;
    }
}
