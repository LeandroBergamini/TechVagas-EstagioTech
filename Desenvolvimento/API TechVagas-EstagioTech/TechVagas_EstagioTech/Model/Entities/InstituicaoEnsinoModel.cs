using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechVagas_EstagioTech.Model.Entities
{
    [Table("instituicaoensino")]
    public class InstituicaoEnsinoModel
    {
        [Key]
        [Column("instituicaoensinoid")]
        public int InstituicaoEnsinoId { get; set; }

        [Column("nomeinstituicao")]
        public string NomeInstituicao { get; set; }

        [Column("local")]
        public string Local {  get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        public ICollection<CursoModel>? Curso { get; set; }

    }
}
