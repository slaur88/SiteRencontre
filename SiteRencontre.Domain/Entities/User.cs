using SiteRencontre.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteRencontre.Domain.Entities;


internal class User
{
    public Guid Id { get; set; }
    public string Email { get; set; } = null!;
    public string password { get; set; } = null!;

    public UserRole Role { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;
}
