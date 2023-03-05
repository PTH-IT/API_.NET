using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class ReplycommentBt
{
    public long Ma { get; set; }

    public long? MaComment { get; set; }

    public string? Nguoidang { get; set; }

    public string? Noidung { get; set; }

    public DateTime? Thoigiandang { get; set; }

    public virtual Commentbaitap? MaCommentNavigation { get; set; }

    public virtual TaiKhoan? NguoidangNavigation { get; set; }
}
