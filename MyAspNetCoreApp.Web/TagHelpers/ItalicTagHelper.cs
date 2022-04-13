using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyAspNetCoreApp.Web.TagHelpers
{
    public class ItalicTagHelper:TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // <i>ahmet</i>
            output.PreContent.SetHtmlContent("<i>");

            output.PostContent.SetHtmlContent("</li>");

        }
    }
}
