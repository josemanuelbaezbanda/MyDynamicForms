using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class ModelHasRol
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int RolId { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public virtual Role Rol { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
