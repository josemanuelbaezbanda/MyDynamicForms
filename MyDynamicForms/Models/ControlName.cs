using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class ControlName
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string NameOriginal { get; set; } = null!;

    public int TypeId { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public virtual ICollection<GenericQuestion> GenericQuestions { get; set; } = new List<GenericQuestion>();

    public virtual ICollection<GenericSection> GenericSections { get; set; } = new List<GenericSection>();

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();

    public virtual ControlType Type { get; set; } = null!;
}
