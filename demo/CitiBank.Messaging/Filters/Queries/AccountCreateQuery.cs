﻿using System.Collections.Generic;
using Xendor.Data;

namespace CitiBank.Messaging.Filters.Queries
{
    public class AccountCreateQuery : Query
    {
        public AccountCreateQuery(IDictionary<string, object> values)
            : base(values)
        {

        }
        public override string Sql =>
            "SELECT  @ClientId := id from clients where AggregateId = @ClientAggregateId; " +
            "SELECT  @ProductId := id from products where AggregateId = @ProductAggregateId; " +
            "INSERT INTO accounts (AggregateId, Number, ClientId, ProductId) " +
            "VALUES " +
            " (@AggregateId, @Number, @ClientId, @ProductId)";
    }
}