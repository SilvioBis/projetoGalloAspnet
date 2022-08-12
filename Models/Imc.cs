using System.ComponentModel.DataAnnotations;

namespace Exercicios.Models
{
    public class Imc
    {
    [Display(Name = "Peso",Prompt = "Peso")]
    [Required(ErrorMessage = "Informe o Peso")]
    [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
    public double pesoIdeal { get; set; }

    [Display(Name = "Altura")]
    [Required(ErrorMessage = "Informe sua Altura")]
    [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Informe um valor válido!")]
    public double Pesocerto { get; set; }
    }

    
}