using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class KeywordTailieu
{
    public long MaKeyword { get; set; }

    public string? Keyword { get; set; }

    public long? Machude { get; set; }

    public virtual Chudetailieu? MachudeNavigation { get; set; }
}
