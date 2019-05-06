using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dootrix.Planets.Data.SQL.Models
{
    internal class ExtraInformation
    {
        public int ExtraInformationId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int PlanetId { get; set; }
        public virtual Planet Planet { get; set; }
    }
}
