using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfDataRegistry
{
    public byte[] DataKey { get; set; } = null!;

    public byte[] DataValue { get; set; } = null!;
}
