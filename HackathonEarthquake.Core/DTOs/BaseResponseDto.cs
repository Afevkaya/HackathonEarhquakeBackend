using System.Text.Json.Serialization;

namespace HackathonEarthquake.Core.DTOs;

public class BaseResponseDto<T>
{
    public T Data { get; set; }
        
    [JsonIgnore]
    public int StatusCode { get; set; }
    public List<string> Errors { get; set; }

    // Static Factory Design Pattern
    public static BaseResponseDto<T> Success(int statusCode, T data)
    {
        return new BaseResponseDto<T> { StatusCode = statusCode, Data = data };
    }

    public static BaseResponseDto<T> Success(int statusCode)
    {
        return new BaseResponseDto<T> { StatusCode = statusCode };
    }

    public static BaseResponseDto<T> Fail(int statusCode, List<string> errors)
    {
        return new BaseResponseDto<T>{ StatusCode = statusCode, Errors = errors };
    }

    public static BaseResponseDto<T> Fail(int statusCode, string error)
    {
        return new BaseResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
    }
}