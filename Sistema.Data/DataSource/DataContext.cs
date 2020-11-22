using Sistema.Data.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Data.DataSource
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["aula"].ConnectionString)
        {

        }

        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
    }
}
