using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class Replycomment
{
    public long Ma { get; set; }

    public long? Macomment { get; set; }

    public string? Nguoidang { get; set; }

    public string? Noidung { get; set; }

    public DateTime? Thoigiandang { get; set; }

    public virtual Commentnotification? MacommentNavigation { get; set; }

    public virtual TaiKhoan? NguoidangNavigation { get; set; }
}
