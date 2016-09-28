using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.Cw.Disqus.Models;

namespace Orchard.Cw.Disqus.Drivers {
    public class DisqusPartDriver : ContentPartDriver<DisqusPart>
    {
        private readonly IOrchardServices _orchardServices;

        public DisqusPartDriver(IOrchardServices orchardServices)
        {
            _orchardServices = orchardServices;
        }

        protected override DriverResult Display(DisqusPart part, string displayType, dynamic shapeHelper)
        {
            if (part.Hide) {
                return null;
            }

            return ContentShape("Parts_Disqus", () => {
                return shapeHelper.Parts_Disqus(Shortname : _orchardServices.WorkContext.CurrentSite.As<DisqusSettingsPart>().Shortname);
            });
        }

        protected override DriverResult Editor(DisqusPart part, dynamic shapeHelper) {
            return ContentShape("Parts_Disqus_Edit",
                () => shapeHelper.EditorTemplate(TemplateName: "Parts.Disqus.Edit", Model: part, Prefix: Prefix));
        }

        protected override DriverResult Editor(DisqusPart part, IUpdateModel updater, dynamic shapeHelper) {
            if (updater != null) {
                updater.TryUpdateModel(part, Prefix, null, null);
            }

            return ContentShape("Parts_Disqus_Edit",
               () => shapeHelper.EditorTemplate(TemplateName: "Parts.Disqus.Edit", Model: part, Prefix: Prefix));
        }
    }
}
