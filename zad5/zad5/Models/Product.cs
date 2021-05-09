using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace zad5.Models
{
    public class Product
    {
      //  [JsonConverter(typeof(IntToStringConverter))]
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        [Required]
        [MaxLength(200)]

        public string Url { get; set; }
        [Required]
        [MaxLength(300)]

        public string Title { get; set; }
        [Required]
        [MaxLength(500)]

        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
