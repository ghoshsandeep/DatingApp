using System.Text.Json.Serialization;

namespace API.DTOs
{
    public class LoginDto
    {
        public string Username { get; set; }
       // [JsonIgnore]
        public string Password { get; set; }
    }
}