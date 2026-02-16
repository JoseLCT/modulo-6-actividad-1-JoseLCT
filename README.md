# Microservices Project with API Gateway

## How to Run

```bash
docker-compose up -d
```

## API Routes

### Authentication

#### Login

- **Endpoint:** `POST /api/login`
- **Description:** Authenticate and receive a JWT token
- **Credentials:**
  - Username: `admin`
  - Password: `admin`
- **Request Body:**

```json
{
  "email": "admin",
  "password": "admin"
}
```

- **Response:**

```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

### Protected Routes

> **Note:** The following routes require authentication. Include the JWT token in the Authorization header:
>
> ```
> Authorization: Bearer <your-token-here>
> ```

#### Get Users

- **Endpoint:** `GET /api/users`
- **Description:** Retrieves all users from JSONPlaceholder API
- **Source:** https://jsonplaceholder.typicode.com/users
- **Authentication:** Required

#### Get Posts

- **Endpoint:** `GET /api/posts`
- **Description:** Retrieves all posts from JSONPlaceholder API
- **Source:** https://jsonplaceholder.typicode.com/posts
- **Authentication:** Required

## Services

- **API Gateway:** `http://localhost:5000`
- **Auth Service:** `http://localhost:5004`
