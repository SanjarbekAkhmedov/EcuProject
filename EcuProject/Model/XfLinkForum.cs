using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfLinkForum
{
    public uint NodeId { get; set; }

    public string LinkUrl { get; set; } = null!;

    public uint RedirectCount { get; set; }
}
