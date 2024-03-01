using System.Text.Json.Serialization;

namespace WebDev_CW.Models
{
    public class User
{
    public int UserID { get; set; }
    public required string Name { get; set; }
    [JsonIgnore]
    public List<Borrowing>? Borrowings { get; set; }
}



}
