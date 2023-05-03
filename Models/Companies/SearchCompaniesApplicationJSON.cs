///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Companies;
using SDK.Utils;
using SDK.Models.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class SearchCompaniesApplicationJSON
{
    [JsonProperty("filter")]
    public string? Filter { get; set; }
    
    [JsonProperty("limit")]
    public string? Limit { get; set; }
    
    [JsonProperty("page")]
    public string? Page { get; set; }
    
    [JsonProperty("query")]
    public string? Query { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, SearchCompaniesApplicationJSON value)
    {
        if("search_companies" == operationId)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "/companies/search");

            string json = JsonConvert.SerializeObject(value);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [SearchCompaniesApplicationJSON]");
    }
}
