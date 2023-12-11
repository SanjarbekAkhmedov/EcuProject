using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfHelpPage
{
    public byte[] PageId { get; set; } = null!;

    public string PageName { get; set; } = null!;

    public uint DisplayOrder { get; set; }

    public string CallbackClass { get; set; } = null!;

    public string CallbackMethod { get; set; } = null!;

    public byte AdvancedMode { get; set; }

    public byte Active { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
