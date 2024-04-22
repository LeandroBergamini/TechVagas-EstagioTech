﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TechVagas_EstagioTech.Model.Entities
{
    [Table("curso")]
    public class CursoModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nomecurso")]
        public string? nomeCurso { get; set; }


        [Column("turnocurso")]
        public string? turnoCurso { get; set; } 

        public InstituicaoEnsinoModel instituicaoEnsinoModel { get; set; }

        public int InstituicaoEnsinoId { get; set; }
    } 
}
