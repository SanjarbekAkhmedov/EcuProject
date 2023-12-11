using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThreadWatch
{
    public uint UserId { get; set; }

    public uint ThreadId { get; set; }

    public byte EmailSubscribe { get; set; }
}
