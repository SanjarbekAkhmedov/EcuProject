using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThreadQuestion
{
    public uint ThreadId { get; set; }

    public uint SolutionPostId { get; set; }

    public uint SolutionUserId { get; set; }
}
