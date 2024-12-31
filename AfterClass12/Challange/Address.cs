using System;
using System.Collections.Generic;

namespace AfterClass12.Models;

public partial class Address
{
    public int Id { get; set; }

    public string City { get; set; } = null!;

    public int Region { get; set; }

    public string Country { get; set; } = null!;
}
