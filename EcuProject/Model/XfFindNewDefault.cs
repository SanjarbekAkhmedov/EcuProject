using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfFindNewDefault
{
    public uint FindNewDefaultId { get; set; }

    public uint UserId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public byte[] Filters { get; set; } = null!;
}
