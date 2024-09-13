﻿using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class ControlType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }

    public virtual ICollection<ControlName> ControlNames { get; set; } = new List<ControlName>();
}
