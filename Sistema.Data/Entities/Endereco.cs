using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Data.Entities
{
    [Table("TB_ENDERECO")]
    public class Endereco
    {
        [Key, ForeignKey("Funcionario")]
        [Column("CODENDERECO_PK")]
        public virtual int IdEndereco { get; set; }
        [Required]
        [StringLength(250)]
        [Column("LOGRADOURO")]
        public virtual string Logradouro { get; set; }
        [Required]
        [StringLength(50)]
        [Column("BAIRRO")]
        public virtual string Bairro { get; set; }
        [Required]
        [StringLength(50)]
        [Column("CIDADE")]
        public virtual string Cidade { get; set; }
        [Required]
        [StringLength(25)]
        [Column("ESTADO")]
        public virtual string Estado { get; set; }
        [Required]
        [StringLength(10)]
        [Column("CEP")]
        public virtual string Cep { get; set; }
        //Relacionamento (Associação -> TER)
        [Required] //Funcionario é a classe principal do 1p1
        [InverseProperty("Endereco")] //1p1
        public virtual Funcionario Funcionario { get; set; }
    }
}
