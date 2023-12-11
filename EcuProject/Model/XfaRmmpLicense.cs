using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfaRmmpLicense
{
    public uint LicenseId { get; set; }

    public uint ResourceId { get; set; }

    public uint PurchaseId { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public byte Validated { get; set; }

    public byte Active { get; set; }

    public string Siteurl { get; set; } = null!;

    public uint StartDate { get; set; }

    public uint EndDate { get; set; }

    public uint PreviousEndDate { get; set; }

    public byte ExpirationSent { get; set; }

    public string? LicKey { get; set; }
}
