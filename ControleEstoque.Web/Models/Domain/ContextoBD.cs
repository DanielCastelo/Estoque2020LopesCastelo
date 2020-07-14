using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using ControleEstoque.Web.Models.Maps;

namespace ControleEstoque.Web.Models
{
    public class ContextoBD : DbContext
    {
        public ContextoBD() : base("name=principal")
    {
    }
    
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
       modelBuilder.Configurations.Add(new CidadeMap());
    }

    public DbSet<CidadeModel> Cidades { get; set; }
    }
}