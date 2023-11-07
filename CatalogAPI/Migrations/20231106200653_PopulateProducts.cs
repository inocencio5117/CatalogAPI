using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulateProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Products(Name, description, Price, ImageUrl, Stock, CreatedAt, CategoryId)" +
                "Values('Diet Coke', 'Coke Fizzy Drink 350ml', '5.45', 'coke.jpg', 50, now(), 3)");

            mb.Sql("Insert into Products(Name, description, Price, ImageUrl, Stock, CreatedAt, CategoryId)" +
                "Values('Atum Sandwich', 'Atum Sandwich with mayo', '8.50', 'atum.jpg', 10, now(), 4)");

            mb.Sql("Insert into Products(Name, description, Price, ImageUrl, Stock, CreatedAt, CategoryId)" +
                "Values('Pudding', 'Condensed milk pudding', '6.75', 'pudding.jpg', 20, now(), 5)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Products");
        }
    }
}
