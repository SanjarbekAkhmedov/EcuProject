using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserAuthenticate
{
    public uint UserId { get; set; }

    public string SchemeClass { get; set; } = null!;

    public byte[] Data { get; set; } = null!;
}
