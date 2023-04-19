using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Topic
{
    public int TopicId { get; set; }

    public string TopicName { get; set; } = null!;

    public int SubjectId { get; set; }

    public int TeachingDurationTeachingDurationDurationDurationDuration { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual Subject Subject { get; set; } = null!;
}
