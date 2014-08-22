﻿using JustEat.ZendeskApi.Client.Http;
using JustEat.ZendeskApi.Contracts.Models;
using JustEat.ZendeskApi.Contracts.Queries;
using JustEat.ZendeskApi.Contracts.Responses;

namespace JustEat.ZendeskApi.Client.Resources
{
    public class SearchResource : ISearchResource
    {
        private const string SearchUri = @"/api/v2/search";

        private readonly IRestClient _client;

        public SearchResource(IRestClient client)
        {
            _client = client;
        }

        public IListResponse<T> Find<T>(IZendeskQuery<T> zendeskQuery) where T : IZendeskEntity
        {
            var requestUri = _client.BuildUri(SearchUri, zendeskQuery.BuildQuery());

            return _client.Get<ListResponse<T>>(requestUri);
        }
    }
}
