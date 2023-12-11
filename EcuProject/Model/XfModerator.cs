using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfModerator
{
    public uint UserId { get; set; }

    public byte IsSuperModerator { get; set; }

    public byte[] ExtraUserGroupIds { get; set; } = null!;
}
