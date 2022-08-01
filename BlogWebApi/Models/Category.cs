using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlogWebApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Post> Posts { get; set; }
    }
}