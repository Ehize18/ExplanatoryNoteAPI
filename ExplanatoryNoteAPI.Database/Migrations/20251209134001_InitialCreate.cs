using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExplanatoryNoteAPI.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BudgetLevel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClimateDistrict",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimateDistrict", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstractionType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstractionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DangerIndustrialClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangerIndustrialClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DangerousAndComplex",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DangerousAndComplex", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EfficiencyClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EfficiencyClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FireDangerCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireDangerCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeologicalConditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeologicalConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LandCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModelFormat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelFormat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OKEI",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OKEI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantResponsibilityLevel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantResponsibilityLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Placement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegionsRF",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionsRF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibilityLevel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibilityLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeismicActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeismicActivity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SnowDistrict",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnowDistrict", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SROType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SROType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unique",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unique", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WindDistrict",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WindDistrict", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalData_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdditionalData_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChiefProjectEngineer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FamilyName = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    SecondName = table.Column<string>(type: "text", nullable: true),
                    SNILS = table.Column<string>(type: "text", nullable: true),
                    NOPRIZ = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiefProjectEngineer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiefProjectEngineer_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChiefProjectEngineer_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConstructionDates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OperationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConstructionDates_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConstructionDates_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documents_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EngineeringSurveyDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineeringSurveyDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EngineeringSurveyDocuments_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EngineeringSurveyDocuments_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExplanatoryNoteModifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExplanatoryNoteModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExplanatoryNoteModifications_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNoteModifications_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FinanceSources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FinanceComment = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceSources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinanceSources_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FinanceSources_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Model_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Model_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ObjectParts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjectParts_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ObjectParts_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocParticipants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocParticipants_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocParticipants_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocumentationAuthors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocumentationAuthors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocumentationAuthors_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentationAuthors_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocumentationLinks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocumentationLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocumentationLinks_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentationLinks_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocumentNotNecessarySectionContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocumentNotNecessarySectionContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocumentNotNecessarySectionContent_SysUser_CreatedBy~",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentNotNecessarySectionContent_SysUser_UpdatedBy~",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocumentSectionContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocumentSectionContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocumentSectionContent_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentSectionContent_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SROMembership",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SROMembership", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SROMembership_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SROMembership_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsedNorms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedNorms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsedNorms_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsedNorms_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Data",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DataDescription = table.Column<string>(type: "text", nullable: true),
                    AdditionalDataId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Data_AdditionalData_AdditionalDataId",
                        column: x => x.AdditionalDataId,
                        principalTable: "AdditionalData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Data_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Data_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Signers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ChiefProjectEngineerId = table.Column<Guid>(type: "uuid", nullable: true),
                    ChiefProjectArchitectId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Signers_ChiefProjectEngineer_ChiefProjectArchitectId",
                        column: x => x.ChiefProjectArchitectId,
                        principalTable: "ChiefProjectEngineer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Signers_ChiefProjectEngineer_ChiefProjectEngineerId",
                        column: x => x.ChiefProjectEngineerId,
                        principalTable: "ChiefProjectEngineer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Signers_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Signers_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EngineeringSurveyDocument",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    DocName = table.Column<string>(type: "text", nullable: true),
                    DocNumber = table.Column<string>(type: "text", nullable: true),
                    DocDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DocChanges = table.Column<string>(type: "text", nullable: true),
                    EngineeringSurveyDocumentsId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineeringSurveyDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EngineeringSurveyDocument_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EngineeringSurveyDocument_EngineeringSurveyDocuments_Engine~",
                        column: x => x.EngineeringSurveyDocumentsId,
                        principalTable: "EngineeringSurveyDocuments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EngineeringSurveyDocument_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EngineeringSurveyDocument_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Modification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ModificationNumber = table.Column<int>(type: "integer", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModificationNote = table.Column<string>(type: "text", nullable: true),
                    ExplanatoryNoteModificationsId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modification_ExplanatoryNoteModifications_ExplanatoryNoteMo~",
                        column: x => x.ExplanatoryNoteModificationsId,
                        principalTable: "ExplanatoryNoteModifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Modification_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Modification_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BudgetSource",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BudgetLevelId = table.Column<Guid>(type: "uuid", nullable: true),
                    SourceRatio = table.Column<decimal>(type: "numeric", nullable: true),
                    FinanceSourcesId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetSource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetSource_BudgetLevel_BudgetLevelId",
                        column: x => x.BudgetLevelId,
                        principalTable: "BudgetLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BudgetSource_FinanceSources_FinanceSourcesId",
                        column: x => x.FinanceSourcesId,
                        principalTable: "FinanceSources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BudgetSource_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BudgetSource_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PrivateSource",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SourceRatio = table.Column<decimal>(type: "numeric", nullable: true),
                    FinanceSourcesId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateSource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrivateSource_FinanceSources_FinanceSourcesId",
                        column: x => x.FinanceSourcesId,
                        principalTable: "FinanceSources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PrivateSource_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PrivateSource_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ModelFile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileFormat = table.Column<string>(type: "text", nullable: true),
                    FileRelativePath = table.Column<string>(type: "text", nullable: true),
                    FileChecksum = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ModelId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelFile_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModelFile_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModelFile_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocParticipant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FamilyName = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    SecondName = table.Column<string>(type: "text", nullable: true),
                    SNILS = table.Column<string>(type: "text", nullable: true),
                    NOPRIZ = table.Column<string>(type: "text", nullable: true),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocParticipantsId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocParticipant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocParticipant_ParticipantResponsibilityLevel_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ParticipantResponsibilityLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocParticipant_ProjectDocParticipants_ProjectDocPart~",
                        column: x => x.ProjectDocParticipantsId,
                        principalTable: "ProjectDocParticipants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocParticipant_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocParticipant_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocumentationLink",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DocNumber = table.Column<string>(type: "text", nullable: true),
                    DocSectionLink = table.Column<string>(type: "text", nullable: true),
                    ProjectDocumentationLinksId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocumentationLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocumentationLink_ProjectDocumentationLinks_ProjectD~",
                        column: x => x.ProjectDocumentationLinksId,
                        principalTable: "ProjectDocumentationLinks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentationLink_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentationLink_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    DocName = table.Column<string>(type: "text", nullable: true),
                    DocNumber = table.Column<string>(type: "text", nullable: true),
                    DocDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DocIssueAuthor = table.Column<string>(type: "text", nullable: true),
                    DocChanges = table.Column<string>(type: "text", nullable: true),
                    Link = table.Column<string>(type: "text", nullable: true),
                    Included = table.Column<string>(type: "text", nullable: true),
                    ProjectDocumentNotNecessarySectionContentId = table.Column<Guid>(type: "uuid", nullable: true),
                    DocumentsId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Document_Documents_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "Documents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Document_ProjectDocumentNotNecessarySectionContent_ProjectD~",
                        column: x => x.ProjectDocumentNotNecessarySectionContentId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Document_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Document_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SectionOtherContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IndustrialSafetyDeclarationId = table.Column<Guid>(type: "uuid", nullable: true),
                    HydraulicStructuresSafetyDeclarationId = table.Column<Guid>(type: "uuid", nullable: true),
                    CivilDefenseId = table.Column<Guid>(type: "uuid", nullable: true),
                    CounteringTerrorismId = table.Column<Guid>(type: "uuid", nullable: true),
                    RadiationNuclearSafetyId = table.Column<Guid>(type: "uuid", nullable: true),
                    SanitarySafetyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CulturalHeritageSitesId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandsReclamationId = table.Column<Guid>(type: "uuid", nullable: true),
                    BiologicalResourcesImpactId = table.Column<Guid>(type: "uuid", nullable: true),
                    OtherDocumentsId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionOtherContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionConte~",
                        column: x => x.BiologicalResourcesImpactId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionCont~1",
                        column: x => x.CivilDefenseId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionCont~2",
                        column: x => x.CounteringTerrorismId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionCont~3",
                        column: x => x.CulturalHeritageSitesId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionCont~4",
                        column: x => x.HydraulicStructuresSafetyDeclarationId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionCont~5",
                        column: x => x.IndustrialSafetyDeclarationId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionCont~6",
                        column: x => x.LandsReclamationId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionCont~7",
                        column: x => x.OtherDocumentsId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionCont~8",
                        column: x => x.RadiationNuclearSafetyId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_ProjectDocumentNotNecessarySectionCont~9",
                        column: x => x.SanitarySafetyId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionOtherContent_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocumentSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NotDeveloped = table.Column<string>(type: "text", nullable: true),
                    SectionContentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocumentSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocumentSection_ProjectDocumentSectionContent_Sectio~",
                        column: x => x.SectionContentId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentSection_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentSection_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocumentSubSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ParentSectionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentSectionContentId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentSubSectionId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocumentSubSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocumentSubSection_ProjectDocumentSectionContent_Pro~",
                        column: x => x.ProjectDocumentSectionContentId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentSubSection_ProjectDocumentSubSection_Project~",
                        column: x => x.ProjectDocumentSubSectionId,
                        principalTable: "ProjectDocumentSubSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentSubSection_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocumentSubSection_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Section5Content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ElectricitySupplyId = table.Column<Guid>(type: "uuid", nullable: true),
                    WaterSupplyId = table.Column<Guid>(type: "uuid", nullable: true),
                    WaterRemovalId = table.Column<Guid>(type: "uuid", nullable: true),
                    HeatingVentilationId = table.Column<Guid>(type: "uuid", nullable: true),
                    CommunicationId = table.Column<Guid>(type: "uuid", nullable: true),
                    GasSupplyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section5Content", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section5Content_ProjectDocumentSectionContent_Communication~",
                        column: x => x.CommunicationId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Section5Content_ProjectDocumentSectionContent_ElectricitySu~",
                        column: x => x.ElectricitySupplyId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Section5Content_ProjectDocumentSectionContent_GasSupplyId",
                        column: x => x.GasSupplyId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Section5Content_ProjectDocumentSectionContent_HeatingVentil~",
                        column: x => x.HeatingVentilationId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Section5Content_ProjectDocumentSectionContent_WaterRemovalId",
                        column: x => x.WaterRemovalId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Section5Content_ProjectDocumentSectionContent_WaterSupplyId",
                        column: x => x.WaterSupplyId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Section5Content_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Section5Content_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SectionEstimateContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EstimateExplanatoryNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CostSummaryId = table.Column<Guid>(type: "uuid", nullable: true),
                    SummaryEstimateId = table.Column<Guid>(type: "uuid", nullable: true),
                    ObjectEstimatesId = table.Column<Guid>(type: "uuid", nullable: true),
                    LocalEstimatesId = table.Column<Guid>(type: "uuid", nullable: true),
                    CostsEstimatesId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionEstimateContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionEstimateContent_ProjectDocumentSectionContent_CostSu~",
                        column: x => x.CostSummaryId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionEstimateContent_ProjectDocumentSectionContent_CostsE~",
                        column: x => x.CostsEstimatesId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionEstimateContent_ProjectDocumentSectionContent_Estima~",
                        column: x => x.EstimateExplanatoryNoteId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionEstimateContent_ProjectDocumentSectionContent_LocalE~",
                        column: x => x.LocalEstimatesId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionEstimateContent_ProjectDocumentSectionContent_Object~",
                        column: x => x.ObjectEstimatesId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionEstimateContent_ProjectDocumentSectionContent_Summar~",
                        column: x => x.SummaryEstimateId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionEstimateContent_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionEstimateContent_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SRO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SROTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    SROMembershipId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SRO_SROMembership_SROMembershipId",
                        column: x => x.SROMembershipId,
                        principalTable: "SROMembership",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SRO_SROType_SROTypeId",
                        column: x => x.SROTypeId,
                        principalTable: "SROType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SRO_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SRO_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsedNorm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UsedNormsId = table.Column<Guid>(type: "uuid", nullable: true),
                    Norm = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsedNorm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsedNorm_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsedNorm_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsedNorm_UsedNorms_UsedNormsId",
                        column: x => x.UsedNormsId,
                        principalTable: "UsedNorms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FamilyName = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    SecondName = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true),
                    EngineeringRegistry = table.Column<string>(type: "text", nullable: true),
                    ConstructionRegistry = table.Column<string>(type: "text", nullable: true),
                    SignersId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkPerson_Signers_SignersId",
                        column: x => x.SignersId,
                        principalTable: "Signers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkPerson_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkPerson_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OtherDocumentsSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NotDeveloped = table.Column<string>(type: "text", nullable: true),
                    SectionContentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherDocumentsSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherDocumentsSection_SectionOtherContent_SectionContentId",
                        column: x => x.SectionContentId,
                        principalTable: "SectionOtherContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtherDocumentsSection_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtherDocumentsSection_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectDocument",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DocName = table.Column<string>(type: "text", nullable: true),
                    DocNumber = table.Column<string>(type: "text", nullable: true),
                    DocChanges = table.Column<string>(type: "text", nullable: true),
                    ProjectDocParticipantsId = table.Column<Guid>(type: "uuid", nullable: true),
                    ObjectIDREFS = table.Column<string>(type: "text", nullable: true),
                    ProjectDocumentSectionContentId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentSubSectionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentNotNecessarySectionContentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDocument", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDocument_ProjectDocParticipants_ProjectDocParticipan~",
                        column: x => x.ProjectDocParticipantsId,
                        principalTable: "ProjectDocParticipants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocument_ProjectDocumentNotNecessarySectionContent_P~",
                        column: x => x.ProjectDocumentNotNecessarySectionContentId,
                        principalTable: "ProjectDocumentNotNecessarySectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocument_ProjectDocumentSectionContent_ProjectDocume~",
                        column: x => x.ProjectDocumentSectionContentId,
                        principalTable: "ProjectDocumentSectionContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocument_ProjectDocumentSubSection_ProjectDocumentSu~",
                        column: x => x.ProjectDocumentSubSectionId,
                        principalTable: "ProjectDocumentSubSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocument_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectDocument_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Section5",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NotDeveloped = table.Column<string>(type: "text", nullable: true),
                    SectionContentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section5", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section5_Section5Content_SectionContentId",
                        column: x => x.SectionContentId,
                        principalTable: "Section5Content",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Section5_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Section5_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SectionEstimate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NotDeveloped = table.Column<string>(type: "text", nullable: true),
                    SectionContentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionEstimate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SectionEstimate_SectionEstimateContent_SectionContentId",
                        column: x => x.SectionContentId,
                        principalTable: "SectionEstimateContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionEstimate_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SectionEstimate_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GasLinearProjectDocumentContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Section2Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section3Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section4Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section5Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section6Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section7Id = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasLinearProjectDocumentContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GasLinearProjectDocumentContent_OtherDocumentsSection_Secti~",
                        column: x => x.Section7Id,
                        principalTable: "OtherDocumentsSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasLinearProjectDocumentContent_ProjectDocumentSection_Sect~",
                        column: x => x.Section2Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasLinearProjectDocumentContent_ProjectDocumentSection_Sec~1",
                        column: x => x.Section3Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasLinearProjectDocumentContent_ProjectDocumentSection_Sec~2",
                        column: x => x.Section4Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasLinearProjectDocumentContent_ProjectDocumentSection_Sec~3",
                        column: x => x.Section5Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasLinearProjectDocumentContent_ProjectDocumentSection_Sec~4",
                        column: x => x.Section6Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasLinearProjectDocumentContent_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasLinearProjectDocumentContent_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileFormat = table.Column<string>(type: "text", nullable: true),
                    FileRelativePath = table.Column<string>(type: "text", nullable: true),
                    FileChecksum = table.Column<string>(type: "text", nullable: true),
                    DocumentId = table.Column<Guid>(type: "uuid", nullable: true),
                    EngineeringSurveyDocumentId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentId = table.Column<Guid>(type: "uuid", nullable: true),
                    DataId = table.Column<Guid>(type: "uuid", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.Id);
                    table.ForeignKey(
                        name: "FK_File_Data_DataId",
                        column: x => x.DataId,
                        principalTable: "Data",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_File_Document_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Document",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_File_EngineeringSurveyDocument_EngineeringSurveyDocumentId",
                        column: x => x.EngineeringSurveyDocumentId,
                        principalTable: "EngineeringSurveyDocument",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_File_ProjectDocument_ProjectDocumentId",
                        column: x => x.ProjectDocumentId,
                        principalTable: "ProjectDocument",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_File_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_File_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LinearProjectDocumentContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Section2Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section3Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section4Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section5Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section6Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section7Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section8Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section9Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section10Id = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinearProjectDocumentContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_OtherDocumentsSection_Section1~",
                        column: x => x.Section10Id,
                        principalTable: "OtherDocumentsSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_ProjectDocumentSection_Section~",
                        column: x => x.Section2Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_ProjectDocumentSection_Sectio~1",
                        column: x => x.Section3Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_ProjectDocumentSection_Sectio~2",
                        column: x => x.Section4Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_ProjectDocumentSection_Sectio~3",
                        column: x => x.Section5Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_ProjectDocumentSection_Sectio~4",
                        column: x => x.Section6Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_ProjectDocumentSection_Sectio~5",
                        column: x => x.Section7Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_ProjectDocumentSection_Sectio~6",
                        column: x => x.Section8Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_SectionEstimate_Section9Id",
                        column: x => x.Section9Id,
                        principalTable: "SectionEstimate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearProjectDocumentContent_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NonLinearProjectDocumentContent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Section2Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section3Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section4Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section5Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section6Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section7Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section8Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section9Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section10Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section11Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section12Id = table.Column<Guid>(type: "uuid", nullable: true),
                    Section13Id = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonLinearProjectDocumentContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_OtherDocumentsSection_Secti~",
                        column: x => x.Section13Id,
                        principalTable: "OtherDocumentsSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_ProjectDocumentSection_Sect~",
                        column: x => x.Section10Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_ProjectDocumentSection_Sec~1",
                        column: x => x.Section11Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_ProjectDocumentSection_Sec~2",
                        column: x => x.Section2Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_ProjectDocumentSection_Sec~3",
                        column: x => x.Section3Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_ProjectDocumentSection_Sec~4",
                        column: x => x.Section4Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_ProjectDocumentSection_Sec~5",
                        column: x => x.Section6Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_ProjectDocumentSection_Sec~6",
                        column: x => x.Section7Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_ProjectDocumentSection_Sec~7",
                        column: x => x.Section8Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_ProjectDocumentSection_Sec~8",
                        column: x => x.Section9Id,
                        principalTable: "ProjectDocumentSection",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_Section5_Section5Id",
                        column: x => x.Section5Id,
                        principalTable: "Section5",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_SectionEstimate_Section12Id",
                        column: x => x.Section12Id,
                        principalTable: "SectionEstimate",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonLinearProjectDocumentContent_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SignFile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    FileFormat = table.Column<string>(type: "text", nullable: true),
                    FileRelativePath = table.Column<string>(type: "text", nullable: true),
                    FileChecksum = table.Column<string>(type: "text", nullable: true),
                    FildeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModelFileId = table.Column<Guid>(type: "uuid", nullable: true),
                    FileId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SignFile_File_FileId",
                        column: x => x.FileId,
                        principalTable: "File",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignFile_ModelFile_ModelFileId",
                        column: x => x.ModelFileId,
                        principalTable: "ModelFile",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignFile_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SignFile_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: true),
                    RegionId = table.Column<Guid>(type: "uuid", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Settlement = table.Column<string>(type: "text", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true),
                    Building = table.Column<string>(type: "text", nullable: true),
                    Room = table.Column<string>(type: "text", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    ComplexPartId = table.Column<Guid>(type: "uuid", nullable: true),
                    OKSId = table.Column<Guid>(type: "uuid", nullable: true),
                    Discriminator = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PostIndex = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_RegionsRF_RegionId",
                        column: x => x.RegionId,
                        principalTable: "RegionsRF",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Address_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ForeignOrganization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrgFullName = table.Column<string>(type: "text", nullable: true),
                    OrgINN = table.Column<string>(type: "text", nullable: true),
                    OrgKPP = table.Column<string>(type: "text", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForeignOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ForeignOrganization_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForeignOrganization_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ForeignOrganization_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FamilyName = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    SecondName = table.Column<string>(type: "text", nullable: true),
                    OGRNIP = table.Column<string>(type: "text", nullable: true),
                    PostAddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IP_Address_PostAddressId",
                        column: x => x.PostAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IP_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IP_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrgFullName = table.Column<string>(type: "text", nullable: true),
                    OrgOGRN = table.Column<string>(type: "text", nullable: true),
                    OrgINN = table.Column<string>(type: "text", nullable: true),
                    OrgKPP = table.Column<string>(type: "text", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organization_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Organization_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Organization_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FamilyName = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    SecondName = table.Column<string>(type: "text", nullable: true),
                    SNILS = table.Column<string>(type: "text", nullable: true),
                    PostAddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Address_PostAddressId",
                        column: x => x.PostAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Person_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uuid", nullable: true),
                    ForeignOrganizationId = table.Column<Guid>(type: "uuid", nullable: true),
                    IPId = table.Column<Guid>(type: "uuid", nullable: true),
                    SROMembershipId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentationAuthorsId = table.Column<Guid>(type: "uuid", nullable: true),
                    EngineeringSurveyDocumentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_EngineeringSurveyDocument_EngineeringSurveyDocumentId",
                        column: x => x.EngineeringSurveyDocumentId,
                        principalTable: "EngineeringSurveyDocument",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Author_ForeignOrganization_ForeignOrganizationId",
                        column: x => x.ForeignOrganizationId,
                        principalTable: "ForeignOrganization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Author_IP_IPId",
                        column: x => x.IPId,
                        principalTable: "IP",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Author_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Author_ProjectDocumentationAuthors_ProjectDocumentationAuth~",
                        column: x => x.ProjectDocumentationAuthorsId,
                        principalTable: "ProjectDocumentationAuthors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Author_SROMembership_SROMembershipId",
                        column: x => x.SROMembershipId,
                        principalTable: "SROMembership",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Author_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Author_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClimateConditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClimateNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimateConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClimateConditions_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClimateConditions_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClimateConditionsClimateDistrict",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClimateConditionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClimateDistrictId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimateConditionsClimateDistrict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsClimateDistrict_ClimateConditions_ClimateC~",
                        column: x => x.ClimateConditionsId,
                        principalTable: "ClimateConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsClimateDistrict_ClimateDistrict_ClimateDis~",
                        column: x => x.ClimateDistrictId,
                        principalTable: "ClimateDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsClimateDistrict_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClimateConditionsClimateDistrict_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClimateConditionsGeologicalConditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClimateConditionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    GeologicalConditionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimateConditionsGeologicalConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsGeologicalConditions_ClimateConditions_Cli~",
                        column: x => x.ClimateConditionsId,
                        principalTable: "ClimateConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsGeologicalConditions_GeologicalConditions_~",
                        column: x => x.GeologicalConditionsId,
                        principalTable: "GeologicalConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsGeologicalConditions_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClimateConditionsGeologicalConditions_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClimateConditionsSeismicActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClimateConditionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SeismicActivityId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimateConditionsSeismicActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsSeismicActivity_ClimateConditions_ClimateC~",
                        column: x => x.ClimateConditionsId,
                        principalTable: "ClimateConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsSeismicActivity_SeismicActivity_SeismicAct~",
                        column: x => x.SeismicActivityId,
                        principalTable: "SeismicActivity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsSeismicActivity_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClimateConditionsSeismicActivity_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClimateConditionsSnowDistrict",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClimateConditionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    SnowDistrictId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimateConditionsSnowDistrict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsSnowDistrict_ClimateConditions_ClimateCond~",
                        column: x => x.ClimateConditionsId,
                        principalTable: "ClimateConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsSnowDistrict_SnowDistrict_SnowDistrictId",
                        column: x => x.SnowDistrictId,
                        principalTable: "SnowDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsSnowDistrict_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClimateConditionsSnowDistrict_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClimateConditionsWindDistrict",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClimateConditionsId = table.Column<Guid>(type: "uuid", nullable: false),
                    WindDistrictId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClimateConditionsWindDistrict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsWindDistrict_ClimateConditions_ClimateCond~",
                        column: x => x.ClimateConditionsId,
                        principalTable: "ClimateConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClimateConditionsWindDistrict_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClimateConditionsWindDistrict_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClimateConditionsWindDistrict_WindDistrict_WindDistrictId",
                        column: x => x.WindDistrictId,
                        principalTable: "WindDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComplexPart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ObjectID = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FunctionsClass = table.Column<string>(type: "text", nullable: true),
                    FunctionFeaturesId = table.Column<Guid>(type: "uuid", nullable: true),
                    DangerousIndustrialObject = table.Column<string>(type: "text", nullable: true),
                    ObjectPartsId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModelId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplexPart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplexPart_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComplexPart_ObjectParts_ObjectPartsId",
                        column: x => x.ObjectPartsId,
                        principalTable: "ObjectParts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComplexPart_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComplexPart_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Developer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uuid", nullable: true),
                    ForeignOrganizationId = table.Column<Guid>(type: "uuid", nullable: true),
                    IPId = table.Column<Guid>(type: "uuid", nullable: true),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExplanatoryNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Developer_ForeignOrganization_ForeignOrganizationId",
                        column: x => x.ForeignOrganizationId,
                        principalTable: "ForeignOrganization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Developer_IP_IPId",
                        column: x => x.IPId,
                        principalTable: "IP",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Developer_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Developer_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Developer_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Developer_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EnergyEfficiency",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EnergyEfficiencyClassId = table.Column<Guid>(type: "uuid", nullable: true),
                    EnergyEfficiencyImprovingId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyEfficiency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnergyEfficiency_EfficiencyClass_EnergyEfficiencyClassId",
                        column: x => x.EnergyEfficiencyClassId,
                        principalTable: "EfficiencyClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EnergyEfficiency_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EnergyEfficiency_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExplanatoryNote",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SchemaVersion = table.Column<string>(type: "text", nullable: false),
                    SchemaLink = table.Column<string>(type: "text", nullable: true),
                    AccessRestriction = table.Column<string>(type: "text", nullable: true),
                    ExplanatoryNoteNumber = table.Column<string>(type: "text", nullable: true),
                    ExplanatoryNoteYear = table.Column<int>(type: "integer", nullable: false),
                    ExplanatoryNoteModificationsId = table.Column<Guid>(type: "uuid", nullable: true),
                    IssueAuthorId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentationAuthorsId = table.Column<Guid>(type: "uuid", nullable: true),
                    SignersId = table.Column<Guid>(type: "uuid", nullable: true),
                    UsedAbbreviationsId = table.Column<Guid>(type: "uuid", nullable: true),
                    UsedNormsId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDecisionDocumentsId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectInitialDocumentsId = table.Column<Guid>(type: "uuid", nullable: true),
                    EngineeringSurveyDocumentsId = table.Column<Guid>(type: "uuid", nullable: true),
                    AdditionalDataId = table.Column<Guid>(type: "uuid", nullable: true),
                    FinanceSourcesId = table.Column<Guid>(type: "uuid", nullable: true),
                    NonIndustrialObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    IndustrialObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    LinearObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    DesignerAssuranceId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExplanatoryNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_AdditionalData_AdditionalDataId",
                        column: x => x.AdditionalDataId,
                        principalTable: "AdditionalData",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_Author_IssueAuthorId",
                        column: x => x.IssueAuthorId,
                        principalTable: "Author",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_Documents_ProjectDecisionDocumentsId",
                        column: x => x.ProjectDecisionDocumentsId,
                        principalTable: "Documents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_Documents_ProjectInitialDocumentsId",
                        column: x => x.ProjectInitialDocumentsId,
                        principalTable: "Documents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_EngineeringSurveyDocuments_EngineeringSurve~",
                        column: x => x.EngineeringSurveyDocumentsId,
                        principalTable: "EngineeringSurveyDocuments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_ExplanatoryNoteModifications_ExplanatoryNot~",
                        column: x => x.ExplanatoryNoteModificationsId,
                        principalTable: "ExplanatoryNoteModifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_FinanceSources_FinanceSourcesId",
                        column: x => x.FinanceSourcesId,
                        principalTable: "FinanceSources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_ProjectDocumentationAuthors_ProjectDocument~",
                        column: x => x.ProjectDocumentationAuthorsId,
                        principalTable: "ProjectDocumentationAuthors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_Signers_SignersId",
                        column: x => x.SignersId,
                        principalTable: "Signers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExplanatoryNote_UsedNorms_UsedNormsId",
                        column: x => x.UsedNormsId,
                        principalTable: "UsedNorms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TechnicalCustomer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrganizationId = table.Column<Guid>(type: "uuid", nullable: true),
                    ForeignOrganizationId = table.Column<Guid>(type: "uuid", nullable: true),
                    SROMembershipId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExplanatoryNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalCustomer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnicalCustomer_ExplanatoryNote_ExplanatoryNoteId",
                        column: x => x.ExplanatoryNoteId,
                        principalTable: "ExplanatoryNote",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TechnicalCustomer_ForeignOrganization_ForeignOrganizationId",
                        column: x => x.ForeignOrganizationId,
                        principalTable: "ForeignOrganization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TechnicalCustomer_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TechnicalCustomer_SROMembership_SROMembershipId",
                        column: x => x.SROMembershipId,
                        principalTable: "SROMembership",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TechnicalCustomer_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TechnicalCustomer_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TextBlock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Json = table.Column<string>(type: "text", nullable: false),
                    ExplanatoryNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextBlock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextBlock_ExplanatoryNote_ExplanatoryNoteId",
                        column: x => x.ExplanatoryNoteId,
                        principalTable: "ExplanatoryNote",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TextBlock_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TextBlock_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StateCustomerSource",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: true),
                    SourceRatio = table.Column<decimal>(type: "numeric", nullable: true),
                    FinanceSourcesId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateCustomerSource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StateCustomerSource_FinanceSources_FinanceSourcesId",
                        column: x => x.FinanceSourcesId,
                        principalTable: "FinanceSources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StateCustomerSource_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StateCustomerSource_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StateCustomerSource_TechnicalCustomer_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "TechnicalCustomer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Functions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FunctionsText = table.Column<string>(type: "text", nullable: true),
                    FunctionsClass = table.Column<string>(type: "text", nullable: true),
                    ProductsNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Functions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Functions_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Functions_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Functions_TextBlock_ProductsNoteId",
                        column: x => x.ProductsNoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GasNetworksFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StrengthCalculationId = table.Column<Guid>(type: "uuid", nullable: true),
                    EnvironmentalProtectionId = table.Column<Guid>(type: "uuid", nullable: true),
                    FireSafetyId = table.Column<Guid>(type: "uuid", nullable: true),
                    OperationalSafetyId = table.Column<Guid>(type: "uuid", nullable: true),
                    RepairFrequencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GasNetworksFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GasNetworksFeatures_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasNetworksFeatures_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasNetworksFeatures_TextBlock_EnvironmentalProtectionId",
                        column: x => x.EnvironmentalProtectionId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasNetworksFeatures_TextBlock_FireSafetyId",
                        column: x => x.FireSafetyId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasNetworksFeatures_TextBlock_OperationalSafetyId",
                        column: x => x.OperationalSafetyId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasNetworksFeatures_TextBlock_RepairFrequencyId",
                        column: x => x.RepairFrequencyId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GasNetworksFeatures_TextBlock_StrengthCalculationId",
                        column: x => x.StrengthCalculationId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LandInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CommonLandInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandInfo_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LandInfo_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LandInfo_TextBlock_CommonLandInfoId",
                        column: x => x.CommonLandInfoId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MonitoringPrograms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GeotechnicalMonitoringId = table.Column<Guid>(type: "uuid", nullable: true),
                    HydrogeologicalMonitoringId = table.Column<Guid>(type: "uuid", nullable: true),
                    SeismologicalMonitoringId = table.Column<Guid>(type: "uuid", nullable: true),
                    MeteorologicalMonitoringId = table.Column<Guid>(type: "uuid", nullable: true),
                    AerologicalMonitoringId = table.Column<Guid>(type: "uuid", nullable: true),
                    HydrologicalMonitoringId = table.Column<Guid>(type: "uuid", nullable: true),
                    GeodynamicalMonitoringId = table.Column<Guid>(type: "uuid", nullable: true),
                    TechnogenicMonitoringId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitoringPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_TextBlock_AerologicalMonitoringId",
                        column: x => x.AerologicalMonitoringId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_TextBlock_GeodynamicalMonitoringId",
                        column: x => x.GeodynamicalMonitoringId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_TextBlock_GeotechnicalMonitoringId",
                        column: x => x.GeotechnicalMonitoringId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_TextBlock_HydrogeologicalMonitoringId",
                        column: x => x.HydrogeologicalMonitoringId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_TextBlock_HydrologicalMonitoringId",
                        column: x => x.HydrologicalMonitoringId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_TextBlock_MeteorologicalMonitoringId",
                        column: x => x.MeteorologicalMonitoringId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_TextBlock_SeismologicalMonitoringId",
                        column: x => x.SeismologicalMonitoringId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MonitoringPrograms_TextBlock_TechnogenicMonitoringId",
                        column: x => x.TechnogenicMonitoringId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OKS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ObjectID = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FunctionsClass = table.Column<string>(type: "text", nullable: true),
                    FunctionsFeaturesId = table.Column<Guid>(type: "uuid", nullable: true),
                    EnergyEfficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    DangerousIndustrialObjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    FireDangerCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    PeoplePermanentStayId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResponsibilityLevelId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModelId = table.Column<Guid>(type: "uuid", nullable: true),
                    ObjectPartsId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OKS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OKS_DangerIndustrialClass_DangerousIndustrialObjectId",
                        column: x => x.DangerousIndustrialObjectId,
                        principalTable: "DangerIndustrialClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OKS_EnergyEfficiency_EnergyEfficiencyId",
                        column: x => x.EnergyEfficiencyId,
                        principalTable: "EnergyEfficiency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OKS_FireDangerCategory_FireDangerCategoryId",
                        column: x => x.FireDangerCategoryId,
                        principalTable: "FireDangerCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OKS_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OKS_ObjectParts_ObjectPartsId",
                        column: x => x.ObjectPartsId,
                        principalTable: "ObjectParts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OKS_ResponsibilityLevel_ResponsibilityLevelId",
                        column: x => x.ResponsibilityLevelId,
                        principalTable: "ResponsibilityLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OKS_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OKS_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OKS_TextBlock_FunctionsFeaturesId",
                        column: x => x.FunctionsFeaturesId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OKS_TextBlock_PeoplePermanentStayId",
                        column: x => x.PeoplePermanentStayId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resources_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Resources_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Resources_TextBlock_NoteId",
                        column: x => x.NoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoutesNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Routes_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Routes_TextBlock_RoutesNoteId",
                        column: x => x.RoutesNoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SoftwareUsed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SoftwareNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareUsed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoftwareUsed_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SoftwareUsed_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SoftwareUsed_TextBlock_SoftwareNoteId",
                        column: x => x.SoftwareNoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StagesInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReasonNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StagesInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StagesInfo_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StagesInfo_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StagesInfo_TextBlock_ReasonNoteId",
                        column: x => x.ReasonNoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LandAreaInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CadastralNumber = table.Column<string>(type: "text", nullable: true),
                    LandCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    UsingNote = table.Column<string>(type: "text", nullable: true),
                    LandInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandAreaInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandAreaInfo_LandCategory_LandCategoryId",
                        column: x => x.LandCategoryId,
                        principalTable: "LandCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LandAreaInfo_LandInfo_LandInfoId",
                        column: x => x.LandInfoId,
                        principalTable: "LandInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LandAreaInfo_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LandAreaInfo_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NuclearPlantFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ObjectListId = table.Column<Guid>(type: "uuid", nullable: true),
                    NuclearSafetyId = table.Column<Guid>(type: "uuid", nullable: true),
                    OperationalLimitsId = table.Column<Guid>(type: "uuid", nullable: true),
                    NuclearPlantControlId = table.Column<Guid>(type: "uuid", nullable: true),
                    ReactorPlantId = table.Column<Guid>(type: "uuid", nullable: true),
                    NuclearSafitySoftwareId = table.Column<Guid>(type: "uuid", nullable: true),
                    MonitoringProgramsId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NuclearPlantFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NuclearPlantFeatures_MonitoringPrograms_MonitoringProgramsId",
                        column: x => x.MonitoringProgramsId,
                        principalTable: "MonitoringPrograms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NuclearPlantFeatures_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NuclearPlantFeatures_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NuclearPlantFeatures_TextBlock_NuclearPlantControlId",
                        column: x => x.NuclearPlantControlId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NuclearPlantFeatures_TextBlock_NuclearSafetyId",
                        column: x => x.NuclearSafetyId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NuclearPlantFeatures_TextBlock_NuclearSafitySoftwareId",
                        column: x => x.NuclearSafitySoftwareId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NuclearPlantFeatures_TextBlock_ObjectListId",
                        column: x => x.ObjectListId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NuclearPlantFeatures_TextBlock_OperationalLimitsId",
                        column: x => x.OperationalLimitsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NuclearPlantFeatures_TextBlock_ReactorPlantId",
                        column: x => x.ReactorPlantId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    MeasureId = table.Column<Guid>(type: "uuid", nullable: true),
                    Volume = table.Column<string>(type: "text", nullable: true),
                    ResourcesId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resource_OKEI_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "OKEI",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Resource_Resources_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "Resources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Resource_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Resource_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    RoutesId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Route_Routes_RoutesId",
                        column: x => x.RoutesId,
                        principalTable: "Routes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Route_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Route_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Route_TextBlock_NoteId",
                        column: x => x.NoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Version = table.Column<string>(type: "text", nullable: true),
                    UsingNote = table.Column<string>(type: "text", nullable: true),
                    SoftwareUsedId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Software_SoftwareUsed_SoftwareUsedId",
                        column: x => x.SoftwareUsedId,
                        principalTable: "SoftwareUsed",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Software_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Software_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LinearObject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ObjectID = table.Column<string>(type: "text", nullable: true),
                    PlacementId = table.Column<Guid>(type: "uuid", nullable: true),
                    DangerousAndComplexId = table.Column<Guid>(type: "uuid", nullable: true),
                    UniqueId = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ConstractionTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ConstructionDuration = table.Column<decimal>(type: "numeric", nullable: true),
                    ConstractionDatesId = table.Column<Guid>(type: "uuid", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    FinishAddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    FunctionsId = table.Column<Guid>(type: "uuid", nullable: true),
                    FunctionsFeaturesId = table.Column<Guid>(type: "uuid", nullable: true),
                    DangerIndustrialClassId = table.Column<Guid>(type: "uuid", nullable: true),
                    LinearObjectCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    LinearObjectClassId = table.Column<Guid>(type: "uuid", nullable: true),
                    LinearObjectNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    FireDangerCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    PeoplePermanentStayId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResponsibilityLevelId = table.Column<Guid>(type: "uuid", nullable: true),
                    ObjectPartsId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClimateConditionsId = table.Column<Guid>(type: "uuid", nullable: true),
                    RoutesId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResourcesId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResourceUseInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    RenewableSourceInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandFundsId = table.Column<Guid>(type: "uuid", nullable: true),
                    PatentsUsedId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpecialRequirementsId = table.Column<Guid>(type: "uuid", nullable: true),
                    StaffNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    SoftwareUsedId = table.Column<Guid>(type: "uuid", nullable: true),
                    StagesInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    DestroyFundsId = table.Column<Guid>(type: "uuid", nullable: true),
                    UndustrialSafetyLinksId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandReclamationLinkId = table.Column<Guid>(type: "uuid", nullable: true),
                    GasNetworksFeaturesId = table.Column<Guid>(type: "uuid", nullable: true),
                    EngineeringTerritoryProtectionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentationId = table.Column<Guid>(type: "uuid", nullable: true),
                    GasProjectDocumentationId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModelId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinearObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LinearObject_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_Address_FinishAddressId",
                        column: x => x.FinishAddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_ClimateConditions_ClimateConditionsId",
                        column: x => x.ClimateConditionsId,
                        principalTable: "ClimateConditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_ConstractionType_ConstractionTypeId",
                        column: x => x.ConstractionTypeId,
                        principalTable: "ConstractionType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_ConstructionDates_ConstractionDatesId",
                        column: x => x.ConstractionDatesId,
                        principalTable: "ConstructionDates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_DangerIndustrialClass_DangerIndustrialClassId",
                        column: x => x.DangerIndustrialClassId,
                        principalTable: "DangerIndustrialClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_DangerousAndComplex_DangerousAndComplexId",
                        column: x => x.DangerousAndComplexId,
                        principalTable: "DangerousAndComplex",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_FireDangerCategory_FireDangerCategoryId",
                        column: x => x.FireDangerCategoryId,
                        principalTable: "FireDangerCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_Functions_FunctionsId",
                        column: x => x.FunctionsId,
                        principalTable: "Functions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_GasLinearProjectDocumentContent_GasProjectDocu~",
                        column: x => x.GasProjectDocumentationId,
                        principalTable: "GasLinearProjectDocumentContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_GasNetworksFeatures_GasNetworksFeaturesId",
                        column: x => x.GasNetworksFeaturesId,
                        principalTable: "GasNetworksFeatures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_LandInfo_LandInfoId",
                        column: x => x.LandInfoId,
                        principalTable: "LandInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_LinearProjectDocumentContent_ProjectDocumentat~",
                        column: x => x.ProjectDocumentationId,
                        principalTable: "LinearProjectDocumentContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_ObjectParts_ObjectPartsId",
                        column: x => x.ObjectPartsId,
                        principalTable: "ObjectParts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_Placement_PlacementId",
                        column: x => x.PlacementId,
                        principalTable: "Placement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_ProjectDocumentationLinks_UndustrialSafetyLink~",
                        column: x => x.UndustrialSafetyLinksId,
                        principalTable: "ProjectDocumentationLinks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_Resources_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "Resources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_ResponsibilityLevel_ResponsibilityLevelId",
                        column: x => x.ResponsibilityLevelId,
                        principalTable: "ResponsibilityLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_Routes_RoutesId",
                        column: x => x.RoutesId,
                        principalTable: "Routes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_SoftwareUsed_SoftwareUsedId",
                        column: x => x.SoftwareUsedId,
                        principalTable: "SoftwareUsed",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_StagesInfo_StagesInfoId",
                        column: x => x.StagesInfoId,
                        principalTable: "StagesInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_DestroyFundsId",
                        column: x => x.DestroyFundsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_EngineeringTerritoryProtectionId",
                        column: x => x.EngineeringTerritoryProtectionId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_FunctionsFeaturesId",
                        column: x => x.FunctionsFeaturesId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_LandFundsId",
                        column: x => x.LandFundsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_LandReclamationLinkId",
                        column: x => x.LandReclamationLinkId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_LinearObjectCategoryId",
                        column: x => x.LinearObjectCategoryId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_LinearObjectClassId",
                        column: x => x.LinearObjectClassId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_LinearObjectNoteId",
                        column: x => x.LinearObjectNoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_PatentsUsedId",
                        column: x => x.PatentsUsedId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_PeoplePermanentStayId",
                        column: x => x.PeoplePermanentStayId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_RenewableSourceInfoId",
                        column: x => x.RenewableSourceInfoId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_ResourceUseInfoId",
                        column: x => x.ResourceUseInfoId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_SpecialRequirementsId",
                        column: x => x.SpecialRequirementsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_TextBlock_StaffNoteId",
                        column: x => x.StaffNoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LinearObject_Unique_UniqueId",
                        column: x => x.UniqueId,
                        principalTable: "Unique",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NonIndustrialObject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ObjectID = table.Column<string>(type: "text", nullable: true),
                    PlacementId = table.Column<Guid>(type: "uuid", nullable: true),
                    DangerousAndComplexId = table.Column<Guid>(type: "uuid", nullable: true),
                    UniqueId = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ConstructionTypeCode = table.Column<string>(type: "text", nullable: true),
                    ConstractionTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ConstructionDuration = table.Column<decimal>(type: "numeric", nullable: true),
                    ConstractionDatesId = table.Column<Guid>(type: "uuid", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    FunctionsId = table.Column<Guid>(type: "uuid", nullable: true),
                    FunctionsFeaturesId = table.Column<Guid>(type: "uuid", nullable: true),
                    EnergyEfficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    FireDangerCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    PeoplePermanentStayId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResponsibilityLevelId = table.Column<Guid>(type: "uuid", nullable: true),
                    ObjectPartsId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClimateConditionsId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResourcesId = table.Column<Guid>(type: "uuid", nullable: true),
                    RenewableSourceInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandFundsId = table.Column<Guid>(type: "uuid", nullable: true),
                    PatentsUsedId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpecialRequirementsId = table.Column<Guid>(type: "uuid", nullable: true),
                    StaffNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    SoftwareUsedId = table.Column<Guid>(type: "uuid", nullable: true),
                    StagesInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    DestroyFundsId = table.Column<Guid>(type: "uuid", nullable: true),
                    EnergyEfficiencyLinksId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandReclamationLinkId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentationId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModelId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonIndustrialObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_ClimateConditions_ClimateConditionsId",
                        column: x => x.ClimateConditionsId,
                        principalTable: "ClimateConditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_ConstractionType_ConstractionTypeId",
                        column: x => x.ConstractionTypeId,
                        principalTable: "ConstractionType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_ConstructionDates_ConstractionDatesId",
                        column: x => x.ConstractionDatesId,
                        principalTable: "ConstructionDates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_DangerousAndComplex_DangerousAndComplex~",
                        column: x => x.DangerousAndComplexId,
                        principalTable: "DangerousAndComplex",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_EnergyEfficiency_EnergyEfficiencyId",
                        column: x => x.EnergyEfficiencyId,
                        principalTable: "EnergyEfficiency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_FireDangerCategory_FireDangerCategoryId",
                        column: x => x.FireDangerCategoryId,
                        principalTable: "FireDangerCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_Functions_FunctionsId",
                        column: x => x.FunctionsId,
                        principalTable: "Functions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_LandInfo_LandInfoId",
                        column: x => x.LandInfoId,
                        principalTable: "LandInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_NonLinearProjectDocumentContent_Project~",
                        column: x => x.ProjectDocumentationId,
                        principalTable: "NonLinearProjectDocumentContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_ObjectParts_ObjectPartsId",
                        column: x => x.ObjectPartsId,
                        principalTable: "ObjectParts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_Placement_PlacementId",
                        column: x => x.PlacementId,
                        principalTable: "Placement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_ProjectDocumentationLinks_EnergyEfficie~",
                        column: x => x.EnergyEfficiencyLinksId,
                        principalTable: "ProjectDocumentationLinks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_Resources_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "Resources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_ResponsibilityLevel_ResponsibilityLevel~",
                        column: x => x.ResponsibilityLevelId,
                        principalTable: "ResponsibilityLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_SoftwareUsed_SoftwareUsedId",
                        column: x => x.SoftwareUsedId,
                        principalTable: "SoftwareUsed",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_StagesInfo_StagesInfoId",
                        column: x => x.StagesInfoId,
                        principalTable: "StagesInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_TextBlock_DestroyFundsId",
                        column: x => x.DestroyFundsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_TextBlock_FunctionsFeaturesId",
                        column: x => x.FunctionsFeaturesId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_TextBlock_LandFundsId",
                        column: x => x.LandFundsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_TextBlock_LandReclamationLinkId",
                        column: x => x.LandReclamationLinkId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_TextBlock_PatentsUsedId",
                        column: x => x.PatentsUsedId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_TextBlock_PeoplePermanentStayId",
                        column: x => x.PeoplePermanentStayId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_TextBlock_RenewableSourceInfoId",
                        column: x => x.RenewableSourceInfoId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_TextBlock_SpecialRequirementsId",
                        column: x => x.SpecialRequirementsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_TextBlock_StaffNoteId",
                        column: x => x.StaffNoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NonIndustrialObject_Unique_UniqueId",
                        column: x => x.UniqueId,
                        principalTable: "Unique",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: true),
                    ConstructionDuration = table.Column<decimal>(type: "numeric", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OperationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    StagesInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stage_StagesInfo_StagesInfoId",
                        column: x => x.StagesInfoId,
                        principalTable: "StagesInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stage_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stage_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stage_TextBlock_NoteId",
                        column: x => x.NoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IndustrialObject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ObjectID = table.Column<string>(type: "text", nullable: true),
                    PlacementId = table.Column<Guid>(type: "uuid", nullable: true),
                    DangerousAndComplexId = table.Column<Guid>(type: "uuid", nullable: true),
                    UniqueId = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ConstractionTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    ConstructionDuration = table.Column<decimal>(type: "numeric", nullable: true),
                    ConstractionDatesId = table.Column<Guid>(type: "uuid", nullable: true),
                    AddressId = table.Column<Guid>(type: "uuid", nullable: true),
                    FunctionsId = table.Column<Guid>(type: "uuid", nullable: true),
                    FunctionsFeaturesId = table.Column<Guid>(type: "uuid", nullable: true),
                    EnergyEfficiencyId = table.Column<Guid>(type: "uuid", nullable: true),
                    DangerIndustrialClassId = table.Column<Guid>(type: "uuid", nullable: true),
                    FireDangerCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    PeoplePermanentStayId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResponsibilityLevelId = table.Column<Guid>(type: "uuid", nullable: true),
                    ObjectPartsId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClimateConditionsId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResourcesId = table.Column<Guid>(type: "uuid", nullable: true),
                    RawResourcesId = table.Column<Guid>(type: "uuid", nullable: true),
                    ResourceUseInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    RenewableSourceInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandFundsId = table.Column<Guid>(type: "uuid", nullable: true),
                    PatentsUsedId = table.Column<Guid>(type: "uuid", nullable: true),
                    SpecialRequirementsId = table.Column<Guid>(type: "uuid", nullable: true),
                    StaffNoteId = table.Column<Guid>(type: "uuid", nullable: true),
                    SoftwareUsedId = table.Column<Guid>(type: "uuid", nullable: true),
                    StagesInfoId = table.Column<Guid>(type: "uuid", nullable: true),
                    DestroyFundsId = table.Column<Guid>(type: "uuid", nullable: true),
                    EnergyEfficiencyLinksId = table.Column<Guid>(type: "uuid", nullable: true),
                    UndustrialSafetyLinksId = table.Column<Guid>(type: "uuid", nullable: true),
                    LandReclamationLinkId = table.Column<Guid>(type: "uuid", nullable: true),
                    NuclearPlantFeaturesId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProjectDocumentationId = table.Column<Guid>(type: "uuid", nullable: true),
                    ModelId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustrialObject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustrialObject_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_ClimateConditions_ClimateConditionsId",
                        column: x => x.ClimateConditionsId,
                        principalTable: "ClimateConditions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_ConstractionType_ConstractionTypeId",
                        column: x => x.ConstractionTypeId,
                        principalTable: "ConstractionType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_ConstructionDates_ConstractionDatesId",
                        column: x => x.ConstractionDatesId,
                        principalTable: "ConstructionDates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_DangerIndustrialClass_DangerIndustrialClas~",
                        column: x => x.DangerIndustrialClassId,
                        principalTable: "DangerIndustrialClass",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_DangerousAndComplex_DangerousAndComplexId",
                        column: x => x.DangerousAndComplexId,
                        principalTable: "DangerousAndComplex",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_EnergyEfficiency_EnergyEfficiencyId",
                        column: x => x.EnergyEfficiencyId,
                        principalTable: "EnergyEfficiency",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_FireDangerCategory_FireDangerCategoryId",
                        column: x => x.FireDangerCategoryId,
                        principalTable: "FireDangerCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_Functions_FunctionsId",
                        column: x => x.FunctionsId,
                        principalTable: "Functions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_LandInfo_LandInfoId",
                        column: x => x.LandInfoId,
                        principalTable: "LandInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_NonLinearProjectDocumentContent_ProjectDoc~",
                        column: x => x.ProjectDocumentationId,
                        principalTable: "NonLinearProjectDocumentContent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_NuclearPlantFeatures_NuclearPlantFeaturesId",
                        column: x => x.NuclearPlantFeaturesId,
                        principalTable: "NuclearPlantFeatures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_ObjectParts_ObjectPartsId",
                        column: x => x.ObjectPartsId,
                        principalTable: "ObjectParts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_Placement_PlacementId",
                        column: x => x.PlacementId,
                        principalTable: "Placement",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_ProjectDocumentationLinks_EnergyEfficiency~",
                        column: x => x.EnergyEfficiencyLinksId,
                        principalTable: "ProjectDocumentationLinks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_ProjectDocumentationLinks_UndustrialSafety~",
                        column: x => x.UndustrialSafetyLinksId,
                        principalTable: "ProjectDocumentationLinks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_Resources_RawResourcesId",
                        column: x => x.RawResourcesId,
                        principalTable: "Resources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_Resources_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "Resources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_ResponsibilityLevel_ResponsibilityLevelId",
                        column: x => x.ResponsibilityLevelId,
                        principalTable: "ResponsibilityLevel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_SoftwareUsed_SoftwareUsedId",
                        column: x => x.SoftwareUsedId,
                        principalTable: "SoftwareUsed",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_StagesInfo_StagesInfoId",
                        column: x => x.StagesInfoId,
                        principalTable: "StagesInfo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_DestroyFundsId",
                        column: x => x.DestroyFundsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_FunctionsFeaturesId",
                        column: x => x.FunctionsFeaturesId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_LandFundsId",
                        column: x => x.LandFundsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_LandReclamationLinkId",
                        column: x => x.LandReclamationLinkId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_PatentsUsedId",
                        column: x => x.PatentsUsedId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_PeoplePermanentStayId",
                        column: x => x.PeoplePermanentStayId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_RenewableSourceInfoId",
                        column: x => x.RenewableSourceInfoId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_ResourceUseInfoId",
                        column: x => x.ResourceUseInfoId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_SpecialRequirementsId",
                        column: x => x.SpecialRequirementsId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_TextBlock_StaffNoteId",
                        column: x => x.StaffNoteId,
                        principalTable: "TextBlock",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IndustrialObject_Unique_UniqueId",
                        column: x => x.UniqueId,
                        principalTable: "Unique",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LandCategoryMappings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LandCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    NonIndustrialObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    IndustrialObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    LinearObjectId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandCategoryMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandCategoryMappings_IndustrialObject_IndustrialObjectId",
                        column: x => x.IndustrialObjectId,
                        principalTable: "IndustrialObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LandCategoryMappings_LandCategory_LandCategoryId",
                        column: x => x.LandCategoryId,
                        principalTable: "LandCategory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LandCategoryMappings_LinearObject_LinearObjectId",
                        column: x => x.LinearObjectId,
                        principalTable: "LinearObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LandCategoryMappings_NonIndustrialObject_NonIndustrialObjec~",
                        column: x => x.NonIndustrialObjectId,
                        principalTable: "NonIndustrialObject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TEI",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    OKEIId = table.Column<Guid>(type: "uuid", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    OldValue = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    NonIndustialObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    IndustialObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    LinearObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    ComplexPartId = table.Column<Guid>(type: "uuid", nullable: true),
                    IndustrialObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    NonIndustrialObjectId = table.Column<Guid>(type: "uuid", nullable: true),
                    OKSId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEI", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TEI_ComplexPart_ComplexPartId",
                        column: x => x.ComplexPartId,
                        principalTable: "ComplexPart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TEI_IndustrialObject_IndustrialObjectId",
                        column: x => x.IndustrialObjectId,
                        principalTable: "IndustrialObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TEI_LinearObject_LinearObjectId",
                        column: x => x.LinearObjectId,
                        principalTable: "LinearObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TEI_NonIndustrialObject_NonIndustrialObjectId",
                        column: x => x.NonIndustrialObjectId,
                        principalTable: "NonIndustrialObject",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TEI_OKEI_OKEIId",
                        column: x => x.OKEIId,
                        principalTable: "OKEI",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TEI_OKS_OKSId",
                        column: x => x.OKSId,
                        principalTable: "OKS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TEI_SysUser_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TEI_SysUser_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "SysUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalData_CreatedById",
                table: "AdditionalData",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalData_UpdatedById",
                table: "AdditionalData",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Address_ComplexPartId",
                table: "Address",
                column: "ComplexPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedById",
                table: "Address",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Address_OKSId",
                table: "Address",
                column: "OKSId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_RegionId",
                table: "Address",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UpdatedById",
                table: "Address",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Author_CreatedById",
                table: "Author",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Author_EngineeringSurveyDocumentId",
                table: "Author",
                column: "EngineeringSurveyDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_ForeignOrganizationId",
                table: "Author",
                column: "ForeignOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_IPId",
                table: "Author",
                column: "IPId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_OrganizationId",
                table: "Author",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_ProjectDocumentationAuthorsId",
                table: "Author",
                column: "ProjectDocumentationAuthorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_SROMembershipId",
                table: "Author",
                column: "SROMembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_UpdatedById",
                table: "Author",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetSource_BudgetLevelId",
                table: "BudgetSource",
                column: "BudgetLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetSource_CreatedById",
                table: "BudgetSource",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetSource_FinanceSourcesId",
                table: "BudgetSource",
                column: "FinanceSourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetSource_UpdatedById",
                table: "BudgetSource",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ChiefProjectEngineer_CreatedById",
                table: "ChiefProjectEngineer",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ChiefProjectEngineer_UpdatedById",
                table: "ChiefProjectEngineer",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditions_ClimateNoteId",
                table: "ClimateConditions",
                column: "ClimateNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditions_CreatedById",
                table: "ClimateConditions",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditions_UpdatedById",
                table: "ClimateConditions",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsClimateDistrict_ClimateConditionsId",
                table: "ClimateConditionsClimateDistrict",
                column: "ClimateConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsClimateDistrict_ClimateDistrictId",
                table: "ClimateConditionsClimateDistrict",
                column: "ClimateDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsClimateDistrict_CreatedById",
                table: "ClimateConditionsClimateDistrict",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsClimateDistrict_UpdatedById",
                table: "ClimateConditionsClimateDistrict",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsGeologicalConditions_ClimateConditionsId",
                table: "ClimateConditionsGeologicalConditions",
                column: "ClimateConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsGeologicalConditions_CreatedById",
                table: "ClimateConditionsGeologicalConditions",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsGeologicalConditions_GeologicalConditionsId",
                table: "ClimateConditionsGeologicalConditions",
                column: "GeologicalConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsGeologicalConditions_UpdatedById",
                table: "ClimateConditionsGeologicalConditions",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsSeismicActivity_ClimateConditionsId",
                table: "ClimateConditionsSeismicActivity",
                column: "ClimateConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsSeismicActivity_CreatedById",
                table: "ClimateConditionsSeismicActivity",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsSeismicActivity_SeismicActivityId",
                table: "ClimateConditionsSeismicActivity",
                column: "SeismicActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsSeismicActivity_UpdatedById",
                table: "ClimateConditionsSeismicActivity",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsSnowDistrict_ClimateConditionsId",
                table: "ClimateConditionsSnowDistrict",
                column: "ClimateConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsSnowDistrict_CreatedById",
                table: "ClimateConditionsSnowDistrict",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsSnowDistrict_SnowDistrictId",
                table: "ClimateConditionsSnowDistrict",
                column: "SnowDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsSnowDistrict_UpdatedById",
                table: "ClimateConditionsSnowDistrict",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsWindDistrict_ClimateConditionsId",
                table: "ClimateConditionsWindDistrict",
                column: "ClimateConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsWindDistrict_CreatedById",
                table: "ClimateConditionsWindDistrict",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsWindDistrict_UpdatedById",
                table: "ClimateConditionsWindDistrict",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ClimateConditionsWindDistrict_WindDistrictId",
                table: "ClimateConditionsWindDistrict",
                column: "WindDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplexPart_CreatedById",
                table: "ComplexPart",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ComplexPart_FunctionFeaturesId",
                table: "ComplexPart",
                column: "FunctionFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplexPart_ModelId",
                table: "ComplexPart",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplexPart_ObjectPartsId",
                table: "ComplexPart",
                column: "ObjectPartsId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplexPart_UpdatedById",
                table: "ComplexPart",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructionDates_CreatedById",
                table: "ConstructionDates",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ConstructionDates_UpdatedById",
                table: "ConstructionDates",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Data_AdditionalDataId",
                table: "Data",
                column: "AdditionalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Data_CreatedById",
                table: "Data",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Data_UpdatedById",
                table: "Data",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Developer_CreatedById",
                table: "Developer",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Developer_ExplanatoryNoteId",
                table: "Developer",
                column: "ExplanatoryNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Developer_ForeignOrganizationId",
                table: "Developer",
                column: "ForeignOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Developer_IPId",
                table: "Developer",
                column: "IPId");

            migrationBuilder.CreateIndex(
                name: "IX_Developer_OrganizationId",
                table: "Developer",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Developer_PersonId",
                table: "Developer",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Developer_UpdatedById",
                table: "Developer",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Document_CreatedById",
                table: "Document",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentsId",
                table: "Document",
                column: "DocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentTypeId",
                table: "Document",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_ProjectDocumentNotNecessarySectionContentId",
                table: "Document",
                column: "ProjectDocumentNotNecessarySectionContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_UpdatedById",
                table: "Document",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_CreatedById",
                table: "Documents",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UpdatedById",
                table: "Documents",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyEfficiency_CreatedById",
                table: "EnergyEfficiency",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyEfficiency_EnergyEfficiencyClassId",
                table: "EnergyEfficiency",
                column: "EnergyEfficiencyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyEfficiency_EnergyEfficiencyImprovingId",
                table: "EnergyEfficiency",
                column: "EnergyEfficiencyImprovingId");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyEfficiency_UpdatedById",
                table: "EnergyEfficiency",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EngineeringSurveyDocument_CreatedById",
                table: "EngineeringSurveyDocument",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EngineeringSurveyDocument_DocumentTypeId",
                table: "EngineeringSurveyDocument",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineeringSurveyDocument_EngineeringSurveyDocumentsId",
                table: "EngineeringSurveyDocument",
                column: "EngineeringSurveyDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineeringSurveyDocument_UpdatedById",
                table: "EngineeringSurveyDocument",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EngineeringSurveyDocuments_CreatedById",
                table: "EngineeringSurveyDocuments",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EngineeringSurveyDocuments_UpdatedById",
                table: "EngineeringSurveyDocuments",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_AdditionalDataId",
                table: "ExplanatoryNote",
                column: "AdditionalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_CreatedById",
                table: "ExplanatoryNote",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_DesignerAssuranceId",
                table: "ExplanatoryNote",
                column: "DesignerAssuranceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_EngineeringSurveyDocumentsId",
                table: "ExplanatoryNote",
                column: "EngineeringSurveyDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_ExplanatoryNoteModificationsId",
                table: "ExplanatoryNote",
                column: "ExplanatoryNoteModificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_FinanceSourcesId",
                table: "ExplanatoryNote",
                column: "FinanceSourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_IndustrialObjectId",
                table: "ExplanatoryNote",
                column: "IndustrialObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_IssueAuthorId",
                table: "ExplanatoryNote",
                column: "IssueAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_LinearObjectId",
                table: "ExplanatoryNote",
                column: "LinearObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_NonIndustrialObjectId",
                table: "ExplanatoryNote",
                column: "NonIndustrialObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_ProjectDecisionDocumentsId",
                table: "ExplanatoryNote",
                column: "ProjectDecisionDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_ProjectDocumentationAuthorsId",
                table: "ExplanatoryNote",
                column: "ProjectDocumentationAuthorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_ProjectInitialDocumentsId",
                table: "ExplanatoryNote",
                column: "ProjectInitialDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_SignersId",
                table: "ExplanatoryNote",
                column: "SignersId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_UpdatedById",
                table: "ExplanatoryNote",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_UsedAbbreviationsId",
                table: "ExplanatoryNote",
                column: "UsedAbbreviationsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNote_UsedNormsId",
                table: "ExplanatoryNote",
                column: "UsedNormsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNoteModifications_CreatedById",
                table: "ExplanatoryNoteModifications",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryNoteModifications_UpdatedById",
                table: "ExplanatoryNoteModifications",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_File_CreatedById",
                table: "File",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_File_DataId",
                table: "File",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_File_DocumentId",
                table: "File",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_File_EngineeringSurveyDocumentId",
                table: "File",
                column: "EngineeringSurveyDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_File_ProjectDocumentId",
                table: "File",
                column: "ProjectDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_File_UpdatedById",
                table: "File",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceSources_CreatedById",
                table: "FinanceSources",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceSources_UpdatedById",
                table: "FinanceSources",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignOrganization_AddressId",
                table: "ForeignOrganization",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignOrganization_CreatedById",
                table: "ForeignOrganization",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignOrganization_UpdatedById",
                table: "ForeignOrganization",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Functions_CreatedById",
                table: "Functions",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Functions_ProductsNoteId",
                table: "Functions",
                column: "ProductsNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Functions_UpdatedById",
                table: "Functions",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_GasLinearProjectDocumentContent_CreatedById",
                table: "GasLinearProjectDocumentContent",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_GasLinearProjectDocumentContent_Section2Id",
                table: "GasLinearProjectDocumentContent",
                column: "Section2Id");

            migrationBuilder.CreateIndex(
                name: "IX_GasLinearProjectDocumentContent_Section3Id",
                table: "GasLinearProjectDocumentContent",
                column: "Section3Id");

            migrationBuilder.CreateIndex(
                name: "IX_GasLinearProjectDocumentContent_Section4Id",
                table: "GasLinearProjectDocumentContent",
                column: "Section4Id");

            migrationBuilder.CreateIndex(
                name: "IX_GasLinearProjectDocumentContent_Section5Id",
                table: "GasLinearProjectDocumentContent",
                column: "Section5Id");

            migrationBuilder.CreateIndex(
                name: "IX_GasLinearProjectDocumentContent_Section6Id",
                table: "GasLinearProjectDocumentContent",
                column: "Section6Id");

            migrationBuilder.CreateIndex(
                name: "IX_GasLinearProjectDocumentContent_Section7Id",
                table: "GasLinearProjectDocumentContent",
                column: "Section7Id");

            migrationBuilder.CreateIndex(
                name: "IX_GasLinearProjectDocumentContent_UpdatedById",
                table: "GasLinearProjectDocumentContent",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_GasNetworksFeatures_CreatedById",
                table: "GasNetworksFeatures",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_GasNetworksFeatures_EnvironmentalProtectionId",
                table: "GasNetworksFeatures",
                column: "EnvironmentalProtectionId");

            migrationBuilder.CreateIndex(
                name: "IX_GasNetworksFeatures_FireSafetyId",
                table: "GasNetworksFeatures",
                column: "FireSafetyId");

            migrationBuilder.CreateIndex(
                name: "IX_GasNetworksFeatures_OperationalSafetyId",
                table: "GasNetworksFeatures",
                column: "OperationalSafetyId");

            migrationBuilder.CreateIndex(
                name: "IX_GasNetworksFeatures_RepairFrequencyId",
                table: "GasNetworksFeatures",
                column: "RepairFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_GasNetworksFeatures_StrengthCalculationId",
                table: "GasNetworksFeatures",
                column: "StrengthCalculationId");

            migrationBuilder.CreateIndex(
                name: "IX_GasNetworksFeatures_UpdatedById",
                table: "GasNetworksFeatures",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_AddressId",
                table: "IndustrialObject",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_ClimateConditionsId",
                table: "IndustrialObject",
                column: "ClimateConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_ConstractionDatesId",
                table: "IndustrialObject",
                column: "ConstractionDatesId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_ConstractionTypeId",
                table: "IndustrialObject",
                column: "ConstractionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_CreatedById",
                table: "IndustrialObject",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_DangerIndustrialClassId",
                table: "IndustrialObject",
                column: "DangerIndustrialClassId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_DangerousAndComplexId",
                table: "IndustrialObject",
                column: "DangerousAndComplexId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_DestroyFundsId",
                table: "IndustrialObject",
                column: "DestroyFundsId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_EnergyEfficiencyId",
                table: "IndustrialObject",
                column: "EnergyEfficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_EnergyEfficiencyLinksId",
                table: "IndustrialObject",
                column: "EnergyEfficiencyLinksId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_FireDangerCategoryId",
                table: "IndustrialObject",
                column: "FireDangerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_FunctionsFeaturesId",
                table: "IndustrialObject",
                column: "FunctionsFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_FunctionsId",
                table: "IndustrialObject",
                column: "FunctionsId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_LandFundsId",
                table: "IndustrialObject",
                column: "LandFundsId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_LandInfoId",
                table: "IndustrialObject",
                column: "LandInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_LandReclamationLinkId",
                table: "IndustrialObject",
                column: "LandReclamationLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_ModelId",
                table: "IndustrialObject",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_NuclearPlantFeaturesId",
                table: "IndustrialObject",
                column: "NuclearPlantFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_ObjectPartsId",
                table: "IndustrialObject",
                column: "ObjectPartsId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_PatentsUsedId",
                table: "IndustrialObject",
                column: "PatentsUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_PeoplePermanentStayId",
                table: "IndustrialObject",
                column: "PeoplePermanentStayId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_PlacementId",
                table: "IndustrialObject",
                column: "PlacementId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_ProjectDocumentationId",
                table: "IndustrialObject",
                column: "ProjectDocumentationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_RawResourcesId",
                table: "IndustrialObject",
                column: "RawResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_RenewableSourceInfoId",
                table: "IndustrialObject",
                column: "RenewableSourceInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_ResourcesId",
                table: "IndustrialObject",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_ResourceUseInfoId",
                table: "IndustrialObject",
                column: "ResourceUseInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_ResponsibilityLevelId",
                table: "IndustrialObject",
                column: "ResponsibilityLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_SoftwareUsedId",
                table: "IndustrialObject",
                column: "SoftwareUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_SpecialRequirementsId",
                table: "IndustrialObject",
                column: "SpecialRequirementsId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_StaffNoteId",
                table: "IndustrialObject",
                column: "StaffNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_StagesInfoId",
                table: "IndustrialObject",
                column: "StagesInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_UndustrialSafetyLinksId",
                table: "IndustrialObject",
                column: "UndustrialSafetyLinksId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_UniqueId",
                table: "IndustrialObject",
                column: "UniqueId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialObject_UpdatedById",
                table: "IndustrialObject",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_IP_CreatedById",
                table: "IP",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_IP_PostAddressId",
                table: "IP",
                column: "PostAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_IP_UpdatedById",
                table: "IP",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LandAreaInfo_CreatedById",
                table: "LandAreaInfo",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LandAreaInfo_LandCategoryId",
                table: "LandAreaInfo",
                column: "LandCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LandAreaInfo_LandInfoId",
                table: "LandAreaInfo",
                column: "LandInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_LandAreaInfo_UpdatedById",
                table: "LandAreaInfo",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LandCategoryMappings_IndustrialObjectId",
                table: "LandCategoryMappings",
                column: "IndustrialObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_LandCategoryMappings_LandCategoryId",
                table: "LandCategoryMappings",
                column: "LandCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LandCategoryMappings_LinearObjectId",
                table: "LandCategoryMappings",
                column: "LinearObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_LandCategoryMappings_NonIndustrialObjectId",
                table: "LandCategoryMappings",
                column: "NonIndustrialObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_LandInfo_CommonLandInfoId",
                table: "LandInfo",
                column: "CommonLandInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_LandInfo_CreatedById",
                table: "LandInfo",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LandInfo_UpdatedById",
                table: "LandInfo",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_AddressId",
                table: "LinearObject",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_ClimateConditionsId",
                table: "LinearObject",
                column: "ClimateConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_ConstractionDatesId",
                table: "LinearObject",
                column: "ConstractionDatesId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_ConstractionTypeId",
                table: "LinearObject",
                column: "ConstractionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_CreatedById",
                table: "LinearObject",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_DangerIndustrialClassId",
                table: "LinearObject",
                column: "DangerIndustrialClassId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_DangerousAndComplexId",
                table: "LinearObject",
                column: "DangerousAndComplexId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_DestroyFundsId",
                table: "LinearObject",
                column: "DestroyFundsId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_EngineeringTerritoryProtectionId",
                table: "LinearObject",
                column: "EngineeringTerritoryProtectionId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_FinishAddressId",
                table: "LinearObject",
                column: "FinishAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_FireDangerCategoryId",
                table: "LinearObject",
                column: "FireDangerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_FunctionsFeaturesId",
                table: "LinearObject",
                column: "FunctionsFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_FunctionsId",
                table: "LinearObject",
                column: "FunctionsId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_GasNetworksFeaturesId",
                table: "LinearObject",
                column: "GasNetworksFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_GasProjectDocumentationId",
                table: "LinearObject",
                column: "GasProjectDocumentationId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_LandFundsId",
                table: "LinearObject",
                column: "LandFundsId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_LandInfoId",
                table: "LinearObject",
                column: "LandInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_LandReclamationLinkId",
                table: "LinearObject",
                column: "LandReclamationLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_LinearObjectCategoryId",
                table: "LinearObject",
                column: "LinearObjectCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_LinearObjectClassId",
                table: "LinearObject",
                column: "LinearObjectClassId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_LinearObjectNoteId",
                table: "LinearObject",
                column: "LinearObjectNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_ModelId",
                table: "LinearObject",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_ObjectPartsId",
                table: "LinearObject",
                column: "ObjectPartsId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_PatentsUsedId",
                table: "LinearObject",
                column: "PatentsUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_PeoplePermanentStayId",
                table: "LinearObject",
                column: "PeoplePermanentStayId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_PlacementId",
                table: "LinearObject",
                column: "PlacementId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_ProjectDocumentationId",
                table: "LinearObject",
                column: "ProjectDocumentationId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_RenewableSourceInfoId",
                table: "LinearObject",
                column: "RenewableSourceInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_ResourcesId",
                table: "LinearObject",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_ResourceUseInfoId",
                table: "LinearObject",
                column: "ResourceUseInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_ResponsibilityLevelId",
                table: "LinearObject",
                column: "ResponsibilityLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_RoutesId",
                table: "LinearObject",
                column: "RoutesId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_SoftwareUsedId",
                table: "LinearObject",
                column: "SoftwareUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_SpecialRequirementsId",
                table: "LinearObject",
                column: "SpecialRequirementsId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_StaffNoteId",
                table: "LinearObject",
                column: "StaffNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_StagesInfoId",
                table: "LinearObject",
                column: "StagesInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_UndustrialSafetyLinksId",
                table: "LinearObject",
                column: "UndustrialSafetyLinksId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_UniqueId",
                table: "LinearObject",
                column: "UniqueId");

            migrationBuilder.CreateIndex(
                name: "IX_LinearObject_UpdatedById",
                table: "LinearObject",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_CreatedById",
                table: "LinearProjectDocumentContent",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_Section10Id",
                table: "LinearProjectDocumentContent",
                column: "Section10Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_Section2Id",
                table: "LinearProjectDocumentContent",
                column: "Section2Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_Section3Id",
                table: "LinearProjectDocumentContent",
                column: "Section3Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_Section4Id",
                table: "LinearProjectDocumentContent",
                column: "Section4Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_Section5Id",
                table: "LinearProjectDocumentContent",
                column: "Section5Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_Section6Id",
                table: "LinearProjectDocumentContent",
                column: "Section6Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_Section7Id",
                table: "LinearProjectDocumentContent",
                column: "Section7Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_Section8Id",
                table: "LinearProjectDocumentContent",
                column: "Section8Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_Section9Id",
                table: "LinearProjectDocumentContent",
                column: "Section9Id");

            migrationBuilder.CreateIndex(
                name: "IX_LinearProjectDocumentContent_UpdatedById",
                table: "LinearProjectDocumentContent",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Model_CreatedById",
                table: "Model",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Model_UpdatedById",
                table: "Model",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ModelFile_CreatedById",
                table: "ModelFile",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ModelFile_ModelId",
                table: "ModelFile",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelFile_UpdatedById",
                table: "ModelFile",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Modification_CreatedById",
                table: "Modification",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Modification_ExplanatoryNoteModificationsId",
                table: "Modification",
                column: "ExplanatoryNoteModificationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Modification_UpdatedById",
                table: "Modification",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_AerologicalMonitoringId",
                table: "MonitoringPrograms",
                column: "AerologicalMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_CreatedById",
                table: "MonitoringPrograms",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_GeodynamicalMonitoringId",
                table: "MonitoringPrograms",
                column: "GeodynamicalMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_GeotechnicalMonitoringId",
                table: "MonitoringPrograms",
                column: "GeotechnicalMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_HydrogeologicalMonitoringId",
                table: "MonitoringPrograms",
                column: "HydrogeologicalMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_HydrologicalMonitoringId",
                table: "MonitoringPrograms",
                column: "HydrologicalMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_MeteorologicalMonitoringId",
                table: "MonitoringPrograms",
                column: "MeteorologicalMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_SeismologicalMonitoringId",
                table: "MonitoringPrograms",
                column: "SeismologicalMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_TechnogenicMonitoringId",
                table: "MonitoringPrograms",
                column: "TechnogenicMonitoringId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringPrograms_UpdatedById",
                table: "MonitoringPrograms",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_AddressId",
                table: "NonIndustrialObject",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_ClimateConditionsId",
                table: "NonIndustrialObject",
                column: "ClimateConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_ConstractionDatesId",
                table: "NonIndustrialObject",
                column: "ConstractionDatesId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_ConstractionTypeId",
                table: "NonIndustrialObject",
                column: "ConstractionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_CreatedById",
                table: "NonIndustrialObject",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_DangerousAndComplexId",
                table: "NonIndustrialObject",
                column: "DangerousAndComplexId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_DestroyFundsId",
                table: "NonIndustrialObject",
                column: "DestroyFundsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_EnergyEfficiencyId",
                table: "NonIndustrialObject",
                column: "EnergyEfficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_EnergyEfficiencyLinksId",
                table: "NonIndustrialObject",
                column: "EnergyEfficiencyLinksId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_FireDangerCategoryId",
                table: "NonIndustrialObject",
                column: "FireDangerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_FunctionsFeaturesId",
                table: "NonIndustrialObject",
                column: "FunctionsFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_FunctionsId",
                table: "NonIndustrialObject",
                column: "FunctionsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_LandFundsId",
                table: "NonIndustrialObject",
                column: "LandFundsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_LandInfoId",
                table: "NonIndustrialObject",
                column: "LandInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_LandReclamationLinkId",
                table: "NonIndustrialObject",
                column: "LandReclamationLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_ModelId",
                table: "NonIndustrialObject",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_ObjectPartsId",
                table: "NonIndustrialObject",
                column: "ObjectPartsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_PatentsUsedId",
                table: "NonIndustrialObject",
                column: "PatentsUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_PeoplePermanentStayId",
                table: "NonIndustrialObject",
                column: "PeoplePermanentStayId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_PlacementId",
                table: "NonIndustrialObject",
                column: "PlacementId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_ProjectDocumentationId",
                table: "NonIndustrialObject",
                column: "ProjectDocumentationId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_RenewableSourceInfoId",
                table: "NonIndustrialObject",
                column: "RenewableSourceInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_ResourcesId",
                table: "NonIndustrialObject",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_ResponsibilityLevelId",
                table: "NonIndustrialObject",
                column: "ResponsibilityLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_SoftwareUsedId",
                table: "NonIndustrialObject",
                column: "SoftwareUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_SpecialRequirementsId",
                table: "NonIndustrialObject",
                column: "SpecialRequirementsId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_StaffNoteId",
                table: "NonIndustrialObject",
                column: "StaffNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_StagesInfoId",
                table: "NonIndustrialObject",
                column: "StagesInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_UniqueId",
                table: "NonIndustrialObject",
                column: "UniqueId");

            migrationBuilder.CreateIndex(
                name: "IX_NonIndustrialObject_UpdatedById",
                table: "NonIndustrialObject",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_CreatedById",
                table: "NonLinearProjectDocumentContent",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section10Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section10Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section11Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section11Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section12Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section12Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section13Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section13Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section2Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section2Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section3Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section3Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section4Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section4Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section5Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section5Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section6Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section6Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section7Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section7Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section8Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section8Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_Section9Id",
                table: "NonLinearProjectDocumentContent",
                column: "Section9Id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLinearProjectDocumentContent_UpdatedById",
                table: "NonLinearProjectDocumentContent",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NuclearPlantFeatures_CreatedById",
                table: "NuclearPlantFeatures",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_NuclearPlantFeatures_MonitoringProgramsId",
                table: "NuclearPlantFeatures",
                column: "MonitoringProgramsId");

            migrationBuilder.CreateIndex(
                name: "IX_NuclearPlantFeatures_NuclearPlantControlId",
                table: "NuclearPlantFeatures",
                column: "NuclearPlantControlId");

            migrationBuilder.CreateIndex(
                name: "IX_NuclearPlantFeatures_NuclearSafetyId",
                table: "NuclearPlantFeatures",
                column: "NuclearSafetyId");

            migrationBuilder.CreateIndex(
                name: "IX_NuclearPlantFeatures_NuclearSafitySoftwareId",
                table: "NuclearPlantFeatures",
                column: "NuclearSafitySoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_NuclearPlantFeatures_ObjectListId",
                table: "NuclearPlantFeatures",
                column: "ObjectListId");

            migrationBuilder.CreateIndex(
                name: "IX_NuclearPlantFeatures_OperationalLimitsId",
                table: "NuclearPlantFeatures",
                column: "OperationalLimitsId");

            migrationBuilder.CreateIndex(
                name: "IX_NuclearPlantFeatures_ReactorPlantId",
                table: "NuclearPlantFeatures",
                column: "ReactorPlantId");

            migrationBuilder.CreateIndex(
                name: "IX_NuclearPlantFeatures_UpdatedById",
                table: "NuclearPlantFeatures",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectParts_CreatedById",
                table: "ObjectParts",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectParts_UpdatedById",
                table: "ObjectParts",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_CreatedById",
                table: "OKS",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_DangerousIndustrialObjectId",
                table: "OKS",
                column: "DangerousIndustrialObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_EnergyEfficiencyId",
                table: "OKS",
                column: "EnergyEfficiencyId");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_FireDangerCategoryId",
                table: "OKS",
                column: "FireDangerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_FunctionsFeaturesId",
                table: "OKS",
                column: "FunctionsFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_ModelId",
                table: "OKS",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_ObjectPartsId",
                table: "OKS",
                column: "ObjectPartsId");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_PeoplePermanentStayId",
                table: "OKS",
                column: "PeoplePermanentStayId");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_ResponsibilityLevelId",
                table: "OKS",
                column: "ResponsibilityLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_OKS_UpdatedById",
                table: "OKS",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_AddressId",
                table: "Organization",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_CreatedById",
                table: "Organization",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Organization_UpdatedById",
                table: "Organization",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentsSection_CreatedById",
                table: "OtherDocumentsSection",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentsSection_SectionContentId",
                table: "OtherDocumentsSection",
                column: "SectionContentId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherDocumentsSection_UpdatedById",
                table: "OtherDocumentsSection",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CreatedById",
                table: "Person",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PostAddressId",
                table: "Person",
                column: "PostAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_UpdatedById",
                table: "Person",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateSource_CreatedById",
                table: "PrivateSource",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateSource_FinanceSourcesId",
                table: "PrivateSource",
                column: "FinanceSourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivateSource_UpdatedById",
                table: "PrivateSource",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocParticipant_CreatedById",
                table: "ProjectDocParticipant",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocParticipant_ProjectDocParticipantsId",
                table: "ProjectDocParticipant",
                column: "ProjectDocParticipantsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocParticipant_RoleId",
                table: "ProjectDocParticipant",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocParticipant_UpdatedById",
                table: "ProjectDocParticipant",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocParticipants_CreatedById",
                table: "ProjectDocParticipants",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocParticipants_UpdatedById",
                table: "ProjectDocParticipants",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocument_CreatedById",
                table: "ProjectDocument",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocument_ProjectDocParticipantsId",
                table: "ProjectDocument",
                column: "ProjectDocParticipantsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocument_ProjectDocumentNotNecessarySectionContentId",
                table: "ProjectDocument",
                column: "ProjectDocumentNotNecessarySectionContentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocument_ProjectDocumentSectionContentId",
                table: "ProjectDocument",
                column: "ProjectDocumentSectionContentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocument_ProjectDocumentSubSectionId",
                table: "ProjectDocument",
                column: "ProjectDocumentSubSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocument_UpdatedById",
                table: "ProjectDocument",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentationAuthors_CreatedById",
                table: "ProjectDocumentationAuthors",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentationAuthors_UpdatedById",
                table: "ProjectDocumentationAuthors",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentationLink_CreatedById",
                table: "ProjectDocumentationLink",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentationLink_ProjectDocumentationLinksId",
                table: "ProjectDocumentationLink",
                column: "ProjectDocumentationLinksId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentationLink_UpdatedById",
                table: "ProjectDocumentationLink",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentationLinks_CreatedById",
                table: "ProjectDocumentationLinks",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentationLinks_UpdatedById",
                table: "ProjectDocumentationLinks",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentNotNecessarySectionContent_CreatedById",
                table: "ProjectDocumentNotNecessarySectionContent",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentNotNecessarySectionContent_UpdatedById",
                table: "ProjectDocumentNotNecessarySectionContent",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentSection_CreatedById",
                table: "ProjectDocumentSection",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentSection_SectionContentId",
                table: "ProjectDocumentSection",
                column: "SectionContentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentSection_UpdatedById",
                table: "ProjectDocumentSection",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentSectionContent_CreatedById",
                table: "ProjectDocumentSectionContent",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentSectionContent_UpdatedById",
                table: "ProjectDocumentSectionContent",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentSubSection_CreatedById",
                table: "ProjectDocumentSubSection",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentSubSection_ProjectDocumentSectionContentId",
                table: "ProjectDocumentSubSection",
                column: "ProjectDocumentSectionContentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentSubSection_ProjectDocumentSubSectionId",
                table: "ProjectDocumentSubSection",
                column: "ProjectDocumentSubSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDocumentSubSection_UpdatedById",
                table: "ProjectDocumentSubSection",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_CreatedById",
                table: "Resource",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_MeasureId",
                table: "Resource",
                column: "MeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_ResourcesId",
                table: "Resource",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_UpdatedById",
                table: "Resource",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CreatedById",
                table: "Resources",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_NoteId",
                table: "Resources",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_UpdatedById",
                table: "Resources",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Route_CreatedById",
                table: "Route",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Route_NoteId",
                table: "Route",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_RoutesId",
                table: "Route",
                column: "RoutesId");

            migrationBuilder.CreateIndex(
                name: "IX_Route_UpdatedById",
                table: "Route",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_CreatedById",
                table: "Routes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_RoutesNoteId",
                table: "Routes",
                column: "RoutesNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_UpdatedById",
                table: "Routes",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Section5_CreatedById",
                table: "Section5",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Section5_SectionContentId",
                table: "Section5",
                column: "SectionContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Section5_UpdatedById",
                table: "Section5",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Section5Content_CommunicationId",
                table: "Section5Content",
                column: "CommunicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Section5Content_CreatedById",
                table: "Section5Content",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Section5Content_ElectricitySupplyId",
                table: "Section5Content",
                column: "ElectricitySupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Section5Content_GasSupplyId",
                table: "Section5Content",
                column: "GasSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Section5Content_HeatingVentilationId",
                table: "Section5Content",
                column: "HeatingVentilationId");

            migrationBuilder.CreateIndex(
                name: "IX_Section5Content_UpdatedById",
                table: "Section5Content",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Section5Content_WaterRemovalId",
                table: "Section5Content",
                column: "WaterRemovalId");

            migrationBuilder.CreateIndex(
                name: "IX_Section5Content_WaterSupplyId",
                table: "Section5Content",
                column: "WaterSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimate_CreatedById",
                table: "SectionEstimate",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimate_SectionContentId",
                table: "SectionEstimate",
                column: "SectionContentId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimate_UpdatedById",
                table: "SectionEstimate",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimateContent_CostsEstimatesId",
                table: "SectionEstimateContent",
                column: "CostsEstimatesId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimateContent_CostSummaryId",
                table: "SectionEstimateContent",
                column: "CostSummaryId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimateContent_CreatedById",
                table: "SectionEstimateContent",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimateContent_EstimateExplanatoryNoteId",
                table: "SectionEstimateContent",
                column: "EstimateExplanatoryNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimateContent_LocalEstimatesId",
                table: "SectionEstimateContent",
                column: "LocalEstimatesId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimateContent_ObjectEstimatesId",
                table: "SectionEstimateContent",
                column: "ObjectEstimatesId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimateContent_SummaryEstimateId",
                table: "SectionEstimateContent",
                column: "SummaryEstimateId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionEstimateContent_UpdatedById",
                table: "SectionEstimateContent",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_BiologicalResourcesImpactId",
                table: "SectionOtherContent",
                column: "BiologicalResourcesImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_CivilDefenseId",
                table: "SectionOtherContent",
                column: "CivilDefenseId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_CounteringTerrorismId",
                table: "SectionOtherContent",
                column: "CounteringTerrorismId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_CreatedById",
                table: "SectionOtherContent",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_CulturalHeritageSitesId",
                table: "SectionOtherContent",
                column: "CulturalHeritageSitesId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_HydraulicStructuresSafetyDeclarationId",
                table: "SectionOtherContent",
                column: "HydraulicStructuresSafetyDeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_IndustrialSafetyDeclarationId",
                table: "SectionOtherContent",
                column: "IndustrialSafetyDeclarationId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_LandsReclamationId",
                table: "SectionOtherContent",
                column: "LandsReclamationId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_OtherDocumentsId",
                table: "SectionOtherContent",
                column: "OtherDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_RadiationNuclearSafetyId",
                table: "SectionOtherContent",
                column: "RadiationNuclearSafetyId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_SanitarySafetyId",
                table: "SectionOtherContent",
                column: "SanitarySafetyId");

            migrationBuilder.CreateIndex(
                name: "IX_SectionOtherContent_UpdatedById",
                table: "SectionOtherContent",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Signers_ChiefProjectArchitectId",
                table: "Signers",
                column: "ChiefProjectArchitectId");

            migrationBuilder.CreateIndex(
                name: "IX_Signers_ChiefProjectEngineerId",
                table: "Signers",
                column: "ChiefProjectEngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_Signers_CreatedById",
                table: "Signers",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Signers_UpdatedById",
                table: "Signers",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SignFile_CreatedById",
                table: "SignFile",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SignFile_FileId",
                table: "SignFile",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_SignFile_ModelFileId",
                table: "SignFile",
                column: "ModelFileId");

            migrationBuilder.CreateIndex(
                name: "IX_SignFile_UpdatedById",
                table: "SignFile",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Software_CreatedById",
                table: "Software",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Software_SoftwareUsedId",
                table: "Software",
                column: "SoftwareUsedId");

            migrationBuilder.CreateIndex(
                name: "IX_Software_UpdatedById",
                table: "Software",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareUsed_CreatedById",
                table: "SoftwareUsed",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareUsed_SoftwareNoteId",
                table: "SoftwareUsed",
                column: "SoftwareNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareUsed_UpdatedById",
                table: "SoftwareUsed",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SRO_CreatedById",
                table: "SRO",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SRO_SROMembershipId",
                table: "SRO",
                column: "SROMembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_SRO_SROTypeId",
                table: "SRO",
                column: "SROTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SRO_UpdatedById",
                table: "SRO",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SROMembership_CreatedById",
                table: "SROMembership",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SROMembership_UpdatedById",
                table: "SROMembership",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_CreatedById",
                table: "Stage",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_NoteId",
                table: "Stage",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_StagesInfoId",
                table: "Stage",
                column: "StagesInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_UpdatedById",
                table: "Stage",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_StagesInfo_CreatedById",
                table: "StagesInfo",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_StagesInfo_ReasonNoteId",
                table: "StagesInfo",
                column: "ReasonNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_StagesInfo_UpdatedById",
                table: "StagesInfo",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_StateCustomerSource_CreatedById",
                table: "StateCustomerSource",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_StateCustomerSource_FinanceSourcesId",
                table: "StateCustomerSource",
                column: "FinanceSourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_StateCustomerSource_OwnerId",
                table: "StateCustomerSource",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_StateCustomerSource_UpdatedById",
                table: "StateCustomerSource",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalCustomer_CreatedById",
                table: "TechnicalCustomer",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalCustomer_ExplanatoryNoteId",
                table: "TechnicalCustomer",
                column: "ExplanatoryNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalCustomer_ForeignOrganizationId",
                table: "TechnicalCustomer",
                column: "ForeignOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalCustomer_OrganizationId",
                table: "TechnicalCustomer",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalCustomer_SROMembershipId",
                table: "TechnicalCustomer",
                column: "SROMembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalCustomer_UpdatedById",
                table: "TechnicalCustomer",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_ComplexPartId",
                table: "TEI",
                column: "ComplexPartId");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_CreatedById",
                table: "TEI",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_IndustrialObjectId",
                table: "TEI",
                column: "IndustrialObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_LinearObjectId",
                table: "TEI",
                column: "LinearObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_NonIndustrialObjectId",
                table: "TEI",
                column: "NonIndustrialObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_OKEIId",
                table: "TEI",
                column: "OKEIId");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_OKSId",
                table: "TEI",
                column: "OKSId");

            migrationBuilder.CreateIndex(
                name: "IX_TEI_UpdatedById",
                table: "TEI",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TextBlock_CreatedById",
                table: "TextBlock",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TextBlock_ExplanatoryNoteId",
                table: "TextBlock",
                column: "ExplanatoryNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_TextBlock_UpdatedById",
                table: "TextBlock",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UsedNorm_CreatedById",
                table: "UsedNorm",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UsedNorm_UpdatedById",
                table: "UsedNorm",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UsedNorm_UsedNormsId",
                table: "UsedNorm",
                column: "UsedNormsId");

            migrationBuilder.CreateIndex(
                name: "IX_UsedNorms_CreatedById",
                table: "UsedNorms",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UsedNorms_UpdatedById",
                table: "UsedNorms",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPerson_CreatedById",
                table: "WorkPerson",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPerson_SignersId",
                table: "WorkPerson",
                column: "SignersId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkPerson_UpdatedById",
                table: "WorkPerson",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_ComplexPart_ComplexPartId",
                table: "Address",
                column: "ComplexPartId",
                principalTable: "ComplexPart",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_OKS_OKSId",
                table: "Address",
                column: "OKSId",
                principalTable: "OKS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClimateConditions_TextBlock_ClimateNoteId",
                table: "ClimateConditions",
                column: "ClimateNoteId",
                principalTable: "TextBlock",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ComplexPart_TextBlock_FunctionFeaturesId",
                table: "ComplexPart",
                column: "FunctionFeaturesId",
                principalTable: "TextBlock",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Developer_ExplanatoryNote_ExplanatoryNoteId",
                table: "Developer",
                column: "ExplanatoryNoteId",
                principalTable: "ExplanatoryNote",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnergyEfficiency_TextBlock_EnergyEfficiencyImprovingId",
                table: "EnergyEfficiency",
                column: "EnergyEfficiencyImprovingId",
                principalTable: "TextBlock",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExplanatoryNote_IndustrialObject_IndustrialObjectId",
                table: "ExplanatoryNote",
                column: "IndustrialObjectId",
                principalTable: "IndustrialObject",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExplanatoryNote_LinearObject_LinearObjectId",
                table: "ExplanatoryNote",
                column: "LinearObjectId",
                principalTable: "LinearObject",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExplanatoryNote_NonIndustrialObject_NonIndustrialObjectId",
                table: "ExplanatoryNote",
                column: "NonIndustrialObjectId",
                principalTable: "NonIndustrialObject",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExplanatoryNote_TextBlock_DesignerAssuranceId",
                table: "ExplanatoryNote",
                column: "DesignerAssuranceId",
                principalTable: "TextBlock",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExplanatoryNote_TextBlock_UsedAbbreviationsId",
                table: "ExplanatoryNote",
                column: "UsedAbbreviationsId",
                principalTable: "TextBlock",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalData_SysUser_CreatedById",
                table: "AdditionalData");

            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalData_SysUser_UpdatedById",
                table: "AdditionalData");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_SysUser_CreatedById",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_SysUser_UpdatedById",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_SysUser_CreatedById",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_SysUser_UpdatedById",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiefProjectEngineer_SysUser_CreatedById",
                table: "ChiefProjectEngineer");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiefProjectEngineer_SysUser_UpdatedById",
                table: "ChiefProjectEngineer");

            migrationBuilder.DropForeignKey(
                name: "FK_ClimateConditions_SysUser_CreatedById",
                table: "ClimateConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_ClimateConditions_SysUser_UpdatedById",
                table: "ClimateConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_ComplexPart_SysUser_CreatedById",
                table: "ComplexPart");

            migrationBuilder.DropForeignKey(
                name: "FK_ComplexPart_SysUser_UpdatedById",
                table: "ComplexPart");

            migrationBuilder.DropForeignKey(
                name: "FK_ConstructionDates_SysUser_CreatedById",
                table: "ConstructionDates");

            migrationBuilder.DropForeignKey(
                name: "FK_ConstructionDates_SysUser_UpdatedById",
                table: "ConstructionDates");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_SysUser_CreatedById",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_SysUser_UpdatedById",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_EnergyEfficiency_SysUser_CreatedById",
                table: "EnergyEfficiency");

            migrationBuilder.DropForeignKey(
                name: "FK_EnergyEfficiency_SysUser_UpdatedById",
                table: "EnergyEfficiency");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineeringSurveyDocument_SysUser_CreatedById",
                table: "EngineeringSurveyDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineeringSurveyDocument_SysUser_UpdatedById",
                table: "EngineeringSurveyDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineeringSurveyDocuments_SysUser_CreatedById",
                table: "EngineeringSurveyDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineeringSurveyDocuments_SysUser_UpdatedById",
                table: "EngineeringSurveyDocuments");

            migrationBuilder.DropForeignKey(
                name: "FK_ExplanatoryNote_SysUser_CreatedById",
                table: "ExplanatoryNote");

            migrationBuilder.DropForeignKey(
                name: "FK_ExplanatoryNote_SysUser_UpdatedById",
                table: "ExplanatoryNote");

            migrationBuilder.DropForeignKey(
                name: "FK_ExplanatoryNoteModifications_SysUser_CreatedById",
                table: "ExplanatoryNoteModifications");

            migrationBuilder.DropForeignKey(
                name: "FK_ExplanatoryNoteModifications_SysUser_UpdatedById",
                table: "ExplanatoryNoteModifications");

            migrationBuilder.DropForeignKey(
                name: "FK_FinanceSources_SysUser_CreatedById",
                table: "FinanceSources");

            migrationBuilder.DropForeignKey(
                name: "FK_FinanceSources_SysUser_UpdatedById",
                table: "FinanceSources");

            migrationBuilder.DropForeignKey(
                name: "FK_ForeignOrganization_SysUser_CreatedById",
                table: "ForeignOrganization");

            migrationBuilder.DropForeignKey(
                name: "FK_ForeignOrganization_SysUser_UpdatedById",
                table: "ForeignOrganization");

            migrationBuilder.DropForeignKey(
                name: "FK_Functions_SysUser_CreatedById",
                table: "Functions");

            migrationBuilder.DropForeignKey(
                name: "FK_Functions_SysUser_UpdatedById",
                table: "Functions");

            migrationBuilder.DropForeignKey(
                name: "FK_GasLinearProjectDocumentContent_SysUser_CreatedById",
                table: "GasLinearProjectDocumentContent");

            migrationBuilder.DropForeignKey(
                name: "FK_GasLinearProjectDocumentContent_SysUser_UpdatedById",
                table: "GasLinearProjectDocumentContent");

            migrationBuilder.DropForeignKey(
                name: "FK_GasNetworksFeatures_SysUser_CreatedById",
                table: "GasNetworksFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_GasNetworksFeatures_SysUser_UpdatedById",
                table: "GasNetworksFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_SysUser_CreatedById",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_SysUser_UpdatedById",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IP_SysUser_CreatedById",
                table: "IP");

            migrationBuilder.DropForeignKey(
                name: "FK_IP_SysUser_UpdatedById",
                table: "IP");

            migrationBuilder.DropForeignKey(
                name: "FK_LandInfo_SysUser_CreatedById",
                table: "LandInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LandInfo_SysUser_UpdatedById",
                table: "LandInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_SysUser_CreatedById",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_SysUser_UpdatedById",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearProjectDocumentContent_SysUser_CreatedById",
                table: "LinearProjectDocumentContent");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearProjectDocumentContent_SysUser_UpdatedById",
                table: "LinearProjectDocumentContent");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_SysUser_CreatedById",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_SysUser_UpdatedById",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_SysUser_CreatedById",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_SysUser_UpdatedById",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_SysUser_CreatedById",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_SysUser_UpdatedById",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonLinearProjectDocumentContent_SysUser_CreatedById",
                table: "NonLinearProjectDocumentContent");

            migrationBuilder.DropForeignKey(
                name: "FK_NonLinearProjectDocumentContent_SysUser_UpdatedById",
                table: "NonLinearProjectDocumentContent");

            migrationBuilder.DropForeignKey(
                name: "FK_NuclearPlantFeatures_SysUser_CreatedById",
                table: "NuclearPlantFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_NuclearPlantFeatures_SysUser_UpdatedById",
                table: "NuclearPlantFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectParts_SysUser_CreatedById",
                table: "ObjectParts");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectParts_SysUser_UpdatedById",
                table: "ObjectParts");

            migrationBuilder.DropForeignKey(
                name: "FK_OKS_SysUser_CreatedById",
                table: "OKS");

            migrationBuilder.DropForeignKey(
                name: "FK_OKS_SysUser_UpdatedById",
                table: "OKS");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_SysUser_CreatedById",
                table: "Organization");

            migrationBuilder.DropForeignKey(
                name: "FK_Organization_SysUser_UpdatedById",
                table: "Organization");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocumentsSection_SysUser_CreatedById",
                table: "OtherDocumentsSection");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocumentsSection_SysUser_UpdatedById",
                table: "OtherDocumentsSection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentationAuthors_SysUser_CreatedById",
                table: "ProjectDocumentationAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentationAuthors_SysUser_UpdatedById",
                table: "ProjectDocumentationAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentationLinks_SysUser_CreatedById",
                table: "ProjectDocumentationLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentationLinks_SysUser_UpdatedById",
                table: "ProjectDocumentationLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentNotNecessarySectionContent_SysUser_CreatedBy~",
                table: "ProjectDocumentNotNecessarySectionContent");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentNotNecessarySectionContent_SysUser_UpdatedBy~",
                table: "ProjectDocumentNotNecessarySectionContent");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentSection_SysUser_CreatedById",
                table: "ProjectDocumentSection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentSection_SysUser_UpdatedById",
                table: "ProjectDocumentSection");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentSectionContent_SysUser_CreatedById",
                table: "ProjectDocumentSectionContent");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectDocumentSectionContent_SysUser_UpdatedById",
                table: "ProjectDocumentSectionContent");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_SysUser_CreatedById",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_SysUser_UpdatedById",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_SysUser_CreatedById",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_SysUser_UpdatedById",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Section5_SysUser_CreatedById",
                table: "Section5");

            migrationBuilder.DropForeignKey(
                name: "FK_Section5_SysUser_UpdatedById",
                table: "Section5");

            migrationBuilder.DropForeignKey(
                name: "FK_Section5Content_SysUser_CreatedById",
                table: "Section5Content");

            migrationBuilder.DropForeignKey(
                name: "FK_Section5Content_SysUser_UpdatedById",
                table: "Section5Content");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionEstimate_SysUser_CreatedById",
                table: "SectionEstimate");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionEstimate_SysUser_UpdatedById",
                table: "SectionEstimate");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionEstimateContent_SysUser_CreatedById",
                table: "SectionEstimateContent");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionEstimateContent_SysUser_UpdatedById",
                table: "SectionEstimateContent");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionOtherContent_SysUser_CreatedById",
                table: "SectionOtherContent");

            migrationBuilder.DropForeignKey(
                name: "FK_SectionOtherContent_SysUser_UpdatedById",
                table: "SectionOtherContent");

            migrationBuilder.DropForeignKey(
                name: "FK_Signers_SysUser_CreatedById",
                table: "Signers");

            migrationBuilder.DropForeignKey(
                name: "FK_Signers_SysUser_UpdatedById",
                table: "Signers");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareUsed_SysUser_CreatedById",
                table: "SoftwareUsed");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareUsed_SysUser_UpdatedById",
                table: "SoftwareUsed");

            migrationBuilder.DropForeignKey(
                name: "FK_SROMembership_SysUser_CreatedById",
                table: "SROMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_SROMembership_SysUser_UpdatedById",
                table: "SROMembership");

            migrationBuilder.DropForeignKey(
                name: "FK_StagesInfo_SysUser_CreatedById",
                table: "StagesInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_StagesInfo_SysUser_UpdatedById",
                table: "StagesInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_TextBlock_SysUser_CreatedById",
                table: "TextBlock");

            migrationBuilder.DropForeignKey(
                name: "FK_TextBlock_SysUser_UpdatedById",
                table: "TextBlock");

            migrationBuilder.DropForeignKey(
                name: "FK_UsedNorms_SysUser_CreatedById",
                table: "UsedNorms");

            migrationBuilder.DropForeignKey(
                name: "FK_UsedNorms_SysUser_UpdatedById",
                table: "UsedNorms");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_ComplexPart_ComplexPartId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_OKS_OKSId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_RegionsRF_RegionId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_EngineeringSurveyDocument_EngineeringSurveyDocumentId",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_ForeignOrganization_ForeignOrganizationId",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_IP_IPId",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_Organization_OrganizationId",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_ProjectDocumentationAuthors_ProjectDocumentationAuth~",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_ExplanatoryNote_ProjectDocumentationAuthors_ProjectDocument~",
                table: "ExplanatoryNote");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_SROMembership_SROMembershipId",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_ExplanatoryNote_FinanceSources_FinanceSourcesId",
                table: "ExplanatoryNote");

            migrationBuilder.DropForeignKey(
                name: "FK_ClimateConditions_TextBlock_ClimateNoteId",
                table: "ClimateConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_EnergyEfficiency_TextBlock_EnergyEfficiencyImprovingId",
                table: "EnergyEfficiency");

            migrationBuilder.DropForeignKey(
                name: "FK_ExplanatoryNote_TextBlock_DesignerAssuranceId",
                table: "ExplanatoryNote");

            migrationBuilder.DropForeignKey(
                name: "FK_ExplanatoryNote_TextBlock_UsedAbbreviationsId",
                table: "ExplanatoryNote");

            migrationBuilder.DropForeignKey(
                name: "FK_Functions_TextBlock_ProductsNoteId",
                table: "Functions");

            migrationBuilder.DropForeignKey(
                name: "FK_GasNetworksFeatures_TextBlock_EnvironmentalProtectionId",
                table: "GasNetworksFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_GasNetworksFeatures_TextBlock_FireSafetyId",
                table: "GasNetworksFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_GasNetworksFeatures_TextBlock_OperationalSafetyId",
                table: "GasNetworksFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_GasNetworksFeatures_TextBlock_RepairFrequencyId",
                table: "GasNetworksFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_GasNetworksFeatures_TextBlock_StrengthCalculationId",
                table: "GasNetworksFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_DestroyFundsId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_FunctionsFeaturesId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_LandFundsId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_LandReclamationLinkId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_PatentsUsedId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_PeoplePermanentStayId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_RenewableSourceInfoId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_ResourceUseInfoId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_SpecialRequirementsId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialObject_TextBlock_StaffNoteId",
                table: "IndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LandInfo_TextBlock_CommonLandInfoId",
                table: "LandInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_DestroyFundsId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_EngineeringTerritoryProtectionId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_FunctionsFeaturesId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_LandFundsId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_LandReclamationLinkId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_LinearObjectCategoryId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_LinearObjectClassId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_LinearObjectNoteId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_PatentsUsedId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_PeoplePermanentStayId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_RenewableSourceInfoId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_ResourceUseInfoId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_SpecialRequirementsId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_LinearObject_TextBlock_StaffNoteId",
                table: "LinearObject");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_TextBlock_AerologicalMonitoringId",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_TextBlock_GeodynamicalMonitoringId",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_TextBlock_GeotechnicalMonitoringId",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_TextBlock_HydrogeologicalMonitoringId",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_TextBlock_HydrologicalMonitoringId",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_TextBlock_MeteorologicalMonitoringId",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_TextBlock_SeismologicalMonitoringId",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringPrograms_TextBlock_TechnogenicMonitoringId",
                table: "MonitoringPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_TextBlock_DestroyFundsId",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_TextBlock_FunctionsFeaturesId",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_TextBlock_LandFundsId",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_TextBlock_LandReclamationLinkId",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_TextBlock_PatentsUsedId",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_TextBlock_PeoplePermanentStayId",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_TextBlock_RenewableSourceInfoId",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_TextBlock_SpecialRequirementsId",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NonIndustrialObject_TextBlock_StaffNoteId",
                table: "NonIndustrialObject");

            migrationBuilder.DropForeignKey(
                name: "FK_NuclearPlantFeatures_TextBlock_NuclearPlantControlId",
                table: "NuclearPlantFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_NuclearPlantFeatures_TextBlock_NuclearSafetyId",
                table: "NuclearPlantFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_NuclearPlantFeatures_TextBlock_NuclearSafitySoftwareId",
                table: "NuclearPlantFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_NuclearPlantFeatures_TextBlock_ObjectListId",
                table: "NuclearPlantFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_NuclearPlantFeatures_TextBlock_OperationalLimitsId",
                table: "NuclearPlantFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_NuclearPlantFeatures_TextBlock_ReactorPlantId",
                table: "NuclearPlantFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_TextBlock_NoteId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_TextBlock_RoutesNoteId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareUsed_TextBlock_SoftwareNoteId",
                table: "SoftwareUsed");

            migrationBuilder.DropForeignKey(
                name: "FK_StagesInfo_TextBlock_ReasonNoteId",
                table: "StagesInfo");

            migrationBuilder.DropTable(
                name: "BudgetSource");

            migrationBuilder.DropTable(
                name: "ClimateConditionsClimateDistrict");

            migrationBuilder.DropTable(
                name: "ClimateConditionsGeologicalConditions");

            migrationBuilder.DropTable(
                name: "ClimateConditionsSeismicActivity");

            migrationBuilder.DropTable(
                name: "ClimateConditionsSnowDistrict");

            migrationBuilder.DropTable(
                name: "ClimateConditionsWindDistrict");

            migrationBuilder.DropTable(
                name: "Developer");

            migrationBuilder.DropTable(
                name: "LandAreaInfo");

            migrationBuilder.DropTable(
                name: "LandCategoryMappings");

            migrationBuilder.DropTable(
                name: "ModelFormat");

            migrationBuilder.DropTable(
                name: "Modification");

            migrationBuilder.DropTable(
                name: "PrivateSource");

            migrationBuilder.DropTable(
                name: "ProjectDocParticipant");

            migrationBuilder.DropTable(
                name: "ProjectDocumentationLink");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "SignFile");

            migrationBuilder.DropTable(
                name: "Software");

            migrationBuilder.DropTable(
                name: "SRO");

            migrationBuilder.DropTable(
                name: "Stage");

            migrationBuilder.DropTable(
                name: "StateCustomerSource");

            migrationBuilder.DropTable(
                name: "TEI");

            migrationBuilder.DropTable(
                name: "UsedNorm");

            migrationBuilder.DropTable(
                name: "WorkPerson");

            migrationBuilder.DropTable(
                name: "BudgetLevel");

            migrationBuilder.DropTable(
                name: "ClimateDistrict");

            migrationBuilder.DropTable(
                name: "GeologicalConditions");

            migrationBuilder.DropTable(
                name: "SeismicActivity");

            migrationBuilder.DropTable(
                name: "SnowDistrict");

            migrationBuilder.DropTable(
                name: "WindDistrict");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "LandCategory");

            migrationBuilder.DropTable(
                name: "ParticipantResponsibilityLevel");

            migrationBuilder.DropTable(
                name: "File");

            migrationBuilder.DropTable(
                name: "ModelFile");

            migrationBuilder.DropTable(
                name: "SROType");

            migrationBuilder.DropTable(
                name: "TechnicalCustomer");

            migrationBuilder.DropTable(
                name: "OKEI");

            migrationBuilder.DropTable(
                name: "Data");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "ProjectDocument");

            migrationBuilder.DropTable(
                name: "ProjectDocParticipants");

            migrationBuilder.DropTable(
                name: "ProjectDocumentSubSection");

            migrationBuilder.DropTable(
                name: "SysUser");

            migrationBuilder.DropTable(
                name: "ComplexPart");

            migrationBuilder.DropTable(
                name: "OKS");

            migrationBuilder.DropTable(
                name: "RegionsRF");

            migrationBuilder.DropTable(
                name: "EngineeringSurveyDocument");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "ForeignOrganization");

            migrationBuilder.DropTable(
                name: "IP");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "ProjectDocumentationAuthors");

            migrationBuilder.DropTable(
                name: "SROMembership");

            migrationBuilder.DropTable(
                name: "FinanceSources");

            migrationBuilder.DropTable(
                name: "TextBlock");

            migrationBuilder.DropTable(
                name: "ExplanatoryNote");

            migrationBuilder.DropTable(
                name: "AdditionalData");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "EngineeringSurveyDocuments");

            migrationBuilder.DropTable(
                name: "ExplanatoryNoteModifications");

            migrationBuilder.DropTable(
                name: "IndustrialObject");

            migrationBuilder.DropTable(
                name: "LinearObject");

            migrationBuilder.DropTable(
                name: "NonIndustrialObject");

            migrationBuilder.DropTable(
                name: "Signers");

            migrationBuilder.DropTable(
                name: "UsedNorms");

            migrationBuilder.DropTable(
                name: "NuclearPlantFeatures");

            migrationBuilder.DropTable(
                name: "DangerIndustrialClass");

            migrationBuilder.DropTable(
                name: "GasLinearProjectDocumentContent");

            migrationBuilder.DropTable(
                name: "GasNetworksFeatures");

            migrationBuilder.DropTable(
                name: "LinearProjectDocumentContent");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "ClimateConditions");

            migrationBuilder.DropTable(
                name: "ConstractionType");

            migrationBuilder.DropTable(
                name: "ConstructionDates");

            migrationBuilder.DropTable(
                name: "DangerousAndComplex");

            migrationBuilder.DropTable(
                name: "EnergyEfficiency");

            migrationBuilder.DropTable(
                name: "FireDangerCategory");

            migrationBuilder.DropTable(
                name: "Functions");

            migrationBuilder.DropTable(
                name: "LandInfo");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "NonLinearProjectDocumentContent");

            migrationBuilder.DropTable(
                name: "ObjectParts");

            migrationBuilder.DropTable(
                name: "Placement");

            migrationBuilder.DropTable(
                name: "ProjectDocumentationLinks");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "ResponsibilityLevel");

            migrationBuilder.DropTable(
                name: "SoftwareUsed");

            migrationBuilder.DropTable(
                name: "StagesInfo");

            migrationBuilder.DropTable(
                name: "Unique");

            migrationBuilder.DropTable(
                name: "ChiefProjectEngineer");

            migrationBuilder.DropTable(
                name: "MonitoringPrograms");

            migrationBuilder.DropTable(
                name: "EfficiencyClass");

            migrationBuilder.DropTable(
                name: "OtherDocumentsSection");

            migrationBuilder.DropTable(
                name: "ProjectDocumentSection");

            migrationBuilder.DropTable(
                name: "Section5");

            migrationBuilder.DropTable(
                name: "SectionEstimate");

            migrationBuilder.DropTable(
                name: "SectionOtherContent");

            migrationBuilder.DropTable(
                name: "Section5Content");

            migrationBuilder.DropTable(
                name: "SectionEstimateContent");

            migrationBuilder.DropTable(
                name: "ProjectDocumentNotNecessarySectionContent");

            migrationBuilder.DropTable(
                name: "ProjectDocumentSectionContent");
        }
    }
}
