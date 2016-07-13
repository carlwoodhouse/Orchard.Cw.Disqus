using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;

namespace Orchard.Cw.Disqus.Models {
    public class DisqusSettingsPart : ContentPart {
        [Required, DisplayName("Your disqus shortname")]
        public string Shortname
        {
            get { return this.Retrieve(x => x.Shortname); }
            set { this.Store(x => x.Shortname, value); }
        }
    }
}
