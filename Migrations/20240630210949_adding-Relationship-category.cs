using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneBook.Migrations
{
    /// <inheritdoc />
    public partial class addingRelationshipcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RelationshipId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Relationship",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationship", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_RelationshipId",
                table: "Contacts",
                column: "RelationshipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Relationship_RelationshipId",
                table: "Contacts",
                column: "RelationshipId",
                principalTable: "Relationship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Relationship_RelationshipId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "Relationship");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_RelationshipId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "RelationshipId",
                table: "Contacts");
        }
    }
}
