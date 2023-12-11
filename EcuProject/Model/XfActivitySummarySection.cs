using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfActivitySummarySection
{
    public uint SectionId { get; set; }

    public byte[] DefinitionId { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte ShowValue { get; set; }

    public byte[] Options { get; set; } = null!;

    public byte Active { get; set; }
}
