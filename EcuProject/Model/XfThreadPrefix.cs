using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThreadPrefix
{
    public uint PrefixId { get; set; }

    public uint PrefixGroupId { get; set; }

    public uint DisplayOrder { get; set; }

    /// <summary>
    /// Internally-set order, based on prefix_group.display_order, prefix.display_order
    /// </summary>
    public uint MaterializedOrder { get; set; }

    public string CssClass { get; set; } = null!;

    public byte[] AllowedUserGroupIds { get; set; } = null!;
}
