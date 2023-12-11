using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsAdjustLog
{
    public uint AdjustLogId { get; set; }

    public uint UserId { get; set; }

    public uint AdjustDate { get; set; }

    public uint AdjustUserId { get; set; }

    public uint EventId { get; set; }

    public uint CurrencyId { get; set; }

    public decimal Amount { get; set; }

    public byte[]? Message { get; set; }
}
