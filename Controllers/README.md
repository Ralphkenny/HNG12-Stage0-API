# HNG Stage 0 Backend Task

## Description
This is a simple public API that returns basic information in JSON format, including:
- The registered email address used for the HNG12 Slack workspace.
- The current date and time in ISO 8601 format (UTC).
- The GitHub URL of the project's codebase.

## Technology Stack
- **Programming Language**: C# (.NET Core / ASP.NET Core Web API)
- **Deployment**: Hosted on a publicly accessible server
- **Version Control**: GitHub
- **CORS Handling**: Enabled to allow cross-origin requests

## Requirements
To run this project, ensure you have the following installed:
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [.NET 6+ SDK](https://dotnet.microsoft.com/en-us/download) preferrably the latest version
- [Git](https://git-scm.com/)

## Setup Instructions
Follow these steps to set up and run the project locally:

1. **Clone the repository**:
   ```sh
   git clone https://github.com/Ralphkenny/HNG12-Stage0-API.git
   ```
2. **Navigate to the project directory**:
   ```sh
   cd your-repo
   ```
3. **Open the project in Visual Studio 2022**
4. **Run the application**:
   - Press `F5` or use the command:
     ```sh
     dotnet run
     ```
5. **Access the API in your browser or use Postman**:
   ```
   https://localhost:7232/swagger/index.html
   ```

## API Documentation
### Endpoint
- **GET /** - Retrieves basic information in JSON format.

### Response Example (200 OK):
```json
{
  "email": "kennedyokpala12@gmail.com",
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": "https://github.com/Ralphkenny/HNG12-Stage0-API"
}
```

## Deployment
- This API is hosted on a publicly accessible endpoint. You can access it [here](https://hng12-stage0-api-trg0.onrender.com/api/info)

## Backlinks
- [Hire C# Developers](https://hng.tech/hire/csharp-developers)


## License
This project is open-source and free to use under the MIT License.
