using Microsoft.EntityFrameworkCore.Migrations;

namespace Cars.Migrations
{
    public partial class tables_names_changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarRentals_Employee_UserId",
                table: "CarRentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Model_ModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Brands_BrandId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_CarDrive_CarDriveId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_FuelType_FuelTypeId",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FuelType",
                table: "FuelType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarDrive",
                table: "CarDrive");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Models");

            migrationBuilder.RenameTable(
                name: "FuelType",
                newName: "FuelTypes");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Information_Users");

            migrationBuilder.RenameTable(
                name: "CarDrive",
                newName: "CarDrives");

            migrationBuilder.RenameIndex(
                name: "IX_Model_FuelTypeId",
                table: "Models",
                newName: "IX_Models_FuelTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Model_CarDriveId",
                table: "Models",
                newName: "IX_Models_CarDriveId");

            migrationBuilder.RenameIndex(
                name: "IX_Model_BrandId",
                table: "Models",
                newName: "IX_Models_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuelTypes",
                table: "FuelTypes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Information_Users",
                table: "Information_Users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarDrives",
                table: "CarDrives",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarRentals_Information_Users_UserId",
                table: "CarRentals",
                column: "UserId",
                principalTable: "Information_Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_CarDrives_CarDriveId",
                table: "Models",
                column: "CarDriveId",
                principalTable: "CarDrives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_FuelTypes_FuelTypeId",
                table: "Models",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarRentals_Information_Users_UserId",
                table: "CarRentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_CarDrives_CarDriveId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_FuelTypes_FuelTypeId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Information_Users",
                table: "Information_Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FuelTypes",
                table: "FuelTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarDrives",
                table: "CarDrives");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Model");

            migrationBuilder.RenameTable(
                name: "Information_Users",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "FuelTypes",
                newName: "FuelType");

            migrationBuilder.RenameTable(
                name: "CarDrives",
                newName: "CarDrive");

            migrationBuilder.RenameIndex(
                name: "IX_Models_FuelTypeId",
                table: "Model",
                newName: "IX_Model_FuelTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Models_CarDriveId",
                table: "Model",
                newName: "IX_Model_CarDriveId");

            migrationBuilder.RenameIndex(
                name: "IX_Models_BrandId",
                table: "Model",
                newName: "IX_Model_BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuelType",
                table: "FuelType",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarDrive",
                table: "CarDrive",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarRentals_Employee_UserId",
                table: "CarRentals",
                column: "UserId",
                principalTable: "Employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Model_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Brands_BrandId",
                table: "Model",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_CarDrive_CarDriveId",
                table: "Model",
                column: "CarDriveId",
                principalTable: "CarDrive",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_FuelType_FuelTypeId",
                table: "Model",
                column: "FuelTypeId",
                principalTable: "FuelType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
