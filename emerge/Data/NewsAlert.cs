using System;
using System.Reflection.Emit;
using System.Xml.Linq;
using Newtonsoft.Json;
using static MudBlazor.CategoryTypes;

namespace emerge.Data
{
    public class NewsAlert
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "time")]
        public DateTime Time { get; set; }
        [JsonProperty(PropertyName = "affected")]
        public List<string> Affected { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "author")]
        public string Author { get; set; }
        [JsonProperty(PropertyName = "department")]
        public Department Department { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "priority")]
        public int Priority { get; set; }
        [JsonProperty(PropertyName = "imageurl")]
        public string ImageUrl { get; set; }
        [JsonProperty(PropertyName = "updates")]
        public List<UpdateInfo> Updates { get; set; }

        public string generateZipString()
        {
            string zipString = "";
            foreach(string zipcode in Affected)
            {
                zipString += zipcode;
                zipString += ", ";
                
            }
            if(zipString.Length >= 2)
            {
                return zipString.Substring(0, zipString.Length - 2);
            } else {
                return zipString;
            }
        }

        public Boolean CheckAlert()
        {
            if (Id == null || Time == null || Affected == null || Title == null || Author == null || Department == null || Description == null || Priority == null || ImageUrl == null || Updates == null)
                return false;
            return true;
        }
    }
}
