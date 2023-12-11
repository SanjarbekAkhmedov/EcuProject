using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfEmailBounceLog
{
    public uint BounceId { get; set; }

    public uint LogDate { get; set; }

    public uint EmailDate { get; set; }

    public string MessageType { get; set; } = null!;

    public string ActionTaken { get; set; } = null!;

    public uint? UserId { get; set; }

    public string? Recipient { get; set; }

    public byte[] RawMessage { get; set; } = null!;

    public string? StatusCode { get; set; }

    public string? DiagnosticInfo { get; set; }
}
