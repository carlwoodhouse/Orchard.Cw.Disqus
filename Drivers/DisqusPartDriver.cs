using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;
using Orchard.Cw.Disqus.Models;

namespace Orchard.Cw.Disqus.Drivers
{
    public class DisqusPartDriver : ContentPartDriver<DisqusPart>
    {
        private readonly IOrchardServices orchardServices;

        public DisqusPartDriver(IOrchardServices orchardServices)
        {
            this.orchardServices = orchardServices;
        }

        protected override DriverResult Display(DisqusPart part, string displayType, dynamic shapeHelper)
        {
            return this.ContentShape("Parts_Disqus", () => {
                var settings = this.orchardServices.WorkContext.CurrentSite.As<DisqusSettingsPart>();
                return shapeHelper.Parts_Disqus(Shortname : settings.Shortname);
            });
        }
    }
}
