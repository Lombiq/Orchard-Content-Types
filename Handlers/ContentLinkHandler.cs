using System.Linq;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Environment;
using Orchard.Environment.Extensions;
using Orchard.Localization;

namespace Piedone.ContentTypes.Handlers
{
    [OrchardFeature("Piedone.ContentTypes.ContentLinks")]
    public class ContentLinkHandler : ContentHandler
    {
        private readonly Work<IContentManager> _contentManagerWork;

        public Localizer T { get; set; }

        public ContentLinkHandler(Work<IContentManager> contentManagerWork)
        {
            _contentManagerWork = contentManagerWork;

            T = NullLocalizer.Instance;
        }

        protected override void GetItemMetadata(GetContentItemMetadataContext context)
        {
            var item = context.ContentItem;
            if (item.ContentType != "ContentLink") return;

            var attachedContentId = ((int[])((dynamic)item).ContentLink.AttachedContent.Ids).First();

            var contentManager = _contentManagerWork.Value;
            var content = contentManager.Get(attachedContentId);
            if (content == null) return;
            context.Metadata.DisplayRouteValues = contentManager.GetItemMetadata(content).DisplayRouteValues;
        }
    }
}