using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyDynamicForms.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigratrionSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "forms");

            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.CreateTable(
                name: "control_type",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__control___3213E83FC93CB3D1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "question_settings",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    settings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__question__3213E83F7B0843AD", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "question_type",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    subtype = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__question__3213E83F84AE0621", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                schema: "auth",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__roles__3213E83FE42FC2E2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_has_responses",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    form_id = table.Column<int>(type: "int", nullable: false),
                    section_id = table.Column<int>(type: "int", nullable: false),
                    order_list = table.Column<int>(type: "int", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__user_has__3213E83FE27F4276", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "auth",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    last_name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    username = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    password = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__users__3213E83FB453B3D9", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "control_name",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    name_original = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    type_id = table.Column<int>(type: "int", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__control___3213E83F1B02EBB3", x => x.id);
                    table.ForeignKey(
                        name: "FK__control_n__delet__656C112C",
                        column: x => x.type_id,
                        principalSchema: "forms",
                        principalTable: "control_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "form",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    description = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    date_publish = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_start = table.Column<DateTime>(type: "datetime", nullable: true),
                    date_end = table.Column<DateTime>(type: "datetime", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__form__3213E83F6F8AD4E0", x => x.id);
                    table.ForeignKey(
                        name: "FK__form__deleted_by__10566F31",
                        column: x => x.user_id,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "model_has_rol",
                schema: "auth",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    rol_id = table.Column<int>(type: "int", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__model_ha__3213E83F665F2679", x => x.id);
                    table.ForeignKey(
                        name: "FK__model_has__delet__5441852A",
                        column: x => x.user_id,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__model_has__rol_i__5535A963",
                        column: x => x.rol_id,
                        principalSchema: "auth",
                        principalTable: "roles",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "generic_question",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    control_id = table.Column<int>(type: "int", nullable: false),
                    type_id = table.Column<int>(type: "int", nullable: false),
                    settings_id = table.Column<int>(type: "int", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__generic___3213E83F4235EBAF", x => x.id);
                    table.ForeignKey(
                        name: "FK__generic_q__delet__7C4F7684",
                        column: x => x.control_id,
                        principalSchema: "forms",
                        principalTable: "control_name",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__generic_q__setti__7E37BEF6",
                        column: x => x.settings_id,
                        principalSchema: "forms",
                        principalTable: "question_settings",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__generic_q__type___7D439ABD",
                        column: x => x.type_id,
                        principalSchema: "forms",
                        principalTable: "question_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "generic_section",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    control_id = table.Column<int>(type: "int", nullable: false),
                    mandatory = table.Column<bool>(type: "bit", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__generic___3213E83F0077A24C", x => x.id);
                    table.ForeignKey(
                        name: "FK__generic_s__delet__70DDC3D8",
                        column: x => x.control_id,
                        principalSchema: "forms",
                        principalTable: "control_name",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "question",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    control_id = table.Column<int>(type: "int", nullable: false),
                    type_id = table.Column<int>(type: "int", nullable: false),
                    settings_id = table.Column<int>(type: "int", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__question__3213E83F32ADF8F4", x => x.id);
                    table.ForeignKey(
                        name: "FK__question__delete__75A278F5",
                        column: x => x.control_id,
                        principalSchema: "forms",
                        principalTable: "control_name",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__question__settin__778AC167",
                        column: x => x.settings_id,
                        principalSchema: "forms",
                        principalTable: "question_settings",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__question__type_i__76969D2E",
                        column: x => x.type_id,
                        principalSchema: "forms",
                        principalTable: "question_type",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "section",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    control_id = table.Column<int>(type: "int", nullable: false),
                    mandatory = table.Column<bool>(type: "bit", nullable: false),
                    description = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__section__3213E83F771541E6", x => x.id);
                    table.ForeignKey(
                        name: "FK__section__deleted__6B24EA82",
                        column: x => x.control_id,
                        principalSchema: "forms",
                        principalTable: "control_name",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "form_has_sections",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    form_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    response = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__form_has__3213E83F9A65E314", x => x.id);
                    table.ForeignKey(
                        name: "FK__form_has___delet__151B244E",
                        column: x => x.form_id,
                        principalSchema: "forms",
                        principalTable: "form",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__form_has___user___160F4887",
                        column: x => x.user_id,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "generic_questions_has_generic_sections",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question_id = table.Column<int>(type: "int", nullable: false),
                    section_id = table.Column<int>(type: "int", nullable: false),
                    mandatory = table.Column<bool>(type: "bit", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__generic___3213E83FD5684D45", x => x.id);
                    table.ForeignKey(
                        name: "FK__generic_q__delet__0A9D95DB",
                        column: x => x.question_id,
                        principalSchema: "forms",
                        principalTable: "generic_question",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__generic_q__secti__0B91BA14",
                        column: x => x.section_id,
                        principalSchema: "forms",
                        principalTable: "generic_section",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "questions_has_sections",
                schema: "forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question_id = table.Column<int>(type: "int", nullable: false),
                    section_id = table.Column<int>(type: "int", nullable: false),
                    mandatory = table.Column<bool>(type: "bit", nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    created_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    updated_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    deleted_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    deleted_by = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__question__3213E83FAD516223", x => x.id);
                    table.ForeignKey(
                        name: "FK__questions__delet__03F0984C",
                        column: x => x.question_id,
                        principalSchema: "forms",
                        principalTable: "question",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__questions__secti__04E4BC85",
                        column: x => x.section_id,
                        principalSchema: "forms",
                        principalTable: "section",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_control_name_type_id",
                schema: "forms",
                table: "control_name",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_form_user_id",
                schema: "forms",
                table: "form",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_form_has_sections_form_id",
                schema: "forms",
                table: "form_has_sections",
                column: "form_id");

            migrationBuilder.CreateIndex(
                name: "IX_form_has_sections_user_id",
                schema: "forms",
                table: "form_has_sections",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_generic_question_control_id",
                schema: "forms",
                table: "generic_question",
                column: "control_id");

            migrationBuilder.CreateIndex(
                name: "IX_generic_question_settings_id",
                schema: "forms",
                table: "generic_question",
                column: "settings_id");

            migrationBuilder.CreateIndex(
                name: "IX_generic_question_type_id",
                schema: "forms",
                table: "generic_question",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_generic_questions_has_generic_sections_question_id",
                schema: "forms",
                table: "generic_questions_has_generic_sections",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_generic_questions_has_generic_sections_section_id",
                schema: "forms",
                table: "generic_questions_has_generic_sections",
                column: "section_id");

            migrationBuilder.CreateIndex(
                name: "IX_generic_section_control_id",
                schema: "forms",
                table: "generic_section",
                column: "control_id");

            migrationBuilder.CreateIndex(
                name: "IX_model_has_rol_rol_id",
                schema: "auth",
                table: "model_has_rol",
                column: "rol_id");

            migrationBuilder.CreateIndex(
                name: "IX_model_has_rol_user_id",
                schema: "auth",
                table: "model_has_rol",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_question_control_id",
                schema: "forms",
                table: "question",
                column: "control_id");

            migrationBuilder.CreateIndex(
                name: "IX_question_settings_id",
                schema: "forms",
                table: "question",
                column: "settings_id");

            migrationBuilder.CreateIndex(
                name: "IX_question_type_id",
                schema: "forms",
                table: "question",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_questions_has_sections_question_id",
                schema: "forms",
                table: "questions_has_sections",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_questions_has_sections_section_id",
                schema: "forms",
                table: "questions_has_sections",
                column: "section_id");

            migrationBuilder.CreateIndex(
                name: "IX_section_control_id",
                schema: "forms",
                table: "section",
                column: "control_id");

            migrationBuilder.CreateIndex(
                name: "UQ__users__F3DBC572D9E4D365",
                schema: "auth",
                table: "users",
                column: "username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "form_has_sections",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "generic_questions_has_generic_sections",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "model_has_rol",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "questions_has_sections",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "user_has_responses",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "form",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "generic_question",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "generic_section",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "roles",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "question",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "section",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "users",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "question_settings",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "question_type",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "control_name",
                schema: "forms");

            migrationBuilder.DropTable(
                name: "control_type",
                schema: "forms");
        }
    }
}
