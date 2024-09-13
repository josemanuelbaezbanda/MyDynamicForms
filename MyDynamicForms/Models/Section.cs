using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class Section
{
    public int Id { get; set; }

    public int ControlId { get; set; }

    public bool Mandatory { get; set; }

    public string Description { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public virtual ControlName Control { get; set; } = null!;

    public virtual ICollection<QuestionsHasSection> QuestionsHasSections { get; set; } = new List<QuestionsHasSection>();
}
