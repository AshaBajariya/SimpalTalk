using GraphQL.Types;
using SimpalTalk.Entities;

namespace SimpalTalk.Queries.Types
{
    public class RatingType : ObjectGraphType<Rating>
    {
        public RatingType()
        {
            Field(x => x.Count);
            Field(x => x.Percent);
        }
    }
}
