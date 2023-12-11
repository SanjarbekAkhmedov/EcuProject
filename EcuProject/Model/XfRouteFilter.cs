using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRouteFilter
{
    public uint RouteFilterId { get; set; }

    public string Prefix { get; set; } = null!;

    public string FindRoute { get; set; } = null!;

    public string ReplaceRoute { get; set; } = null!;

    public byte Enabled { get; set; }

    public byte UrlToRouteOnly { get; set; }
}
