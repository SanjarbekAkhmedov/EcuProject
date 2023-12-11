using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_ecu_abit")]
public partial class AppEcuAbit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
