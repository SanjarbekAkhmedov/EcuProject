using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfMadUserEvercookie
{
    public uint EvercookieId { get; set; }

    public byte[] Evercookie { get; set; } = null!;

    public uint UserId { get; set; }

    public uint EvercookieDate { get; set; }
}
