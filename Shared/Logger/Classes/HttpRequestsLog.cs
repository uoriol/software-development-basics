using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentCenter.Shared.Logger.Classes
{
    public class HttpRequestsLog
    {
        public string Url { get; set; } = string.Empty;
        public string Headers { get; set; } = string.Empty;
        public HttpStatusCode StatusCode {  get; set; }
        public string Response { get; set; } = string.Empty;

    }
}
