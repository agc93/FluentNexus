using Newtonsoft.Json;

namespace Pathoschild.FluentNexus.Models
{
    /// <summary>A mod category available for a game's mods.</summary>
    public class GameCategory
    {
        /// <summary>The category ID.</summary>
        [JsonProperty("category_id")]
        public int ID { get; set; }

        /// <summary>The category name.</summary>
        public string Name { get; set; }

        /// <summary>The parent category, if any.</summary>
        public int? ParentCategory { get; set; }
    }
}