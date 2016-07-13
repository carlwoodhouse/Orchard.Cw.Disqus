using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Cw.Disqus.Models;
using Orchard.Localization;

namespace Orchard.Cw.Disqus.Handlers {
    public class DisqusSettingsPartHandler : ContentHandler {
        public Localizer T { get; set; }

        public DisqusSettingsPartHandler() {
            Filters.Add(new ActivatingFilter<DisqusSettingsPart>("Site"));
            T = NullLocalizer.Instance;
        }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site") {
                return;
            }

            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Disqus")));
        }
    }
}
