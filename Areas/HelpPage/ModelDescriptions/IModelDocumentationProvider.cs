using System;
using System.Reflection;

namespace RestaurantApplication_UsingWEBAPIAngular.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}