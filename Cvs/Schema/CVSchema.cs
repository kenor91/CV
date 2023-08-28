using GraphQL.Instrumentation;
using Infrastructure.GraphQL;

namespace Cvs.Schema
{
    public class CVSchema : GraphQL.Types.Schema
    {
        public CVSchema(IServiceProvider provider) : base(provider)
        {
            Query = (CVQuery)provider.GetService(typeof(CVQuery)) ?? throw new InvalidOperationException();
            //Mutation = (StarWarsMutation)provider.GetService(typeof(StarWarsMutation)) ?? throw new InvalidOperationException();

            FieldMiddleware.Use(new InstrumentFieldsMiddleware());
        }
    }
}
