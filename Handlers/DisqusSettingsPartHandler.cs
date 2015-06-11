using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard.Cw.Disqus.Handlers
{
    public class DisqusSettingsPartHandler : ContentHandler
    {
        public Localizer T { get; set; }

        public DisqusSettingsPartHandler()
        {
            this.T = NullLocalizer.Instance;
        }

        protected override void GetItemMetadata(GetContentItemMetadataContext context)
        {
            if (context.ContentItem.ContentType != "Site")
            {
                return;
            }

            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(this.T("Disqus")));
        }
    }
}
