# Movie Recommendation System

A sophisticated movie recommendation system built with a microservices architecture, combining modern web technologies with machine learning capabilities.

## 🎯 Project Overview

This project is a full-stack movie recommendation system that provides personalized movie suggestions to users based on their preferences and viewing history. It uses collaborative filtering and content-based recommendation techniques to deliver accurate and relevant movie suggestions.

## 🏗️ Architecture

The project is built using a modern microservices architecture with three main components:

### Frontend (Blazor WebAssembly)
- Located in `/frontend/blazor`
- Built with Blazor WebAssembly for a rich, interactive user experience
- Responsive design for both desktop and mobile devices
- Modern UI/UX with real-time updates

### Backend (Spring Boot)
- Located in `/backend/springboot`
- RESTful API service built with Spring Boot
- Handles user authentication, movie data management, and API routing
- Integrates with the ML service for recommendations

### Machine Learning Service (Python)
- Located in `/backend/py-ml`
- Implements recommendation algorithms using Python
- Provides movie suggestions based on user preferences and behavior
- Uses collaborative filtering and content-based recommendation techniques

## 🚀 Getting Started

### Prerequisites
- .NET 7.0 or later
- Java 17 or later
- Python 3.8 or later
- Node.js (for development tools)

### Installation

1. Clone the repository:
```bash
git clone https://github.com/orcrobert/movie-recommandation.git
cd movie-recommendation
```

2. Set up the frontend:
```bash
cd frontend/blazor
dotnet restore
dotnet build
```

3. Set up the backend:
```bash
cd backend/springboot
./mvnw install
```

4. Set up the ML service:
```bash
cd backend/py-ml
python -m venv venv
source venv/bin/activate  # On Windows: venv\Scripts\activate
pip install -r requirements.txt
```

## 🔧 Configuration

Each component requires specific configuration:

1. Frontend configuration in `frontend/blazor/appsettings.json`
2. Backend configuration in `backend/springboot/src/main/resources/application.properties`
3. ML service configuration in `backend/py-ml/config.py`

## 🏃‍♂️ Running the Application

1. Start the ML service:
```bash
cd backend/py-ml
python app.py
```

2. Start the Spring Boot backend:
```bash
cd backend/springboot
./mvnw spring-boot:run
```

3. Start the Blazor frontend:
```bash
cd frontend/blazor
dotnet run
```

The application will be available at `http://localhost:5000`

## 🛠️ Development

### Project Structure
```
movie-recommendation/
├── frontend/
│   └── blazor/          # Blazor WebAssembly frontend
├── backend/
│   ├── springboot/      # Spring Boot backend service
│   └── py-ml/          # Python ML service
└── docs/               # Additional documentation
```

### Key Features
- User authentication and profile management
- Personalized movie recommendations
- Movie search and filtering
- Rating and review system
- Watch history tracking
- Similar movie suggestions

## 🧪 Testing

Each component includes its own test suite:

- Frontend: `dotnet test`
- Backend: `./mvnw test`
- ML Service: `python -m pytest`

## 📚 API Documentation

API documentation is available at:
- Backend API: `http://localhost:8080/swagger-ui.html`
- ML Service API: `http://localhost:5001/docs`

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 👥 Team

- Frontend Development Team
- Backend Development Team
- Machine Learning Team

## 📞 Support

For support, please open an issue in the repository or contact the development team.

## 🙏 Acknowledgments

- Movie data providers
- Open source libraries and frameworks used in the project
- Contributors and maintainers
