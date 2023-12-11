using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfPaymentProviderLog
{
    public uint ProviderLogId { get; set; }

    public byte[]? PurchaseRequestKey { get; set; }

    public byte[] ProviderId { get; set; } = null!;

    public string? TransactionId { get; set; }

    public string? SubscriberId { get; set; }

    public string LogType { get; set; } = null!;

    public string LogMessage { get; set; } = null!;

    public byte[] LogDetails { get; set; } = null!;

    public uint LogDate { get; set; }
}
