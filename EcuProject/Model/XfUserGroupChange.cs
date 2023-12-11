using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserGroupChange
{
    public uint UserId { get; set; }

    public byte[] ChangeKey { get; set; } = null!;

    public byte[] GroupIds { get; set; } = null!;
}
