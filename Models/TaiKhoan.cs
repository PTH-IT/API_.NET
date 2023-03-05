using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class TaiKhoan
{
    public string TenDangNhap { get; set; } = null!;

    public string? MatKhau { get; set; }

    public string? Email { get; set; }

    public string? Ho { get; set; }

    public string? Ten { get; set; }

    public string? HinhAnh { get; set; }

    public string? Token { get; set; }

    public string? ChucVu { get; set; }

    public virtual ICollection<BaiTapTl> BaiTapTls { get; } = new List<BaiTapTl>();

    public virtual ICollection<BaiTapTn> BaiTapTns { get; } = new List<BaiTapTn>();

    public virtual ICollection<Commentbaitap> Commentbaitaps { get; } = new List<Commentbaitap>();

    public virtual ICollection<Commentnotification> Commentnotifications { get; } = new List<Commentnotification>();

    public virtual ICollection<Document> Documents { get; } = new List<Document>();

    public virtual ICollection<Loimoi> Loimois { get; } = new List<Loimoi>();

    public virtual ICollection<LopHoc> LopHocs { get; } = new List<LopHoc>();

    public virtual ICollection<Mess> MessNguoiGuiNavigations { get; } = new List<Mess>();

    public virtual ICollection<Mess> MessNguoiNhanNavigations { get; } = new List<Mess>();

    public virtual ICollection<ReplycommentBt> ReplycommentBts { get; } = new List<ReplycommentBt>();

    public virtual ICollection<Replycomment> Replycomments { get; } = new List<Replycomment>();

    public virtual ICollection<ThanhVienLop> ThanhVienLops { get; } = new List<ThanhVienLop>();

    public virtual ICollection<ThongBao> ThongBaos { get; } = new List<ThongBao>();

    public virtual ICollection<TtbaiTapTl> TtbaiTapTls { get; } = new List<TtbaiTapTl>();

    public virtual ICollection<TtbaiTapTn> TtbaiTapTns { get; } = new List<TtbaiTapTn>();
}
