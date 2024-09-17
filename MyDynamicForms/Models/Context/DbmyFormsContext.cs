using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyDynamicForms.Models.Context;

public partial class DbmyFormsContext : DbContext
{
    public DbmyFormsContext()
    {
    }

    public DbmyFormsContext(DbContextOptions<DbmyFormsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ControlName> ControlNames { get; set; }

    public virtual DbSet<ControlType> ControlTypes { get; set; }

    public virtual DbSet<Form> Forms { get; set; }

    public virtual DbSet<FormHasSection> FormHasSections { get; set; }

    public virtual DbSet<GenericQuestion> GenericQuestions { get; set; }

    public virtual DbSet<GenericQuestionsHasGenericSection> GenericQuestionsHasGenericSections { get; set; }

    public virtual DbSet<GenericSection> GenericSections { get; set; }

    public virtual DbSet<ModelHasRol> ModelHasRols { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<QuestionSetting> QuestionSettings { get; set; }

    public virtual DbSet<QuestionType> QuestionTypes { get; set; }

    public virtual DbSet<QuestionsHasSection> QuestionsHasSections { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserHasResponse> UserHasResponses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ControlName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__control___3213E83F1B02EBB3");

            entity.ToTable("control_name", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NameOriginal)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name_original");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Type).WithMany(p => p.ControlNames)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__control_n__delet__656C112C");
        });

        modelBuilder.Entity<ControlType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__control___3213E83FC93CB3D1");

            entity.ToTable("control_type", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<Form>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__form__3213E83F6F8AD4E0");

            entity.ToTable("form", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("date_end");
            entity.Property(e => e.DatePublish)
                .HasColumnType("datetime")
                .HasColumnName("date_publish");
            entity.Property(e => e.DateStart)
                .HasColumnType("datetime")
                .HasColumnName("date_start");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Forms)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__form__deleted_by__10566F31");
        });

        modelBuilder.Entity<FormHasSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__form_has__3213E83F9A65E314");

            entity.ToTable("form_has_sections", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.FormId).HasColumnName("form_id");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Form).WithMany(p => p.FormHasSections)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__form_has___delet__151B244E");

            entity.HasOne(d => d.User).WithMany(p => p.FormHasSections)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__form_has___user___160F4887");
        });

        modelBuilder.Entity<GenericQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__generic___3213E83F4235EBAF");

            entity.ToTable("generic_question", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.ControlId).HasColumnName("control_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.SettingsId).HasColumnName("settings_id");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Control).WithMany(p => p.GenericQuestions)
                .HasForeignKey(d => d.ControlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__generic_q__delet__7C4F7684");

            entity.HasOne(d => d.Settings).WithMany(p => p.GenericQuestions)
                .HasForeignKey(d => d.SettingsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__generic_q__setti__7E37BEF6");

            entity.HasOne(d => d.Type).WithMany(p => p.GenericQuestions)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__generic_q__type___7D439ABD");
        });

        modelBuilder.Entity<GenericQuestionsHasGenericSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__generic___3213E83FD5684D45");

            entity.ToTable("generic_questions_has_generic_sections", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.SectionId).HasColumnName("section_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Question).WithMany(p => p.GenericQuestionsHasGenericSections)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__generic_q__delet__0A9D95DB");

            entity.HasOne(d => d.Section).WithMany(p => p.GenericQuestionsHasGenericSections)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__generic_q__secti__0B91BA14");
        });

        modelBuilder.Entity<GenericSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__generic___3213E83F0077A24C");

            entity.ToTable("generic_section", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.ControlId).HasColumnName("control_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Control).WithMany(p => p.GenericSections)
                .HasForeignKey(d => d.ControlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__generic_s__delet__70DDC3D8");
        });

        modelBuilder.Entity<ModelHasRol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__model_ha__3213E83F665F2679");

            entity.ToTable("model_has_rol", "auth");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.RolId).HasColumnName("rol_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Rol).WithMany(p => p.ModelHasRols)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__model_has__rol_i__5535A963");

            entity.HasOne(d => d.User).WithMany(p => p.ModelHasRols)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__model_has__delet__5441852A");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__question__3213E83F32ADF8F4");

            entity.ToTable("question", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.ControlId).HasColumnName("control_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.SettingsId).HasColumnName("settings_id");
            entity.Property(e => e.TypeId).HasColumnName("type_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Control).WithMany(p => p.Questions)
                .HasForeignKey(d => d.ControlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__question__delete__75A278F5");

            entity.HasOne(d => d.Settings).WithMany(p => p.Questions)
                .HasForeignKey(d => d.SettingsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__question__settin__778AC167");

            entity.HasOne(d => d.Type).WithMany(p => p.Questions)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__question__type_i__76969D2E");
        });

        modelBuilder.Entity<QuestionSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__question__3213E83F7B0843AD");

            entity.ToTable("question_settings", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<QuestionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__question__3213E83F84AE0621");

            entity.ToTable("question_type", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Subtype)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("subtype");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<QuestionsHasSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__question__3213E83FAD516223");

            entity.ToTable("questions_has_sections", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.SectionId).HasColumnName("section_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Question).WithMany(p => p.QuestionsHasSections)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__questions__delet__03F0984C");

            entity.HasOne(d => d.Section).WithMany(p => p.QuestionsHasSections)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__questions__secti__04E4BC85");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__roles__3213E83FE42FC2E2");

            entity.ToTable("roles", "auth");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__section__3213E83F771541E6");

            entity.ToTable("section", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.ControlId).HasColumnName("control_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Mandatory).HasColumnName("mandatory");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");

            entity.HasOne(d => d.Control).WithMany(p => p.Sections)
                .HasForeignKey(d => d.ControlId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__section__deleted__6B24EA82");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83FB453B3D9");

            entity.ToTable("users", "auth");

            entity.HasIndex(e => e.Username, "UQ__users__F3DBC572D9E4D365").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserHasResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_has__3213E83FE27F4276");

            entity.ToTable("user_has_responses", "forms");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.DeletedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("deleted_by");
            entity.Property(e => e.FormId).HasColumnName("form_id");
            entity.Property(e => e.OrderList).HasColumnName("order_list");
            entity.Property(e => e.SectionId).HasColumnName("section_id");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
