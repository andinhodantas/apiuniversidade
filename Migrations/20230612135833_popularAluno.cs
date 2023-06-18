using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiUniversidade.Migrations
{
    /// <inheritdoc />
    public partial class popularAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO ALUNOS(Nome,CargaHoraria,Semestre)
            Values('Anderson',1993,05,21,'09658723545')");
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ALUNOS");
        }
    }
}
