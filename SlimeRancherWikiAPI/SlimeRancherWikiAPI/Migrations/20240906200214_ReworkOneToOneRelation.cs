using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlimeRancherWikiAPI.Migrations
{
    /// <inheritdoc />
    public partial class ReworkOneToOneRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Slimes_SlimeId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Plorts_Slimes_SlimeId",
                table: "Plorts");

            migrationBuilder.DropForeignKey(
                name: "FK_Toys_Slimes_SlimeId",
                table: "Toys");

            migrationBuilder.DropIndex(
                name: "IX_Toys_SlimeId",
                table: "Toys");

            migrationBuilder.DropIndex(
                name: "IX_Plorts_SlimeId",
                table: "Plorts");

            migrationBuilder.DropIndex(
                name: "IX_Foods_SlimeId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "SlimeId",
                table: "Toys");

            migrationBuilder.DropColumn(
                name: "SlimeId",
                table: "Plorts");

            migrationBuilder.DropColumn(
                name: "SlimeId",
                table: "Foods");

            migrationBuilder.AddColumn<string>(
                name: "FavFoodId",
                table: "Slimes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlortId",
                table: "Slimes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToyId",
                table: "Slimes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Slimes_FavFoodId",
                table: "Slimes",
                column: "FavFoodId",
                unique: true,
                filter: "[FavFoodId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Slimes_PlortId",
                table: "Slimes",
                column: "PlortId",
                unique: true,
                filter: "[PlortId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Slimes_ToyId",
                table: "Slimes",
                column: "ToyId",
                unique: true,
                filter: "[ToyId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Slimes_Foods_FavFoodId",
                table: "Slimes",
                column: "FavFoodId",
                principalTable: "Foods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Slimes_Plorts_PlortId",
                table: "Slimes",
                column: "PlortId",
                principalTable: "Plorts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Slimes_Toys_ToyId",
                table: "Slimes",
                column: "ToyId",
                principalTable: "Toys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slimes_Foods_FavFoodId",
                table: "Slimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Slimes_Plorts_PlortId",
                table: "Slimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Slimes_Toys_ToyId",
                table: "Slimes");

            migrationBuilder.DropIndex(
                name: "IX_Slimes_FavFoodId",
                table: "Slimes");

            migrationBuilder.DropIndex(
                name: "IX_Slimes_PlortId",
                table: "Slimes");

            migrationBuilder.DropIndex(
                name: "IX_Slimes_ToyId",
                table: "Slimes");

            migrationBuilder.DropColumn(
                name: "FavFoodId",
                table: "Slimes");

            migrationBuilder.DropColumn(
                name: "PlortId",
                table: "Slimes");

            migrationBuilder.DropColumn(
                name: "ToyId",
                table: "Slimes");

            migrationBuilder.AddColumn<string>(
                name: "SlimeId",
                table: "Toys",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SlimeId",
                table: "Plorts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SlimeId",
                table: "Foods",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Toys_SlimeId",
                table: "Toys",
                column: "SlimeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plorts_SlimeId",
                table: "Plorts",
                column: "SlimeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_SlimeId",
                table: "Foods",
                column: "SlimeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Slimes_SlimeId",
                table: "Foods",
                column: "SlimeId",
                principalTable: "Slimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plorts_Slimes_SlimeId",
                table: "Plorts",
                column: "SlimeId",
                principalTable: "Slimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Toys_Slimes_SlimeId",
                table: "Toys",
                column: "SlimeId",
                principalTable: "Slimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
