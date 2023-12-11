using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRoute
{
    public uint RouteId { get; set; }

    public byte[] RouteType { get; set; } = null!;

    public byte[] RoutePrefix { get; set; } = null!;

    public byte[] SubName { get; set; } = null!;

    public string Format { get; set; } = null!;

    public string BuildClass { get; set; } = null!;

    public byte[] BuildMethod { get; set; } = null!;

    public byte[] Controller { get; set; } = null!;

    public byte[] Context { get; set; } = null!;

    public byte[] ActionPrefix { get; set; } = null!;

    public byte[] AddonId { get; set; } = null!;
}
