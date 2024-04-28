using System.Text.Json.Serialization;

namespace MauiAppFakeStoreApi.Models
{
    public class IdProduct
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }


    }
}
