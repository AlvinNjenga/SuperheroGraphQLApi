using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperHeroGraphqlApi.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("413c8839-e396-4712-9c70-7da692610cf1"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("b2a5d9cb-576f-4591-8c6f-6369475acf89"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("e674c39f-e8f9-4d0c-b9fb-44057157b327"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("2a732e2d-32b9-4f46-9238-add910404c8b"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("413c8839-e396-4712-9c70-7da692610cf1"), "Black Widow" },
                    { new Guid("5e93d1bf-9bbf-4b41-bfa2-91c37ccd7b35"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e674c39f-e8f9-4d0c-b9fb-44057157b327"), "The Dark Knight Rises" },
                    { new Guid("6c267c73-d16b-48bd-80dd-d6dbc7a5f0a7"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e674c39f-e8f9-4d0c-b9fb-44057157b327"), "Batman Begins" },
                    { new Guid("82e10303-244c-40a7-b473-ef4941b414ff"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2a5d9cb-576f-4591-8c6f-6369475acf89"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("8c949630-0751-40a2-a16b-6df9a5e88b93"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e674c39f-e8f9-4d0c-b9fb-44057157b327"), "The Dark Knight" },
                    { new Guid("94006812-a346-4293-a1a8-0095bdb14222"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2a5d9cb-576f-4591-8c6f-6369475acf89"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("ac5d7048-1212-49be-8398-68f5b2e1c110"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2a5d9cb-576f-4591-8c6f-6369475acf89"), "Star Wars: Episode VI – Return of the Jedi" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "Name", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("14eaa49b-c82a-4668-9a5d-d69577804fd1"), "She's good at spying at people.", "Espionage", new Guid("413c8839-e396-4712-9c70-7da692610cf1") },
                    { new Guid("2fb1e7c2-6bdd-489e-9813-616a33a7e93c"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("413c8839-e396-4712-9c70-7da692610cf1") },
                    { new Guid("5b0e2f27-2341-4ca8-a7ff-78029702e2bc"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("b2a5d9cb-576f-4591-8c6f-6369475acf89") },
                    { new Guid("5d4e30b5-bbcb-486b-b10d-3cf8a069bab6"), "Luke is able to channel the Force that permeates all living things to lift objects, influence weak minds and numerous other Force abilities.", "The Force", new Guid("b2a5d9cb-576f-4591-8c6f-6369475acf89") },
                    { new Guid("6294a266-f3d4-4e19-8c5e-ed4dbfa68499"), "He's always a step ahead.", "Intellect.", new Guid("e674c39f-e8f9-4d0c-b9fb-44057157b327") },
                    { new Guid("74c99926-a210-48df-b46a-718a41b8720b"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("413c8839-e396-4712-9c70-7da692610cf1") },
                    { new Guid("d05585be-8154-41f7-9a68-e7ebbf64f16c"), "He got a lot of money", "Wealth.", new Guid("e674c39f-e8f9-4d0c-b9fb-44057157b327") },
                    { new Guid("edca0cc2-1b96-477d-86af-9030ce14a521"), "Sublime fighting skills.", "Fighting", new Guid("e674c39f-e8f9-4d0c-b9fb-44057157b327") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "Superheroes");
        }
    }
}
