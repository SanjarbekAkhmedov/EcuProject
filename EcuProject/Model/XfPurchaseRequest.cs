using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPurchaseRequest
{
    public uint PurchaseRequestId { get; set; }

    public byte[] RequestKey { get; set; } = null!;

    public uint UserId { get; set; }

    public byte[] ProviderId { get; set; } = null!;

    public uint PaymentProfileId { get; set; }

    public string PurchasableTypeId { get; set; } = null!;

    public decimal CostAmount { get; set; }

    public string CostCurrency { get; set; } = null!;

    public byte[]? ExtraData { get; set; }

    public byte[]? ProviderMetadata { get; set; }
}
