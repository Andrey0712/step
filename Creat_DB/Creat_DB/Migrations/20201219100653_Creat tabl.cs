using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Creat_DB.Migrations
{
    public partial class Creattabl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    UrlSlug = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UrlSlug = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Meta = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    UrlSlug = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Published = table.Column<byte>(type: "smallint", maxLength: 50, nullable: false),
                    PostedOn = table.Column<byte>(type: "smallint", maxLength: 50, nullable: false),
                    Modified = table.Column<byte>(type: "smallint", maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPost_tblCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "tblCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPostTagMap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Post_Id = table.Column<int>(type: "integer", nullable: false),
                    Tag_Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPostTagMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPostTagMap_tblPost_Post_Id",
                        column: x => x.Post_Id,
                        principalTable: "tblPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPostTagMap_tblTag_Tag_Id",
                        column: x => x.Tag_Id,
                        principalTable: "tblTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPost_CategoryId",
                table: "tblPost",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostTagMap_Post_Id",
                table: "tblPostTagMap",
                column: "Post_Id");

            migrationBuilder.CreateIndex(
                name: "IX_tblPostTagMap_Tag_Id",
                table: "tblPostTagMap",
                column: "Tag_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPostTagMap");

            migrationBuilder.DropTable(
                name: "tblPost");

            migrationBuilder.DropTable(
                name: "tblTag");

            migrationBuilder.DropTable(
                name: "tblCategory");
        }
    }
}
