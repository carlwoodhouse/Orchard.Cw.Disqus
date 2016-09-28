using Orchard.ContentManagement;

namespace Orchard.Cw.Disqus.Models {
    public class DisqusPart : ContentPart {
        public bool Hide
        {
            get
            {
                return this.Retrieve(x => Hide);
            }
            set
            {
                this.Store(x => Hide, value);
            }
        }
    }
}
