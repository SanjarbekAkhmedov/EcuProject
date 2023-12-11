using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmResource
{
    public uint ResourceId { get; set; }

    public string Title { get; set; } = null!;

    public string TagLine { get; set; } = null!;

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public byte[] TeamMemberUserIds { get; set; } = null!;

    public string ResourceState { get; set; } = null!;

    public string ResourceType { get; set; } = null!;

    public uint ResourceDate { get; set; }

    public uint ResourceCategoryId { get; set; }

    public uint CurrentVersionId { get; set; }

    /// <summary>
    /// Points to the resource update that acts as the description for this resource
    /// </summary>
    public uint DescriptionUpdateId { get; set; }

    /// <summary>
    /// Points to an automatically-created thread for this resource
    /// </summary>
    public uint DiscussionThreadId { get; set; }

    public string ExternalUrl { get; set; } = null!;

    public string ExternalPurchaseUrl { get; set; } = null!;

    public decimal Price { get; set; }

    public string Currency { get; set; } = null!;

    public uint ViewCount { get; set; }

    public uint DownloadCount { get; set; }

    public uint RatingCount { get; set; }

    public uint RatingSum { get; set; }

    public float RatingAvg { get; set; }

    public float RatingWeighted { get; set; }

    public uint UpdateCount { get; set; }

    public uint ReviewCount { get; set; }

    public uint LastUpdate { get; set; }

    public string AltSupportUrl { get; set; } = null!;

    public byte[] CustomFields { get; set; } = null!;

    public uint PrefixId { get; set; }

    public byte[]? SvPrefixIds { get; set; }

    public uint IconDate { get; set; }

    public byte[] Tags { get; set; } = null!;

    public string XfaRmmpType { get; set; } = null!;

    public uint XfaRmmpMaxQty { get; set; }

    public decimal XfaRmmpAmount { get; set; }

    public decimal XfaRmmpBaseAmount { get; set; }

    public uint XfaRmmpDiscountId { get; set; }

    public string XfaRmmpCurrency { get; set; } = null!;

    public string XfaRmmpPaypal { get; set; } = null!;

    public byte XfaRmmpAcceptOther { get; set; }

    public uint XfaRmmpPurchases { get; set; }

    public string? XfaRmmpCgv { get; set; }

    public uint XfaRmmpImgDate { get; set; }

    public byte XfaRmmpSalesDisabled { get; set; }
}
