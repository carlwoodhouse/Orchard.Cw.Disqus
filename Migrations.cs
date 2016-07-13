using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Cw.Disqus.Models;
using Orchard.Data.Migration;

namespace Orchard.Cw.Disqus {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            ContentDefinitionManager.AlterPartDefinition(typeof(DisqusPart).Name, cfg => cfg.Attachable());
            return 1;
        }
    }
}
