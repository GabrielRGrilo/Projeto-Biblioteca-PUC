using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Components.Forms;

namespace Projeto_Biblioteca.Models 
    {
    
    
    [Table("Usuarios")]
    public class Usuario {
     

            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o nome!")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Obrigatório informar a data de nascimento!")]
            [Display(Name = "Data de Nascimento")]
            public DateTime DataDeNascimento { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o Email!")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o Telefone!")]
            public int Telefone { get; set; }


        }
    }


