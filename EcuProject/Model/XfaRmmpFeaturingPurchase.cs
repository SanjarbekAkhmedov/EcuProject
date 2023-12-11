using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpFeaturingPurchase
{
    public uint PurchaseId { get; set; }

    public uint ResourceId { get; set; }

    public uint TransactionId { get; set; }

    public string Status { get; set; } = null!;

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public decimal Price { get; set; }

    public string Currency { get; set; } = null!;

    public string Duration { get; set; } = null!;

    public uint PurchaseDate { get; set; }

    public byte Validated { get; set; }

    public uint ValidationDate { get; set; }

    public string RefundTxnId { get; set; } = null!;
}
