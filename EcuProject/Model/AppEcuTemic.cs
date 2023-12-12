using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_ecu_temic")]
public partial class AppEcuTemic : BaseEntity
{
    public string? Ecutype { get; set; }
}
