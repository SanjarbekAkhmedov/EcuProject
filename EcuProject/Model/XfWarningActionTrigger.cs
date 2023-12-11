using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfWarningActionTrigger
{
    public uint ActionTriggerId { get; set; }

    public uint WarningActionId { get; set; }

    public uint UserId { get; set; }

    public ushort TriggerPoints { get; set; }

    public uint ActionDate { get; set; }

    public byte[] Action { get; set; } = null!;

    public uint MinUnbanDate { get; set; }
}
