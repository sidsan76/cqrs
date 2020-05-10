using System.Collections.Generic;

namespace Xendor.QueryModel.Criteria.OrderBy
{
    public class OrderByEmptyExpression<TMetaData> : IOrderByExpression<TMetaData>
        where TMetaData : IMetaDataExpression
    {
        public IEnumerable<Field> Fields => new List<Field>().AsReadOnly();
    }
}