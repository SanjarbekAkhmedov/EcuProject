using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfWidget
{
    public uint WidgetId { get; set; }

    public byte[] WidgetKey { get; set; } = null!;

    public byte[] DefinitionId { get; set; } = null!;

    public byte[] Positions { get; set; } = null!;

    public byte[] Options { get; set; } = null!;

    public string DisplayCondition { get; set; } = null!;

    public byte[] ConditionExpression { get; set; } = null!;
}
