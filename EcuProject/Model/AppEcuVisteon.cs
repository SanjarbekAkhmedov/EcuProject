using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_ecu_visteon")]
public partial class AppEcuVisteon : BaseEntity
{
    public string? Ecutype { get; set; }
}
