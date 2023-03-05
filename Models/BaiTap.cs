using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class BaiTap
{
    public long MaBaiTap { get; set; }

    public string? ChuDe { get; set; }

    public string? LoaiBaiTap { get; set; }

    public DateTime? ThoiGianDang { get; set; }

    public DateTime? ThoiGianKetThuc { get; set; }

    public long? MaLop { get; set; }

    public string? NguoiTao { get; set; }

    public string? Thongtin { get; set; }

    public virtual ICollection<BaiTapTl> BaiTapTls { get; } = new List<BaiTapTl>();

    public virtual ICollection<BaiTapTn> BaiTapTns { get; } = new List<BaiTapTn>();

    public virtual ICollection<CauHoi> CauHois { get; } = new List<CauHoi>();

    public virtual ICollection<Commentbaitap> Commentbaitaps { get; } = new List<Commentbaitap>();

    public virtual ICollection<FileBttl> FileBttls { get; } = new List<FileBttl>();

    public virtual LopHoc? MaLopNavigation { get; set; }

    public virtual ICollection<ThongBao> ThongBaos { get; } = new List<ThongBao>();
}
