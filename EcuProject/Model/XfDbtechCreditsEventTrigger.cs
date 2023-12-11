using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDbtechCreditsEventTrigger
{
    public string EventTriggerId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public byte[]? Description { get; set; }

    public byte Active { get; set; }

    public string CallbackClass { get; set; } = null!;

    public byte Multiplier { get; set; }

    public string MultiplierLabel { get; set; } = null!;

    public byte MultiplierPopup { get; set; }

    public string Parent { get; set; } = null!;

    public string Category { get; set; } = null!;

    public byte Global { get; set; }

    public byte Revert { get; set; }

    public byte Cancel { get; set; }

    public byte Rebuild { get; set; }

    public byte Charge { get; set; }

    public byte Usergroups { get; set; }

    public byte Currency { get; set; }

    public string Referformat { get; set; } = null!;

    public byte Outbound { get; set; }

    public byte Inbound { get; set; }

    public double Value { get; set; }

    public byte[]? Settings { get; set; }
}
