using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfErrorLog
{
    public uint ErrorId { get; set; }

    public uint ExceptionDate { get; set; }

    public uint? UserId { get; set; }

    public byte[] IpAddress { get; set; } = null!;

    public string ExceptionType { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public uint Line { get; set; }

    public string TraceString { get; set; } = null!;

    public byte[] RequestState { get; set; } = null!;
}
