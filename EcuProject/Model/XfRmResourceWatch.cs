using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmResourceWatch
{
    public uint UserId { get; set; }

    public uint ResourceId { get; set; }

    public byte EmailSubscribe { get; set; }
}
