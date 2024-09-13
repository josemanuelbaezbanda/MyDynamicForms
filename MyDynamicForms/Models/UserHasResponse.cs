using System;
using System.Collections.Generic;

namespace MyDynamicForms.Models;

public partial class UserHasResponse
{
    public int Id { get; set; }

    public int FormId { get; set; }

    public int SectionId { get; set; }

    public int OrderList { get; set; }

    public bool Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? DeletedBy { get; set; }
}
