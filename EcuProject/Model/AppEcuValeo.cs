using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_ecu_valeo")]
public partial class AppEcuValeo : BaseEntity
{

    public string? Ecutype { get; set; }
}
