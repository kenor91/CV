using GraphQL.Instrumentation;

namespace Application.Schema
{
    public class CVSchema : GraphQL.Types.Schema
    {
        public CVSchema(IServiceProvider provider) : base(provider)
        {
            Query = (CVQuery)provider.GetService(typeof(CVQuery)) ?? throw new InvalidOperationException();

            FieldMiddleware.Use(new InstrumentFieldsMiddleware());
        }
    }
}
