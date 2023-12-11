using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserUpgradeExpired
{
    public uint UserUpgradeRecordId { get; set; }

    public uint UserId { get; set; }

    public byte[]? PurchaseRequestKey { get; set; }

    public uint UserUpgradeId { get; set; }

    public byte[] Extra { get; set; } = null!;

    public uint StartDate { get; set; }

    public uint EndDate { get; set; }

    public uint OriginalEndDate { get; set; }
}
