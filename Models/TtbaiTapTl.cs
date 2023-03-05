using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class TtbaiTapTl
{
    public long Ma { get; set; }

    public string? NoiLuu { get; set; }

    public DateTime? NgayNop { get; set; }

    public long? MaBaiNop { get; set; }

    public string? NguoiNop { get; set; }

    public string? Tenfile { get; set; }

    public bool? Isplagiarism { get; set; }

    public string? Datafile { get; set; }

    public long? Machude { get; set; }

    public virtual BaiTapTl? MaBaiNopNavigation { get; set; }

    public virtual Chudetailieu? MachudeNavigation { get; set; }

    public virtual TaiKhoan? NguoiNopNavigation { get; set; }

    public virtual ICollection<Plagiarism> Plagiarisms { get; } = new List<Plagiarism>();
}
