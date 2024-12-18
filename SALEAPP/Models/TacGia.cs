using System;
using System.Collections.Generic;

namespace SALEAPP.Models;

public partial class TacGia
{
    public string MaTg { get; set; } = null!;

    public string? TenTg { get; set; }

    public virtual ICollection<Sach> MaSaches { get; set; } = new List<Sach>();
}
