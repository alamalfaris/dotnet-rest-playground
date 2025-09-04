using System.Net;

namespace monolith_api_playground.Models
{
    public class ApiResponse<T>
    {
        public string? Message { get; set; }
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }

        public ApiResponse(T? data, string? message = null, List<string>? errors = null)
        {
            Message = message;
            Data = data;
            Errors = errors;
        }

        public static ApiResponse<T> SuccessResponse(T data)
        {
            return new ApiResponse<T>(data);
        }

        public static ApiResponse<T> ErrorResponse(T data, string? message = null, List<string>? errors = null)
        {
            return new ApiResponse<T>(data, message, errors);
        }
    }
}
