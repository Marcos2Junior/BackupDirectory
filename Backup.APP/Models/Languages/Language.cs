using System.Text.Json.Serialization;

namespace Backup.APP.Models.Languages
{
    public class Language
    {
        [JsonPropertyName("nameLanguage")]
        public string NameLanguage { get; set; }

        [JsonPropertyName("frmLogin")]
        public LanguageFrmLogin FrmLogin { get; set; }
    }
}
