using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_ecu_producer")]
public partial class AppEcuProducer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Table { get; set; }
}
