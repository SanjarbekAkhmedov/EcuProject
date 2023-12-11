using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfAddon
{
    public byte[] AddonId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string VersionString { get; set; } = null!;

    public uint VersionId { get; set; }

    public byte[] JsonHash { get; set; } = null!;

    public byte Active { get; set; }

    public byte IsLegacy { get; set; }

    public byte IsProcessing { get; set; }

    public string? LastPendingAction { get; set; }
}
