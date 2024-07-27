using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhoneBook.Migrations
{
    /// <inheritdoc />
    public partial class checkingRelationshipcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Relationship_RelationshipId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Relationship",
                table: "Relationship");

            migrationBuilder.RenameTable(
                name: "Relationship",
                newName: "Relationships");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relationships",
                table: "Relationships",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Relationships_RelationshipId",
                table: "Contacts",
                column: "RelationshipId",
                principalTable: "Relationships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Relationships_RelationshipId",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Relationships",
                table: "Relationships");

            migrationBuilder.RenameTable(
                name: "Relationships",
                newName: "Relationship");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relationship",
                table: "Relationship",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Relationship_RelationshipId",
                table: "Contacts",
                column: "RelationshipId",
                principalTable: "Relationship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
