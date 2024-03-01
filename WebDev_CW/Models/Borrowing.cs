using System.Text.Json.Serialization;

namespace WebDev_CW.Models
{
   public class Borrowing
{
    public int BorrowingID { get; set; }
    public int UserID { get; set; }
    [JsonIgnore]
    public User? User { get; set; }
    public int BookID { get; set; }
    [JsonIgnore]
    public Book? Book { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime ReturnDate { get; set; }
} 
}