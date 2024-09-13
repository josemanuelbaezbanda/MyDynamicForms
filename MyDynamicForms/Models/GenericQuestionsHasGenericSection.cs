using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class GenericQuestionsHasGenericSection
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public int SectionId { get; set; }

    public bool Mandatory { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public virtual GenericQuestion Question { get; set; } = null!;

    public virtual GenericSection Section { get; set; } = null!;
}
