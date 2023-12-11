using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfOption
{
    public byte[] OptionId { get; set; } = null!;

    public byte[] OptionValue { get; set; } = null!;

    public byte[] DefaultValue { get; set; } = null!;

    public string EditFormat { get; set; } = null!;

    public string EditFormatParams { get; set; } = null!;

    public string SubOptions { get; set; } = null!;

    public string ValidationClass { get; set; } = null!;

    public string ValidationMethod { get; set; } = null!;

    public byte Advanced { get; set; }

    public byte[] AddonId { get; set; } = null!;
}
