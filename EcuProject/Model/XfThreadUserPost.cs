using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThreadUserPost
{
    public uint ThreadId { get; set; }

    public uint UserId { get; set; }

    public uint PostCount { get; set; }
}
