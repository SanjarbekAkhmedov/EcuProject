using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThreadRead
{
    public uint ThreadReadId { get; set; }

    public uint UserId { get; set; }

    public uint ThreadId { get; set; }

    public uint ThreadReadDate { get; set; }
}
