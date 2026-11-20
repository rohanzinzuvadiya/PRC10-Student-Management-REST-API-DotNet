# PRC 10 - Student Management REST API

**Subject:** .NET Technologies (01CE1523) - Marwadi University, Department of Computer Engineering
**Name:** Rohan Zinzuvadiya
**Enrollment No:** 92400103411
**Lab Batch:** B

## Aim
Develop Student Management REST API using ASP.NET Core with Middleware and REST API endpoints.

## How to run
1. Open `PRC10_StudentManagementRestAPI.csproj` in Visual Studio 2022 (.NET 8 SDK).
2. Press F5. Swagger UI opens at `https://localhost:7210/swagger`.
3. Use "Try it out" on each endpoint.

## Endpoints
| Method | URL | Result |
|---|---|---|
| GET | /api/Students | 200, list of students (optional `?course=`) |
| GET | /api/Students/{id} | 200 or 404 |
| POST | /api/Students | 201 Created, or 400 for invalid data |
| PUT | /api/Students/{id} | 200 with updated student, or 404 |
| DELETE | /api/Students/{id} | 204 No Content, or 404 |
| GET | /api/Diagnostics/ping | 200, API status |
| GET | /api/Diagnostics/error | 500 JSON from the exception middleware |

## Middleware
- `GlobalExceptionMiddleware`: turns unhandled exceptions into a JSON 500 response.
- `RequestTimingMiddleware`: logs each request and adds the `X-Response-Time-Ms` response header.
