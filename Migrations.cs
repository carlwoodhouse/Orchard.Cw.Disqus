
namespace Orchard.Cw.Disqus
{
    using Orchard.ContentManagement.MetaData;
    using Orchard.Core.Contents.Extensions;
    using Orchard.Data.Migration;

    using Orchard.Cw.Disqus.Models;

    /// <summary>migration for breadcrumbs</summary>
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            ContentDefinitionManager.AlterPartDefinition(
                typeof(DisqusPart).Name, cfg => cfg.Attachable());

            return 1;
        }
    }
}
