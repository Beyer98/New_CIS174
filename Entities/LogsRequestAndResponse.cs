using Microsoft.AspNetCore.Http;
using System;

namespace CIS174_Project.Entities
{
    public class LogsRequestAndResponse
    {
        public int Id { get; set; }
        public Guid RequestId { get; set; }
        public string HttpContext { get; set; }
    }
}
