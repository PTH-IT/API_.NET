using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class FileBttl
{
    public long Mafile { get; set; }

    public string? NoiLuu { get; set; }

    public long? MaBt { get; set; }

    public string? TenFile { get; set; }

    public virtual BaiTap? MaBtNavigation { get; set; }
}
