using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSessionActivity
{
    public uint UserId { get; set; }

    public byte[] UniqueKey { get; set; } = null!;

    public byte[] Ip { get; set; } = null!;

    public string ControllerName { get; set; } = null!;

    public string ControllerAction { get; set; } = null!;

    public string ViewState { get; set; } = null!;

    public byte[] Params { get; set; } = null!;

    public uint ViewDate { get; set; }

    public byte[] RobotKey { get; set; } = null!;
}
