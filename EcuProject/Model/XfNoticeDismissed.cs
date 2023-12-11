using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfNoticeDismissed
{
    public uint NoticeId { get; set; }

    public uint UserId { get; set; }

    public uint DismissDate { get; set; }
}
