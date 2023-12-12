using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_ecu_trw")]
public partial class AppEcuTrw : BaseEntity
{

    public string? Ecutype { get; set; }
}
