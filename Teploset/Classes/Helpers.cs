using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Teploset.Models;

namespace Teploset.Classes
{
    public static class Helpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html,
            PagingInfo pagingInfo,
            Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }

            return MvcHtmlString.Create(result.ToString());
        }

        public static MvcHtmlString MenuItemForSideMenuAdminArea(
            this HtmlHelper html,
            string actionName,
            string controllerName,
            string displayText,
            string iconClass = null,
            object routeValues = null)
        {
            var resultHtml = string.Empty;
            if (string.IsNullOrEmpty(controllerName)) return new MvcHtmlString(resultHtml);

            var controller = html.ViewContext.Controller;
            if (controller == null) return new MvcHtmlString(resultHtml);

            //if (!controller.AccessManager.HasAccessToController(controllerName)) return new MvcHtmlString(resultHtml);

            var menuItemDisplayText = displayText;
            var icon = new TagBuilder("i");
            if (!string.IsNullOrEmpty(iconClass))
            {
                icon.MergeAttribute("class", iconClass);
                menuItemDisplayText = icon + " " + displayText;
            }

            var urlHelper = new UrlHelper(html.ViewContext.RequestContext);
            var url = urlHelper.Action(actionName, controllerName, routeValues);

            var link = new TagBuilder("a");
            link.MergeAttribute("href", url);
            link.InnerHtml = menuItemDisplayText;

            var menuItem = new TagBuilder("li");
            menuItem.InnerHtml = link.ToString();

            resultHtml = menuItem.ToString();

            return new MvcHtmlString(resultHtml);
        }
    }
}