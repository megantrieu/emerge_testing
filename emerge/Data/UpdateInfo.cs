using System;
using Newtonsoft.Json;

namespace emerge.Data
{
    public class UpdateInfo
    {
        [JsonProperty(PropertyName = "updatetime")]
        public DateTime UpdateTime { get; set; }
        [JsonProperty(PropertyName = "updatedescription")]
        public string UpdateDescription { get; set; }
        [JsonProperty(PropertyName = "updatepriority")]
        public int UpdatePriority { get; set; }

        public Boolean CheckUpdate()
        {
            if (UpdateTime == null|| UpdateDescription == null || UpdatePriority == null)
                return false;
            return true;
        }
    }

    
}

