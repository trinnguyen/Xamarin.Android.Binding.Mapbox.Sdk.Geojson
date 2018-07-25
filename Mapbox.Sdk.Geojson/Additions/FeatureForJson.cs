using System.Collections.Generic;
using Newtonsoft.Json;

namespace Com.Mapbox.Geojson.Additions
{
    public class FeatureForJson
    {
        [JsonProperty("type")]
        public string Type { get { return "Feature"; } }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("geometry")]
        public DatasetGeometry Geometry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class Properties
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("mt-name")]
        public string MtName { get; set; }
    }

    public class DatasetGeometry
    {
        [JsonProperty("coordinates")]
        public IList<object> Coordinates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
