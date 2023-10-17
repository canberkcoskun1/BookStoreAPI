using BookStore.Service.Exceptions;
using BookStoreAPI.DTO;
using System.Net;
using System.Text.Json;

namespace BookStore.API.Middlewares
{
    public class GlobalExceptionMiddleware 
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;
        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception err)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                HttpStatusCode statusCode;
                switch (err)
                {
                    case ClientSideException ex:
                        statusCode = HttpStatusCode.BadRequest;
                        break;
                    case NotFoundException ex:
                        statusCode = HttpStatusCode.NotFound;
                        break;
                    default:
                        statusCode = HttpStatusCode.InternalServerError;
                        break;
                }

                response.StatusCode = (int)statusCode;
                var result = CustomResponseDto.Fail(err.Message, statusCode);
                await response.WriteAsJsonAsync(JsonSerializer.Serialize(result));
                _logger.LogError($"Error: {err.Message}");
            }
        }
    }
}
