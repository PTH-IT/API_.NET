using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class ThongBao
{
    public long MaBaiDang { get; set; }

    public string? NguoiDang { get; set; }

    public long? MaLop { get; set; }

    public DateTime? NgayDang { get; set; }

    public string? Thongtin { get; set; }

    public string? LoaiThongBao { get; set; }

    public long? MaBaiTap { get; set; }

    public virtual ICollection<Commentnotification> Commentnotifications { get; } = new List<Commentnotification>();

    public virtual ICollection<FileTb> FileTbs { get; } = new List<FileTb>();

    public virtual BaiTap? MaBaiTapNavigation { get; set; }

    public virtual LopHoc? MaLopNavigation { get; set; }

    public virtual TaiKhoan? NguoiDangNavigation { get; set; }
}
