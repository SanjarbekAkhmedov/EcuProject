using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserPushSubscription
{
    public uint EndpointId { get; set; }

    public byte[] EndpointHash { get; set; } = null!;

    public string Endpoint { get; set; } = null!;

    public uint UserId { get; set; }

    public byte[]? Data { get; set; }

    public uint LastSeen { get; set; }

    public uint ErrorCount { get; set; }
}
