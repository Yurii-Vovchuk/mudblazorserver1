using System.ComponentModel.DataAnnotations;

namespace mudblazorserver1.Data
{
  public class CardModel
  {
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
    public string? Title { get; set; }
    [Required]
    public string? Text { get; set; }
    public bool IsChecked { get; set; } = true;
    public int Range { get; set; }
    

  }
}
