using System.Text.Json.Serialization;

namespace Backup.APP.Models.Languages
{
    public class LanguageFrmLogin
    {
        [JsonPropertyName("tittle")]
        public string Tittle { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("checkPassword")]
        public string CheckPassword { get; set; }
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        [JsonPropertyName("newAccount")]
        public string NewAccount { get; set; }
        [JsonPropertyName("needHelp")]
        public string NeedHelp { get; set; }
        [JsonPropertyName("forgotPassword")]
        public string ForgotPassword { get; set; }
        [JsonPropertyName("passwordHint")]
        public string PasswordHint { get; set; }
        [JsonPropertyName("login")]
        public string Login { get; set; }
        [JsonPropertyName("create")]
        public string Create { get; set; }
        [JsonPropertyName("close")]
        public string Close { get; set; }
        [JsonPropertyName("back")]
        public string Back { get; set; }
        [JsonPropertyName("termsAndConditions")]
        public string TermsAndConditions { get; set; }
    }
}
