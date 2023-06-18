using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiUniversidade.Migrations
{
    /// <inheritdoc />
    public partial class popularDisciplina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Disciplinas(Nome,CargaHoraria,Semestre)
            Values('Banco de dados',40,2)");
            migrationBuilder.Sql(@"INSERT INTO DISCIPLINA(Nome,CargaHoraria,Semestre)
            Values('Front-end',40,2)");
             migrationBuilder.Sql(@"INSERT INTO DISCIPLINA(Nome,CargaHoraria,Semestre)
            Values('IOT',20,2)");
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM DISCIPLINAS");
        }
    }
}
