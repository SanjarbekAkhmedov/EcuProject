using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSiropuReferralContestsReferralTool
{
    public uint ToolId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string Size { get; set; } = null!;

    public string TargetUrl { get; set; } = null!;

    public uint ClickCount { get; set; }

    public byte Enabled { get; set; }
}
