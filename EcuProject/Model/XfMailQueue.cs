using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMailQueue
{
    public uint MailQueueId { get; set; }

    public byte[] MailData { get; set; } = null!;

    public uint QueueDate { get; set; }

    public uint SendDate { get; set; }

    public uint? FailDate { get; set; }

    public uint FailCount { get; set; }
}
