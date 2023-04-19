using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public int UserId { get; set; }

    public virtual ICollection<Topic> Topics { get; set; } = new List<Topic>();

    public virtual User User { get; set; } = null!;
}
