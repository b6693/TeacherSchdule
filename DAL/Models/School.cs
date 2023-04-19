using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class School
{
    public int SchoolId { get; set; }

    public string SchoolName { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
