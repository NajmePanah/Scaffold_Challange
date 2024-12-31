using System;
using System.Collections.Generic;

namespace AfterClass12.Models;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;
}
