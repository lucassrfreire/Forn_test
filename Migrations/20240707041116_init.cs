using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FornecedorAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            //Seed Data
            migrationBuilder.Sql(@"  INSERT INTO Fornecedor (id, nome, email, ativo)
                                                    VALUES
                                                      (newid(), 'Chandler Leonard','sem.consequat@aol.net', 1),
                                                      (newid(), 'Brianna Ross','congue@outlook.org', 1),
                                                      (newid(), 'Inez Langley','vulputate.eu.odio@aol.couk', 1),
                                                      (newid(), 'Lila Palmer','malesuada.fringilla@yahoo.org', 1),
                                                      (newid(), 'Maxwell Solis','est.mauris@hotmail.couk', 1),
                                                      (newid(), 'Connor Park','pellentesque@google.ca', 1),
                                                      (newid(), 'Giacomo Warren','suspendisse.sed.dolor@yahoo.edu', 1),
                                                      (newid(), 'Malcolm James','id.ante@icloud.edu', 1),
                                                      (newid(), 'Demetria Barry','pede.suspendisse@outlook.edu', 1),
                                                      (newid(), 'MacKenzie Dennis','hendrerit.donec@outlook.org', 1),
                                                      (newid(), 'Octavius Mcneil','mauris@protonmail.edu', 1),
                                                      (newid(), 'Warren Lang','cum.sociis@yahoo.couk', 1),
                                                      (newid(), 'Dacey Hinton','ultrices.sit.amet@icloud.com', 1),
                                                      (newid(), 'Hayden Rocha','lacus@google.net', 1),
                                                      (newid(), 'Vera Herman','arcu.sed@hotmail.edu', 1),
                                                      (newid(), 'Ignatius Mcconnell','id@outlook.ca', 1),
                                                      (newid(), 'Jamal Stafford','lorem.tristique@hotmail.couk', 1),
                                                      (newid(), 'Vanna Mack','quisque.nonummy@protonmail.couk', 1),
                                                      (newid(), 'Lani Byers','eu@yahoo.net', 1),
                                                      (newid(), 'Samuel York','donec.egestas.aliquam@aol.org', 1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
