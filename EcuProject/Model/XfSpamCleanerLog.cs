using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfSpamCleanerLog
{
    public uint SpamCleanerLogId { get; set; }

    public uint UserId { get; set; }

    public string Username { get; set; } = null!;

    public uint ApplyingUserId { get; set; }

    public string ApplyingUsername { get; set; } = null!;

    public uint ApplicationDate { get; set; }

    /// <summary>
    /// Serialized array containing log data for undo purposes
    /// </summary>
    public byte[] Data { get; set; } = null!;

    public uint RestoredDate { get; set; }
}
