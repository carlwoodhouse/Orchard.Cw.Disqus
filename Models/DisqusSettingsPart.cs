using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard.Cw.Disqus.Models
{
    public class DisqusSettingsPart : ContentPart
    {
        [DisplayName("Your disqus shortname")]
        public string Shortname { get; set; }
    }
}
