using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfWarningDefinition
{
    public uint WarningDefinitionId { get; set; }

    public ushort PointsDefault { get; set; }

    public string ExpiryType { get; set; } = null!;

    public ushort ExpiryDefault { get; set; }

    public byte[] ExtraUserGroupIds { get; set; } = null!;

    public byte IsEditable { get; set; }
}
