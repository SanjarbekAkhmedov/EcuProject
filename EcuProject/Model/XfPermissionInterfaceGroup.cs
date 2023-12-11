using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPermissionInterfaceGroup
{
    public byte[] InterfaceGroupId { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte IsModerator { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
