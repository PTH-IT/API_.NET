using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class Commentnotification
{
    public long Ma { get; set; }

    public long? MaThongbao { get; set; }

    public string? Nguoidang { get; set; }

    public string? Noidung { get; set; }

    public DateTime? Thoigiandang { get; set; }

    public virtual ThongBao? MaThongbaoNavigation { get; set; }

    public virtual TaiKhoan? NguoidangNavigation { get; set; }

    public virtual ICollection<Replycomment> Replycomments { get; } = new List<Replycomment>();
}
