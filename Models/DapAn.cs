using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class DapAn
{
    public long MaDapAn { get; set; }

    public string? NoiDung { get; set; }

    public bool? LoaiDapAn { get; set; }

    public long? MaCauHoi { get; set; }

    public virtual CauHoi? MaCauHoiNavigation { get; set; }

    public virtual ICollection<TtbaiTapTn> TtbaiTapTns { get; } = new List<TtbaiTapTn>();
}
