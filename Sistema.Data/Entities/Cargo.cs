using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Data.Entities
{
    public class Cargo
    {
        [Key] //chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //identity
        [Column("CODCARGO_PK")] //nome da coluna
        public virtual int IdCargo { get; set; }
        [Required] //not null
        [Index("IDX_NOMECARGO", IsUnique = true)] //unique
        [StringLength(50)] //nvarchar(50)
        [Column("NOME")] //nome da coluna
        public virtual string Nome { get; set; }
        [Required] //not null
        [Column("DESCRICAO")] //nome da coluna
        public virtual string Descricao { get; set; }
        //Relacionamento (Associação -> TER)
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
