using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_ecu_transtron")]
public partial class AppEcuTranstron : BaseEntity
{

    public string? Ecutype { get; set; }
}
