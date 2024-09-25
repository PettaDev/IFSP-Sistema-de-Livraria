using System.ComponentModel.DataAnnotations;

namespace Livraria.Models;

public class Livro
{
    public int Id {get; set; }
    public string? Titulo {get; set; }
    [DataType(DataType.Date)]
    public DateTime DataLancamento { get; set; }
    public string? Genero { get; set; } // string? indca que a propriedade permite valor nulo
    public decimal Preco { get; set; }
}