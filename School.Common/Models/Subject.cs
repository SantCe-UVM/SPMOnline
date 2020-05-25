namespace School.Common.Models
{
    using Newtonsoft.Json;
    public class Subject
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("credits")]
        public double Credits { get; set; }

        public override string ToString()
        {
            return $"{this.Name}  {this.Credits}";
        }
    }
}
