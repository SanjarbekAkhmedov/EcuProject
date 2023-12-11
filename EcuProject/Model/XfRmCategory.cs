using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmCategory
{
    public uint ResourceCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public uint ParentCategoryId { get; set; }

    public uint DisplayOrder { get; set; }

    public uint Lft { get; set; }

    public uint Rgt { get; set; }

    public ushort Depth { get; set; }

    public byte[] BreadcrumbData { get; set; } = null!;

    public uint ResourceCount { get; set; }

    public ushort FeaturedCount { get; set; }

    public uint LastUpdate { get; set; }

    public string LastResourceTitle { get; set; } = null!;

    public uint LastResourceId { get; set; }

    public byte[] FieldCache { get; set; } = null!;

    public byte[] ReviewFieldCache { get; set; } = null!;

    public byte[] PrefixCache { get; set; } = null!;

    public byte RequirePrefix { get; set; }

    public uint ThreadNodeId { get; set; }

    public uint ThreadPrefixId { get; set; }

    public byte AllowLocal { get; set; }

    public byte AllowExternal { get; set; }

    public byte AllowCommercialExternal { get; set; }

    public byte AllowFileless { get; set; }

    public byte AlwaysModerateCreate { get; set; }

    public byte AlwaysModerateUpdate { get; set; }

    public ushort MinTags { get; set; }

    public byte EnableVersioning { get; set; }

    public byte EnableSupportUrl { get; set; }

    public byte XfaRmmpConf { get; set; }

    public string XfaRmmpTypes { get; set; } = null!;

    public string XfaRmmpPaymentData { get; set; } = null!;

    public decimal XfaRmmpSalePercentage { get; set; }

    public string XfaRmmpSalePercentagePaypal { get; set; } = null!;

    public byte XfaRmmpAltDisplay { get; set; }

    public byte XfaRmmpRestrictSupport { get; set; }

    public uint SvMinPrefixes { get; set; }

    public uint SvMaxPrefixes { get; set; }

    public byte[]? SvThreadPrefixIds { get; set; }
}
