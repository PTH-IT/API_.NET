using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class Commentbaitap
{
    public long Ma { get; set; }

    public long? MaBaiTap { get; set; }

    public string? Nguoidang { get; set; }

    public string? Noidung { get; set; }

    public DateTime? Thoigiandang { get; set; }

    public virtual BaiTap? MaBaiTapNavigation { get; set; }

    public virtual TaiKhoan? NguoidangNavigation { get; set; }

    public virtual ICollection<ReplycommentBt> ReplycommentBts { get; } = new List<ReplycommentBt>();
}
