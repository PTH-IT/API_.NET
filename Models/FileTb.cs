using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class FileTb
{
    public long Mafile { get; set; }

    public string? NoiLuu { get; set; }

    public long? MaTb { get; set; }

    public string? TenFile { get; set; }

    public virtual ThongBao? MaTbNavigation { get; set; }
}
