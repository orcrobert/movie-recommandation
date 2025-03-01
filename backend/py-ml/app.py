import numpy as np
from fastapi import FastAPI
import pandas as pd
import pickle

app = FastAPI()

movies = pd.read_csv("data/movies.csv")
similarity = pickle.load(open("data/similarity.pkl", "rb"))

def recommend_movie(movie_title, movies_df, similarity_matrix):
    if movie_title not in movies_df['title'].values:
        return "Movie not found."

    index = movies_df[movies_df['title'] == movie_title].index[0]
    similar_movies = list(enumerate(similarity_matrix[index]))
    sorted_movies = sorted(similar_movies, key=lambda x: x[1], reverse=True)[1:11]
    
    recommendations = [movies_df.iloc[i[0]].title for i in sorted_movies]
    return recommendations

@app.get("/recommend/{movie_title}")
def get_recommendations(movie_title: str):
    recommendations = recommend_movie(movie_title, movies, similarity)
    return {"recommended_movies": recommendations}

