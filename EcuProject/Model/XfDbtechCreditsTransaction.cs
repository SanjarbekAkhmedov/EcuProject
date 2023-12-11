using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsTransaction
{
    public ulong TransactionId { get; set; }

    public uint EventId { get; set; }

    public string EventTriggerId { get; set; } = null!;

    public uint UserId { get; set; }

    public uint Dateline { get; set; }

    public uint SourceUserId { get; set; }

    public decimal Amount { get; set; }

    public string TransactionState { get; set; } = null!;

    public string? ReferenceId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public uint NodeId { get; set; }

    public uint OwnerId { get; set; }

    public double Multiplier { get; set; }

    public uint CurrencyId { get; set; }

    public byte Negate { get; set; }

    public byte[]? Message { get; set; }

    public byte IsDisputed { get; set; }

    public decimal Balance { get; set; }
}
