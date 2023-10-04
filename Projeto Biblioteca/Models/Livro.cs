using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Biblioteca.Models {

    [Table("Livros")]
    public class Livro {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Titulo { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o Autor!")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ISBN!")]
        public string ISBN { get; set; }

    }
}
