using System.ComponentModel.DataAnnotations;

namespace RocketseatCSharpDesafio02.Entities;

public class Book
{
    [Key]
    public int BookId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public EnumBase.Genre Genre { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}