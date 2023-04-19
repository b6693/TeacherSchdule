using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Group
{
    public int ClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public int SchoolId { get; set; }

    public int TopicId { get; set; }

    public virtual School School { get; set; } = null!;

    public virtual Topic Topic { get; set; } = null!;
}
