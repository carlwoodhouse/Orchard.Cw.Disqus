using Orchard.ContentManagement.Drivers;
using Orchard.Cw.Disqus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard.Cw.Disqus.Drivers
{
    public class DisqusSettingsPartDriver : ContentPartDriver<DisqusSettingsPart>
    {
        protected override string Prefix
        {
            get { return "DisqusSettings"; }
        }

        protected override DriverResult Editor(DisqusSettingsPart part, dynamic shapeHelper)
        {
            return this.Editor(part, null, shapeHelper);
        }

        protected override DriverResult Editor(DisqusSettingsPart part, Orchard.ContentManagement.IUpdateModel updater, dynamic shapeHelper)
        {
            return ContentShape(
                "Parts_DisqusSettings",
                () =>
                {
                    if (updater != null)
                    {
                        updater.TryUpdateModel(part, Prefix, null, null);
                    }

                    return shapeHelper.EditorTemplate(
                        TemplateName: "DisqusSettings", Model: part, Prefix: Prefix);
                }).OnGroup("Disqus");
        }
    }
}
