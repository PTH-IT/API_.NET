using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class Chudetailieu
{
    public long Machude { get; set; }

    public string? Chude { get; set; }

    public virtual ICollection<Document> Documents { get; } = new List<Document>();

    public virtual ICollection<KeywordTailieu> KeywordTailieus { get; } = new List<KeywordTailieu>();

    public virtual ICollection<TtbaiTapTl> TtbaiTapTls { get; } = new List<TtbaiTapTl>();
}
