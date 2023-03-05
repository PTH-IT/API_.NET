using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using ThirdParty.Json.LitJson;

namespace API_.NET.model.account
{
    public class Login
    {
        [JsonPropertyName("username")]
        public string? UserName { get; set; }
        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }

}
