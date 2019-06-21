using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeflyAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblBookingDetails",
                columns: table => new
                {
                    paymentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    customerId = table.Column<string>(nullable: false),
                    firstName = table.Column<string>(nullable: false),
                    laststName = table.Column<string>(nullable: false),
                    emailId = table.Column<string>(nullable: false),
                    mobileNo = table.Column<long>(nullable: false),
                    address = table.Column<string>(nullable: false),
                    state = table.Column<string>(nullable: false),
                    city = table.Column<string>(nullable: false),
                    pinCode = table.Column<string>(nullable: false),
                    routeId = table.Column<string>(nullable: false),
                    scheduleId = table.Column<string>(nullable: false),
                    planeId = table.Column<string>(nullable: false),
                    ticketPrice = table.Column<long>(nullable: false),
                    noSeatsBooked = table.Column<int>(nullable: false),
                    journeyTime = table.Column<DateTime>(nullable: false),
                    cardNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBookingDetails", x => x.paymentId);
                    table.UniqueConstraint("AK_tblBookingDetails_customerId", x => x.customerId);
                    table.UniqueConstraint("AK_tblBookingDetails_customerId_paymentId", x => new { x.customerId, x.paymentId });
                });

            migrationBuilder.CreateTable(
                name: "tblCities",
                columns: table => new
                {
                    cityCode = table.Column<string>(nullable: false),
                    CityName = table.Column<string>(nullable: false),
                    AirportName = table.Column<string>(nullable: false),
                    AirportCode = table.Column<string>(nullable: false),
                    Longitude = table.Column<string>(nullable: true),
                    Lattitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCities", x => x.cityCode);
                });

            migrationBuilder.CreateTable(
                name: "tblFlightRoute",
                columns: table => new
                {
                    routeId = table.Column<string>(nullable: false),
                    fromCityCode = table.Column<string>(nullable: true),
                    fromCityName = table.Column<string>(nullable: true),
                    toCityCode = table.Column<string>(nullable: true),
                    toCityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFlightRoute", x => x.routeId);
                });

            migrationBuilder.CreateTable(
                name: "tblFlightSchedule",
                columns: table => new
                {
                    scheduleId = table.Column<string>(nullable: false),
                    routeId = table.Column<string>(nullable: true),
                    planeId = table.Column<string>(nullable: true),
                    arrivalTimeSource = table.Column<DateTime>(nullable: false),
                    departTimeSource = table.Column<DateTime>(nullable: false),
                    arrivalTimeDestination = table.Column<DateTime>(nullable: false),
                    noOfStops = table.Column<int>(nullable: false),
                    flightPrice = table.Column<long>(nullable: false),
                    availableSeats = table.Column<int>(nullable: false),
                    flightDuration = table.Column<long>(nullable: false),
                    isMealAvailable = table.Column<bool>(nullable: false),
                    airlineName = table.Column<string>(nullable: true),
                    airlineLogo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFlightSchedule", x => x.scheduleId);
                });

            migrationBuilder.CreateTable(
                name: "tblPlaneSpecification",
                columns: table => new
                {
                    planeId = table.Column<string>(nullable: false),
                    planeManufacturer = table.Column<string>(nullable: true),
                    planeModel = table.Column<string>(nullable: true),
                    seats = table.Column<int>(nullable: false),
                    legSpace = table.Column<long>(nullable: false),
                    isWifiAvailable = table.Column<bool>(nullable: false),
                    isFlightEntertainmentAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPlaneSpecification", x => x.planeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblBookingDetails");

            migrationBuilder.DropTable(
                name: "tblCities");

            migrationBuilder.DropTable(
                name: "tblFlightRoute");

            migrationBuilder.DropTable(
                name: "tblFlightSchedule");

            migrationBuilder.DropTable(
                name: "tblPlaneSpecification");
        }
    }
}
