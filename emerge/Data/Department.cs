using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using static MudBlazor.CategoryTypes;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace emerge.Data
{
    public class Department
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "alertList")]
        public List<NewsAlert> AlertList { get; set; }
        [JsonProperty(PropertyName = "imageurl")]
        public string ImageUrl { get; set; }

        public Boolean CheckDepartment()
        {
            if (Id == null || Title == null || Description == null || AlertList == null || ImageUrl == null)
                return false;
            return true;
        }
    }

    
}
