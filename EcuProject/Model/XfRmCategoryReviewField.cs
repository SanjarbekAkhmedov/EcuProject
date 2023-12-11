using System;
using System.Collections.Generic;

namespace EcuProject.Model;

public partial class XfRmCategoryReviewField
{
    public byte[] FieldId { get; set; } = null!;

    public uint ResourceCategoryId { get; set; }
}
