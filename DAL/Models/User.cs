using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string LoginName { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string? Phone { get; set; }

    public int ALevel { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
