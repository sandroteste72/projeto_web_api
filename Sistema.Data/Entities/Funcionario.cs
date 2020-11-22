using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Data.Entities
{
    [Table("TB_FUNCIONARIO")]
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODFUNCIONARIO_PK")]
        public virtual int IdFuncionario { get; set; }
        [Required]
        [StringLength(50)]
        [Column("NOME")]
        public virtual string Nome { get; set; }
        [Required]
        [Column("SALARIO")]
        public virtual decimal Salario { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Column("DATAADMISSAO")]
        public virtual DateTime DataAdmissao { get; set; }
        [Required]
        [Column("CODCARGO_FK")]
        public virtual int IdCargo { get; set; }
        //Relacionamentos (Associação -> Navegabilidade)
        [InverseProperty("Funcionario")]
        public virtual Endereco Endereco { get; set; }
        [ForeignKey("IdCargo")] //chave estrangeira..
        public virtual Cargo Cargo { get; set; }
    }
}
