using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserTitleLadder
{
    public uint MinimumLevel { get; set; }

    public string Title { get; set; } = null!;
}
