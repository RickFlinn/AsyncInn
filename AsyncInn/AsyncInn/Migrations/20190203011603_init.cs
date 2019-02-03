using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Coffee Manufacturing Unit" },
                    { 2, "Gnome Butler" },
                    { 3, "Flea-Free Bedding" },
                    { 4, "Wall-Mounted Cookie Dispenser" },
                    { 5, "Pull-Out Hot Tub" },
                    { 6, "Guy With Giant Gong Alarm Clock" },
                    { 7, "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "HotelLocations",
                columns: new[] { "ID", "Address", "Name", "Phone" },
                values: new object[,]
                {
                    { 5, "Deep, deep, deep underground", "The Mole-mensville Async", "1-800-DIG-DEEP" },
                    { 4, "Greater Downtown Amazon", "Amazon-syncInn", "206-574-7699" },
                    { 2, "Downtownish", "Ponk Place", "206-299-9000" },
                    { 1, "123 Nonexistington Street", "Charleston", "885-900-1337" },
                    { 3, "Somewhere Over the Rainbow", "Emerald City AsyncInn", "Tap the ruby slippers three times" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "Layout", "Name" },
                values: new object[,]
                {
                    { 5, 0, "Homely Tuscan Countryside Peasant Farmhouse Studio" },
                    { 1, 0, "Teeny, Tiny, Trashable" },
                    { 2, 2, "School Field Trip Suite" },
                    { 3, 1, "The Seedy Motel Experience" },
                    { 4, 1, "Loosely Typed Relaxation Getaway" },
                    { 6, 1, "All Out Of Ideas Layout" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HotelLocations",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelLocations",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotelLocations",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotelLocations",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HotelLocations",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
