using System;
using System.Collections.Generic;

namespace UsingGeneratedDb;

public partial class Objective
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
