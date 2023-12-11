using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcuProject.Model;

[Table("app_carmaker")]
public partial class AppCarmaker
{
    public int Id { get; set; }

    public string? Name { get; set; }
}
