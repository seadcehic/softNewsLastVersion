using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

namespace SoftNews.Repository.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            byte[] passwordHash, passwordSalt;

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("sead"));
            }

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "sead", "Sead", "Cehic", passwordHash, passwordSalt });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name" },
                values: new object[] { "Sport" }
                );

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name" },
                values: new object[] { "Biznis" }
                );
            migrationBuilder.InsertData(
               table: "Categories",
               columns: new[] { "Name" },
               values: new object[] { "Kutlura" }
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
