using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfNodeType
{
    public byte[] NodeTypeId { get; set; } = null!;

    public string EntityIdentifier { get; set; } = null!;

    public string PermissionGroupId { get; set; } = null!;

    public string AdminRoute { get; set; } = null!;

    public string PublicRoute { get; set; } = null!;

    public string HandlerClass { get; set; } = null!;
}
