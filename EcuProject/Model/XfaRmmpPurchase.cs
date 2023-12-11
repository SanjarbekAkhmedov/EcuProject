using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpPurchase
{
    public uint PurchaseId { get; set; }

    public uint ResourceId { get; set; }

    public uint LicenseId { get; set; }

    public uint Quantity { get; set; }

    public uint TransactionId { get; set; }

    public string Type { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string ShipmentStatus { get; set; } = null!;

    public string ShipmentData { get; set; } = null!;

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint ForUserId { get; set; }

    public string ForUsername { get; set; } = null!;

    public decimal Price { get; set; }

    public string Currency { get; set; } = null!;

    public uint PurchaseDate { get; set; }

    public uint ValidationDate { get; set; }
}
