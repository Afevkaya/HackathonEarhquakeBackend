namespace HackathonEarthquake.Core.DTOs;

public class BaseResponseDto<T>
{
    public BaseResponseDto()
    {
        
    }
    public string Message { get; set; }
    public bool IsStatus { get; set; }
    public T Data { get; set; }
}