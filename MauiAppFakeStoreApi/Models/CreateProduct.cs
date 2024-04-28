using System.Text.Json.Serialization;

namespace MauiAppFakeStoreApi.Models
{
    public class CreateProduct
    {

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
        

    }
}
