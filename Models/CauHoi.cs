using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class CauHoi
{
    public long MaCauHoi { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? NgayThem { get; set; }

    public long? MaBaiTap { get; set; }

    public virtual ICollection<DapAn> DapAns { get; } = new List<DapAn>();

    public virtual BaiTap? MaBaiTapNavigation { get; set; }

    public virtual ICollection<TtbaiTapTn> TtbaiTapTns { get; } = new List<TtbaiTapTn>();
}
