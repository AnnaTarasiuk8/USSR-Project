using System;
using System.Reflection;

namespace Gurskaia_Tarasiuk_Final.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}