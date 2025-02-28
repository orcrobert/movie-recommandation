package com.orcrobert.movierecommendation.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.orcrobert.movierecommendation.model.MovieRecommendationResponse;
import com.orcrobert.movierecommendation.service.RecommendationService;

@RestController
@RequestMapping("/api")
public class RecommendationController {

    @Autowired
    private RecommendationService recommendationService;

    @CrossOrigin(origins = "http://localhost:5000") 
    @GetMapping("/recommend/{movieTitle}")
    public MovieRecommendationResponse recommendMovies(@PathVariable String movieTitle) {
        return recommendationService.getRecommendations(movieTitle);
    }
}