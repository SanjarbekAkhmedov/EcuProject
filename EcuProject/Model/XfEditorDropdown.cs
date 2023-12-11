using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfEditorDropdown
{
    public byte[] Cmd { get; set; } = null!;

    /// <summary>
    /// Optional icon
    /// </summary>
    public string Icon { get; set; } = null!;

    public byte[] Buttons { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public byte Active { get; set; }
}
