using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class AppEcuTranstron
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Ecutype { get; set; }
}
