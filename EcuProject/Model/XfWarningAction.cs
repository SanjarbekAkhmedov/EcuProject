using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfWarningAction
{
    public uint WarningActionId { get; set; }

    public ushort Points { get; set; }

    public byte[] Action { get; set; } = null!;

    public byte[] ActionLengthType { get; set; } = null!;

    public ushort ActionLength { get; set; }

    public byte[] ExtraUserGroupIds { get; set; } = null!;
}
