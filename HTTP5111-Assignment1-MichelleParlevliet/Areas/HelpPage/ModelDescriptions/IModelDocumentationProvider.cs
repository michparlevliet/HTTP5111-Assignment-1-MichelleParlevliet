using System;
using System.Reflection;

namespace HTTP5111_Assignment1_MichelleParlevliet.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}