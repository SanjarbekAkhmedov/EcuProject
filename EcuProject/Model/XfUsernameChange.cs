using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfUsernameChange
{
    public uint ChangeId { get; set; }

    public uint UserId { get; set; }

    public string OldUsername { get; set; } = null!;

    public string NewUsername { get; set; } = null!;

    public string ChangeReason { get; set; } = null!;

    public string ChangeState { get; set; } = null!;

    public uint ChangeUserId { get; set; }

    public uint ChangeDate { get; set; }

    public uint ModeratorUserId { get; set; }

    public string RejectReason { get; set; } = null!;

    public byte Visible { get; set; }
}
