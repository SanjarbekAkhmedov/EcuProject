using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAdminNavigation
{
    public byte[] NavigationId { get; set; } = null!;

    public byte[] ParentNavigationId { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public string Link { get; set; } = null!;

    public string Icon { get; set; } = null!;

    public byte[] AdminPermissionId { get; set; } = null!;

    public byte DebugOnly { get; set; }

    public byte DevelopmentOnly { get; set; }

    public byte HideNoChildren { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
