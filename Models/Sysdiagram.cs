using System;
using System.Collections.Generic;

namespace API_.NET.Models;

public partial class Sysdiagram
{
    public int DiagramId { get; set; }

    public string Name { get; set; } = null!;

    public int PrincipalId { get; set; }

    public int? Version { get; set; }

    public byte[]? Definition { get; set; }
}
