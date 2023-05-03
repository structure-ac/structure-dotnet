///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Companies;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using SDK.Models.Shared;
using SDK.Models.Companies;
using SDK.Utils;

public interface ICompaniesSDK
{
    Task<EnrichCompanyResponse> EnrichAsync(EnrichCompanyRequest request);
    Task<ListEmployeesResponse> ListEmployeesAsync(ListEmployeesRequest request);
    Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request);
    Task<SearchCompaniesResponse> SearchAsync(SearchCompaniesApplicationJSON request);
}

public class CompaniesSDK: ICompaniesSDK
{

    private const string language = "csharp";
    private const string sdkVersion = "0.0.1";
    private const string sdkGenVersion = "internal";
    public Uri ServerUrl { get { return _defaultClient.BaseAddress; } }
    private HttpClient _defaultClient;
    private HttpClient _securityClient;

    public CompaniesSDK(HttpClient defaultClient, HttpClient securityClient)
    {
        _defaultClient = defaultClient;
        _securityClient = securityClient;
    }

    
    public async Task<EnrichCompanyResponse> EnrichAsync(EnrichCompanyRequest request)
    {
        string baseUrl = "";
        var message = EnrichCompanyRequest.BuildHttpRequestMessage("enrich_company", request);
        var httpResponseMessage = await _defaultClient.SendAsync(message);
        var response = new EnrichCompanyResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("*/*",response.ContentType))
            {
                // */*
                throw new NotImplementedException();
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 403) || (response.StatusCode == 404) || (response.StatusCode == 422))
        {
            return response;
        }
        return response;
    }

    
    public async Task<ListEmployeesResponse> ListEmployeesAsync(ListEmployeesRequest request)
    {
        string baseUrl = "";
        var message = ListEmployeesRequest.BuildHttpRequestMessage("list_employees", request);
        var httpResponseMessage = await _defaultClient.SendAsync(message);
        var response = new ListEmployeesResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("*/*",response.ContentType))
            {
                // */*
                throw new NotImplementedException();
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 403) || (response.StatusCode == 404))
        {
            return response;
        }
        return response;
    }

    
    public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
    {
        string baseUrl = "";
        var message = ListJobsRequest.BuildHttpRequestMessage("list_jobs", request);
        var httpResponseMessage = await _defaultClient.SendAsync(message);
        var response = new ListJobsResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("*/*",response.ContentType))
            {
                // */*
                throw new NotImplementedException();
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 403) || (response.StatusCode == 404))
        {
            return response;
        }
        return response;
    }

    
    public async Task<SearchCompaniesResponse> SearchAsync(SearchCompaniesApplicationJSON request)
    {
        string baseUrl = "";
        var message = SearchCompaniesApplicationJSON.BuildHttpRequestMessage("search_companies", request);
        var httpResponseMessage = await _defaultClient.SendAsync(message);
        var response = new SearchCompaniesResponse
        {
            StatusCode = (int)httpResponseMessage.StatusCode,
            ContentType = httpResponseMessage.Content.Headers.ContentType?.MediaType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("*/*",response.ContentType))
            {
                // */*
                throw new NotImplementedException();
            }
            return response;
        }
        if((response.StatusCode == 401) || (response.StatusCode == 403))
        {
            return response;
        }
        return response;
    }

    
}