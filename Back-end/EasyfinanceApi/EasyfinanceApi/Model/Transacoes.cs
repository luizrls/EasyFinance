namespace EasyfinanceApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Transacoes")]
    public class Transacoes
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        public double valor { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        [Required]
        [StringLength(50)]
        public string competencia { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        public virtual Usuarios Usuario { get; set; }

    }
}
