using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsDonationLog
{
    public uint DonationLogId { get; set; }

    public uint UserId { get; set; }

    public uint DonationDate { get; set; }

    public uint DonationUserId { get; set; }

    public uint EventId { get; set; }

    public uint CurrencyId { get; set; }

    public decimal Amount { get; set; }

    public byte[]? Message { get; set; }
}
