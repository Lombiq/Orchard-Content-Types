using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Environment.Extensions;

namespace Piedone.ContentTypes
{
    [OrchardFeature("Piedone.ContentTypes.ContentLinks")]
    public class ContentLinksMigrations : DataMigrationImpl
    {
        public int Create()
        {
            ContentDefinitionManager.AlterPartDefinition("ContentLink",
                part => part
                    .WithField("AttachedContent", cfg => cfg
                        .OfType("ContentPickerField")
                        .WithSetting("ContentPickerFieldSettings.Required", "true")
                        .WithSetting("ContentPickerFieldSettings.Multiple", "false"))
                );

            ContentDefinitionManager.AlterTypeDefinition("ContentLink",
                cfg => cfg
                    .WithPart("CommonPart", p => p
                        .WithSetting("DateEditorSettings.ShowDateEditor", "false")
                        .WithSetting("OwnerEditorSettings.ShowOwnerEditor", "false"))
                    .WithPart("TitlePart")
                    .WithPart("ContentLink")
                    .Creatable()
                );

            return 1;
        }
    }
}