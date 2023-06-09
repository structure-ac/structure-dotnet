///
 /// Code generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
 ///

namespace SDK.Models.Shared;
using SDK.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

public class Company
{
    [JsonProperty("about")]
    public string About { get; set; }
    
    [JsonProperty("affiliated")]
    public IEnumerable<string> Affiliated { get; set; }
    
    [JsonProperty("company_size")]
    public string CompanySize { get; set; }
    
    [JsonProperty("country_code")]
    public string CountryCode { get; set; }
    
    [JsonProperty("employees")]
    public IEnumerable<string> Employees { get; set; }
    
    [JsonProperty("employees_in_linkedin")]
    public float EmployeesInLinkedin { get; set; }
    
    [JsonProperty("followers")]
    public float Followers { get; set; }
    
    [JsonProperty("founded")]
    public float Founded { get; set; }
    
    [JsonProperty("funding")]
    public string Funding { get; set; }
    
    [JsonProperty("headquarters")]
    public string Headquarters { get; set; }
    
    [JsonProperty("id")]
    public float Id { get; set; }
    
    [JsonProperty("industries")]
    public string Industries { get; set; }
    
    [JsonProperty("investors")]
    public string Investors { get; set; }
    
    [JsonProperty("jobs")]
    public IEnumerable<string> Jobs { get; set; }
    
    [JsonProperty("lid")]
    public string Lid { get; set; }
    
    [JsonProperty("locations")]
    public IEnumerable<string> Locations { get; set; }
    
    [JsonProperty("logo")]
    public string Logo { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("organization_type")]
    public string OrganizationType { get; set; }
    
    [JsonProperty("profiles")]
    public IEnumerable<string> Profiles { get; set; }
    
    [JsonProperty("region")]
    public string Region { get; set; }
    
    [JsonProperty("similar")]
    public IEnumerable<string> Similar { get; set; }
    
    [JsonProperty("slogan")]
    public string Slogan { get; set; }
    
    [JsonProperty("specialities")]
    public string Specialities { get; set; }
    
    [JsonProperty("sphere")]
    public string Sphere { get; set; }
    
    [JsonProperty("type")]
    public string Type { get; set; }
    
    [JsonProperty("url")]
    public string Url { get; set; }
    
    [JsonProperty("website")]
    public string Website { get; set; }
    
}
