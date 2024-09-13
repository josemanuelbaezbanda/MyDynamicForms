using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class FormHasSection
{
    public int Id { get; set; }

    public int FormId { get; set; }

    public int? UserId { get; set; }

    public string Response { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public virtual Form Form { get; set; } = null!;

    public virtual User? User { get; set; }
}
