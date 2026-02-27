using System;
using System.Collections.Generic;
using System.Text;

namespace SiteRencontre.Domain.Entities
{
    internal class Photo
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        // Stockage des données binaires
        public byte[] Image { get; set; }
    }
}
