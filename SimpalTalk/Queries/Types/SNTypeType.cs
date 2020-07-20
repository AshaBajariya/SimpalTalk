using System;
using GraphQL.Types;
using SimpalTalk.Entities;

namespace SimpalTalk.Queries.Types
{
    public class SNTypeType : EnumerationGraphType<SNType>
    {
        public SNTypeType()
        {
            Name = "SNTypeType";
        }
    }
}
