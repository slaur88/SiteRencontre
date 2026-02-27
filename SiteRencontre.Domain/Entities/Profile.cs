using SiteRencontre.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteRencontre.Domain.Entities;

internal class Profile
{
    public int Id { get; set; }

    public string Pseudo { get; set; } = null!;

    public Sexe sexe { get; set; }

    public ICollection<Photo> Photos { get; set; }

    public DateOnly Birthdate {  get; set; }

    public string? Pays { get; set; }

    public string? Ville { get; set; }

    public string? Bio { get; set; }

    public Orientation orientation { get; set; }

}