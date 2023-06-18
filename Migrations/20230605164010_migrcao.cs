using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiUniversidade.Migrations
{
    /// <inheritdoc />
    public partial class migrcao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO CURSOS(Nome,Area,Duracao)
            Values('Tecnologia em Sistemas para Internet','Computação',6)");
            migrationBuilder.Sql(@"INSERT INTO CURSOS(Nome,Area,Duracao)
            Values('Técnico Integrado em Informatica','Computação',8)");
            migrationBuilder.Sql(@"INSERT INTO CURSOS(Nome,Area,Duracao)
            Values('Técnico Integrado em Alimentos','Alimentos',8)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CURSOS");
        }
    }
}
