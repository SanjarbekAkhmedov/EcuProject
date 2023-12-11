using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfCodeEventListener
{
    public uint EventListenerId { get; set; }

    public byte[] EventId { get; set; } = null!;

    public uint ExecuteOrder { get; set; }

    public string Description { get; set; } = null!;

    public string CallbackClass { get; set; } = null!;

    public string CallbackMethod { get; set; } = null!;

    public byte Active { get; set; }

    public byte[] AddonId { get; set; } = null!;

    public string Hint { get; set; } = null!;
}
