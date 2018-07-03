using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;
using Sitecore.Foundation.Tags.Model;

namespace Sitecore.Feature.Blog.Models
{
    [SitecoreType(AutoMap = true, TemplateId = Templates.BlogArticle.ID_String)]
    public interface IBlogArticle : IBaseItem
    {
        IArticleType ArticleType { get; set; }

        DateTime BlogDate { get; set; }

        string BlogTitle { get; set; }

        string BlogIntroduction { get; set; }

        string BlogBody { get; set; }

        Image BlogImage { get; set; }

        IEnumerable<ITag> Tags { get; set; }

        [SitecoreField(Setting = SitecoreFieldSettings.InferType)]
        IBlogAuthor BlogAuthor { get; set; }
    }
}
