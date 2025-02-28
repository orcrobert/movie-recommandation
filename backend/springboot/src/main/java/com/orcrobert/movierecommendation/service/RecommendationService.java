package com.orcrobert.movierecommendation.service;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestTemplate;

import com.orcrobert.movierecommendation.model.MovieRecommendationResponse;

@Service
public class RecommendationService {
    private final RestTemplate restTemplate = new RestTemplate();

    @Value("${python.service.url}")
    private String pythonServiceUrl;

    public MovieRecommendationResponse getRecommendations(String movieTitle) {
        String url = pythonServiceUrl + "/" + movieTitle;

        try {
            ResponseEntity<MovieRecommendationResponse> response = restTemplate.getForEntity(url, MovieRecommendationResponse.class);
            return response.getBody();
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }
}
