using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfActivitySummaryDefinition
{
    public byte[] DefinitionId { get; set; } = null!;

    public string DefinitionClass { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;
}
