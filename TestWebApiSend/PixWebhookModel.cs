using System.Text.Json.Serialization;

namespace Pix.Models.Pix
{
    public class PixWebhookModel
    {
        [JsonPropertyName("pix")]
        public List<PixWebhook> Pix { get; set; }
    }

    public class PixWebhook
    {
        [JsonPropertyName("endToEndId")]
        public string EndToEndId { get; set; }

        [JsonPropertyName("txid")]
        public string Txid { get; set; }

        [JsonPropertyName("valor")]
        public string Valor { get; set; }

        [JsonPropertyName("componentesValor")]
        public Componentesvalor[] ComponentesValor { get; set; }

        [JsonPropertyName("chave")]
        public string Chave { get; set; }

        [JsonPropertyName("horario")]
        public DateTimeOffset Horario { get; set; }

        [JsonPropertyName("infoPagador")]
        public string InfoPagador { get; set; }
    }

    public class Componentesvalor
    {
        [JsonPropertyName("original")]
        public Original Original { get; set; }
    }

    public class Original
    {
        [JsonPropertyName("valor")]
        public string Valor { get; set; }
    }
}
