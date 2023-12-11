using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPermission
{
    public byte[] PermissionId { get; set; } = null!;

    public byte[] PermissionGroupId { get; set; } = null!;

    public string PermissionType { get; set; } = null!;

    public byte[] InterfaceGroupId { get; set; } = null!;

    public byte[] DependPermissionId { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
