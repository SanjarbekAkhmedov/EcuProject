using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_ecu_type")]
public partial class AppEcuType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
