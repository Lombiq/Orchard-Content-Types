using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Environment.Extensions;

namespace Piedone.ContentTypes
{
    [OrchardFeature("Piedone.ContentTypes.HierarchicalPages")]
    public class HierarchicalPagesMigrations : DataMigrationImpl
    {
        public int Create()
        {
            ContentDefinitionManager.AlterTypeDefinition("HierarchicalPage",
                cfg => cfg
                .WithPart("CommonPart", p => p
                    .WithSetting("DateEditorSettings.ShowDateEditor", "true"))
                .WithPart("PublishLaterPart")
                .WithPart("TitlePart")
                .WithPart("AutoroutePart", builder => builder
                    .WithSetting("AutorouteSettings.AllowCustomPattern", "true")
                    .WithSetting("AutorouteSettings.AutomaticAdjustmentOnEdit", "false")
                    .WithSetting("AutorouteSettings.PatternDefinitions", "[{Name:'Parent and Title', Pattern: '{Content.Container.Path}/{Content.Slug}', Description: 'my-parent/my-page'}]")
                    .WithSetting("AutorouteSettings.DefaultPatternIndex", "0"))
                .WithPart("ContainerPart")
                .WithPart("ContainablePart")
                .WithPart("BodyPart")
                .Creatable()
                .Draftable());

            return 1;
        }
    }
}