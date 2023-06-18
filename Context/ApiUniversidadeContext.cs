using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Escola.Model;


namespace ApiUniversidade.Context;
public class ApiUniversidadeContext : DbContext

{
    public ApiUniversidadeContext(DbContextOptions<ApiUniversidadeContext> options) : base (options){}


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.LowercaseRelationalTableANdPropertyNames();
    }
    
    public DbSet<Curso>? Cursos { get; set; }
    public DbSet<Disciplina>? Disciplinas { get; set; }
    public DbSet<Aluno>? Alunos { get; set; }
}
static class DataContextExtensions
{
    public static void LowercaseRelationalTableANdPropertyNames(this ModelBuilder modelBuilder)
    {
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        
        {
            entity.SetTableName(entity.GetTableName().ToLowerInvariant());

           foreach (var property in entity.GetProperties())
           {
               property.SetColumnName(property.GetColumnName().ToLowerInvariant());
           } 
        }
    }
}
//segunda