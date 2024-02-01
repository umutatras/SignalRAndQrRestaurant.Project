using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    public partial class EntityConfigurationDefinition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_Id",
                table: "Testimonials",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_Id",
                table: "SocialMedias",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Features_Id",
                table: "Features",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_Id",
                table: "Discounts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Id",
                table: "Contacts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_Id",
                table: "Abouts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Testimonials_Id",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_Id",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_Products_Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Features_Id",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Discounts_Id",
                table: "Discounts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_Id",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_Id",
                table: "Abouts");
        }
    }
}
