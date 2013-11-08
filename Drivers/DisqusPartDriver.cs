


namespace Orchard.Cw.Disqus.Drivers
{
    using Orchard.ContentManagement.Drivers;
    using Orchard.Cw.Disqus.Models;
    
    /// <summary>driver for breadcrumb part</summary>
    public class DisqusPartDriver : ContentPartDriver<DisqusPart>
    {
        /// <summary>The display.</summary>
        /// <param name="part">The part.</param>
        /// <param name="displayType">The display type.</param>
        /// <param name="shapeHelper">The shape helper.</param>
        /// <returns>The Orchard.ContentManagement.Drivers.DriverResult.</returns>
        protected override DriverResult Display(DisqusPart part, string displayType, dynamic shapeHelper)
        {
            return this.ContentShape("Parts_Disqus", () => shapeHelper.Parts_Disqus());
        }
    }
}
