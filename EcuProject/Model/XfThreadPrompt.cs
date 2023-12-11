using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfThreadPrompt
{
    public uint PromptId { get; set; }

    public uint PromptGroupId { get; set; }

    public uint DisplayOrder { get; set; }

    /// <summary>
    /// Internally-set order, based on prompt_group.display_order, prompt.display_order
    /// </summary>
    public uint MaterializedOrder { get; set; }
}
