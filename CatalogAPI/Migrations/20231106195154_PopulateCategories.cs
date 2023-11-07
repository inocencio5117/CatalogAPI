using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulateCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Drinks', 'drinks.jpg')");
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Snacks', 'snacks.jpg')");
            mb.Sql("Insert into Categories(Name, ImageUrl) Values('Desserts', 'desserts.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categories");
        }
    }
}
