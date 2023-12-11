using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsTransferLog
{
    public uint TransferLogId { get; set; }

    public uint UserId { get; set; }

    public uint TransferDate { get; set; }

    public uint EventId { get; set; }

    public uint CurrencyId { get; set; }

    public decimal Amount { get; set; }

    public byte[]? Message { get; set; }
}
