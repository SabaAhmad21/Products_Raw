  using System;
using System.Collections.Generic;

namespace RawMaterial.Models;

public partial class Material
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? Unit { get; set; }

    public string? Quantity { get; set; }

    public DateTime? Date { get; set; }
}
