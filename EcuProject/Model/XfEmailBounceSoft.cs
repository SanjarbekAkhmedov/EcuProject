using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfEmailBounceSoft
{
    public uint BounceSoftId { get; set; }

    public uint UserId { get; set; }

    public DateOnly BounceDate { get; set; }

    public ushort BounceTotal { get; set; }
}
