using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSpamTriggerLog
{
    public uint TriggerLogId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint? ContentId { get; set; }

    public uint LogDate { get; set; }

    public uint UserId { get; set; }

    public byte[] IpAddress { get; set; } = null!;

    public byte[] Result { get; set; } = null!;

    public byte[] Details { get; set; } = null!;

    public byte[] RequestState { get; set; } = null!;
}
