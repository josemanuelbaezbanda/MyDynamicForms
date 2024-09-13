using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public virtual ICollection<FormHasSection> FormHasSections { get; set; } = new List<FormHasSection>();

    public virtual ICollection<Form> Forms { get; set; } = new List<Form>();

    public virtual ICollection<ModelHasRol> ModelHasRols { get; set; } = new List<ModelHasRol>();
}
