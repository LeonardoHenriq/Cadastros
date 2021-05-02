using Cadastrar_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cadastrar_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        public DbSet<Pf> Pf { get; set; }
        public DbSet<Pj> Pj { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.Entity<Pf>()
                .HasData(new List<Pf>(){
                    new Pf(1, "Marta","111.111.111-11",22,"(17)99150-9019","rua: xyz"),
                    new Pf(2, "Paula","111.111.111-11",22,"(17)99150-9019","rua: xyz"),
                    new Pf(3, "Laura","111.111.111-11",22,"(17)99150-9019","rua: xyz"),
                    new Pf(4, "Luiza","111.111.111-11",22,"(17)99150-9019","rua: xyz"),
                    new Pf(5, "Lucas","111.111.111-11",22,"(17)99150-9019","rua: xyz"),
                    new Pf(6, "Pedro","111.111.111-11",22,"(17)99150-9019","rua: xyz"),
                    new Pf(7, "Paulo","111.111.111-11",22,"(17)99150-9019","rua: xyz"),
                });
            
            builder.Entity<Pj>()
                .HasData(new List<Pj>(){
                    new Pj(1,"data par", "111.111.111/0001-1","rua: xjh","(17)3333-3333"),
                    new Pj(2,"riopretrans", "222.222.222/0001-1","rua: abc","(17)3333-3333"),
                    new Pj(3,"transreal", "333.333.333/0001-1","rua: yaz","(17)3333-3333"),
                    new Pj(4,"real rondonia", "444.444.444/0001-1","rua: asd","(17)3333-3333"),

                });
        }
    }
}