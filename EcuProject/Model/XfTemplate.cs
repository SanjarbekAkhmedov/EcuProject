using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfTemplate
{
    public uint TemplateId { get; set; }

    public byte[] Type { get; set; } = null!;

    public byte[] Title { get; set; } = null!;

    public uint StyleId { get; set; }

    /// <summary>
    /// User-editable HTML and template syntax
    /// </summary>
    public string Template { get; set; } = null!;

    public byte[] TemplateParsed { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;

    public uint VersionId { get; set; }

    public string VersionString { get; set; } = null!;

    public uint LastEditDate { get; set; }
}
