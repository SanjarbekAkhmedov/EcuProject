using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfFileCheck
{
    public uint CheckId { get; set; }

    public uint CheckDate { get; set; }

    public string CheckState { get; set; } = null!;

    public byte[] CheckHash { get; set; } = null!;

    public uint TotalMissing { get; set; }

    public uint TotalInconsistent { get; set; }

    public uint TotalChecked { get; set; }
}
