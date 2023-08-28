using Models;
using GraphQL.Types;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;

namespace Application.Types
{
    public class EducationType : ObjectGraphType<Education>
    {
        public EducationType()
        {
            Name = "Education";
            Field(x => x.Id).Description("Unique identifier");
            Field(x => x.Name);
        }
    }
}
