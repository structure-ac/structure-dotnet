///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK;
using System.Collections.Generic;
using System.Text;
using SDK.Accounts;
using SDK.Companies;
using SDK.People;
using SDK.User;
using System.Net.Http;
using SDK.Models.Security;
using SDK.Utils;

public interface ISDKSDK
{
    public IAccountsSDK Accounts { get; }
    public ICompaniesSDK Companies { get; }
    public IPeopleSDK People { get; }
    public IUserSDK User { get; }
}

public class SDKSDK: ISDKSDK
{
    public static List<string> ServerList = new List<string>()
    {
        "https://www.structure.ac/api/v1",
    };

    private const string language = "csharp";
    private const string sdkVersion = "0.0.1";
    private const string sdkGenVersion = "internal";
    public Uri ServerUrl { get { return _defaultClient.BaseAddress; } }
    private HttpClient _defaultClient;
    private HttpClient _securityClient;
    public IAccountsSDK Accounts { get; private set; }
    public ICompaniesSDK Companies { get; private set; }
    public IPeopleSDK People { get; private set; }
    public IUserSDK User { get; private set; }

    public SDKSDK(HttpClient? client = null, string? serverUrl = null, Security? security = null)
    {
        _defaultClient = client;
        if(_defaultClient == null)
        {
            _defaultClient = new HttpClient();
            var _serverUrl = serverUrl ?? SDKSDK.ServerList[0];

            _defaultClient.BaseAddress = new System.Uri(_serverUrl);
        }
        _securityClient = _defaultClient;
        if(security != null)
        {
throw new NotImplementedException();
        }
        Accounts = new AccountsSDK(_defaultClient, _securityClient);
        Companies = new CompaniesSDK(_defaultClient, _securityClient);
        People = new PeopleSDK(_defaultClient, _securityClient);
        User = new UserSDK(_defaultClient, _securityClient);
    }
}