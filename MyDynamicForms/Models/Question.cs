using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class Question
{
    public int Id { get; set; }

    public int ControlId { get; set; }

    public int TypeId { get; set; }

    public int SettingsId { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public virtual ControlName Control { get; set; } = null!;

    public virtual ICollection<QuestionsHasSection> QuestionsHasSections { get; set; } = new List<QuestionsHasSection>();

    public virtual QuestionSetting Settings { get; set; } = null!;

    public virtual QuestionType Type { get; set; } = null!;
}
