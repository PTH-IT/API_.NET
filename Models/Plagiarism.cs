using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class Plagiarism
{
    public long Ma { get; set; }

    public double? Percents { get; set; }

    public long? Mafile { get; set; }

    public string? Location { get; set; }

    public string? Loaikiemtra { get; set; }

    public virtual TtbaiTapTl? MafileNavigation { get; set; }
}
