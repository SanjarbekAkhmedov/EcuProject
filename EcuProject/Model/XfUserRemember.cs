using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUserRemember
{
    public uint RememberId { get; set; }

    public uint UserId { get; set; }

    public byte[] RememberKey { get; set; } = null!;

    public uint StartDate { get; set; }

    public uint ExpiryDate { get; set; }
}
