using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsCurrency
{
    public uint CurrencyId { get; set; }

    public string Title { get; set; } = null!;

    public byte[]? Description { get; set; }

    public byte Active { get; set; }

    public uint DisplayOrder { get; set; }

    public string Table { get; set; } = null!;

    public byte UseTablePrefix { get; set; }

    public string Column { get; set; } = null!;

    public byte UseUserId { get; set; }

    public string UserIdColumn { get; set; } = null!;

    public byte Decimals { get; set; }

    public byte Privacy { get; set; }

    public byte Blacklist { get; set; }

    public string Prefix { get; set; } = null!;

    public string Suffix { get; set; } = null!;

    public byte Negative { get; set; }

    public uint Maxtime { get; set; }

    public double Earnmax { get; set; }

    public double Value { get; set; }

    public byte Inbound { get; set; }

    public byte Outbound { get; set; }

    public byte IsDisplayCurrency { get; set; }

    public byte ShowAmounts { get; set; }

    public byte Sidebar { get; set; }

    public byte Postbit { get; set; }

    public byte MemberDropdown { get; set; }
}
