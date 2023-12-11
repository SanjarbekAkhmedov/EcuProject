using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMgTranscodeQueue
{
    public uint TranscodeQueueId { get; set; }

    public byte[] QueueData { get; set; } = null!;

    public string? QueueState { get; set; }

    public uint QueueDate { get; set; }
}
