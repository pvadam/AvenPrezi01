using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Web.Models;

namespace DI.Web.Models
{
    public class Organization
    {
        public string Name { get; set; }
        // [JsonProperty("Avatar_Url")]
        public string AvatarUrl { get; set; }
        public IQueryable<Project> Projects { get; set; }
    }
}