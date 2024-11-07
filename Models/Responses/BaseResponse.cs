namespace RocketseatCSharpDesafio02.Models.Responses;

public class BaseResponse<T>
{
    public T? Data { get; set; }
}