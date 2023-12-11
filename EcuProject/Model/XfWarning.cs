using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfWarning
{
    public uint WarningId { get; set; }

    public byte[] ContentType { get; set; } = null!;

    public uint ContentId { get; set; }

    public string ContentTitle { get; set; } = null!;

    public uint UserId { get; set; }

    public uint WarningDate { get; set; }

    public uint WarningUserId { get; set; }

    public uint WarningDefinitionId { get; set; }

    public string Title { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public ushort Points { get; set; }

    public uint ExpiryDate { get; set; }

    public byte IsExpired { get; set; }

    public byte[] ExtraUserGroupIds { get; set; } = null!;
}
