using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfCronEntry
{
    public byte[] EntryId { get; set; } = null!;

    public string CronClass { get; set; } = null!;

    public string CronMethod { get; set; } = null!;

    public byte[] RunRules { get; set; } = null!;

    public byte Active { get; set; }

    public uint NextRun { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
