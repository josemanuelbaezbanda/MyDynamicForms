using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class QuestionSetting
{
    public int Id { get; set; }

    public string Settings { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public virtual ICollection<GenericQuestion> GenericQuestions { get; set; } = new List<GenericQuestion>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
