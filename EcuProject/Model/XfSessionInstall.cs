using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSessionInstall
{
    public byte[] SessionId { get; set; } = null!;

    public byte[] SessionData { get; set; } = null!;

    public uint ExpiryDate { get; set; }
}
