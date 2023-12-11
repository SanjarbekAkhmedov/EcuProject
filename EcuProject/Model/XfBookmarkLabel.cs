using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfBookmarkLabel
{
    public uint LabelId { get; set; }

    public string Label { get; set; } = null!;

    public string LabelUrl { get; set; } = null!;

    public uint UserId { get; set; }

    public uint UseCount { get; set; }

    public uint LastUseDate { get; set; }
}
