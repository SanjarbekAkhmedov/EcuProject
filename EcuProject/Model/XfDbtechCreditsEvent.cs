using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsEvent
{
    public uint EventId { get; set; }

    public string Title { get; set; } = null!;

    public byte Active { get; set; }

    public uint CurrencyId { get; set; }

    public string EventTriggerId { get; set; } = null!;

    public byte[]? UserGroupIds { get; set; }

    public byte[]? NodeIds { get; set; }

    public byte Moderate { get; set; }

    public byte Charge { get; set; }

    public double MainAdd { get; set; }

    public double MainSub { get; set; }

    public double MultAdd { get; set; }

    public double MultSub { get; set; }

    public uint Delay { get; set; }

    public uint Frequency { get; set; }

    public uint Maxtime { get; set; }

    public uint Applymax { get; set; }

    public byte ApplymaxPeruser { get; set; }

    public double Upperrand { get; set; }

    public double Multmin { get; set; }

    public double Multmax { get; set; }

    public byte Minaction { get; set; }

    public byte Owner { get; set; }

    public byte Curtarget { get; set; }

    public byte Alert { get; set; }

    public byte Display { get; set; }

    public byte[]? Settings { get; set; }
}
