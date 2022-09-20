using System.ComponentModel.DataAnnotations;

namespace mudblazorserver1.Data
{
  public class CardModel
  {
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
    public string? Title { get; set; }
    [Required]
    [StringLength(150, ErrorMessage = "This field should be filled")]
    public string? Text { get; set; }
    public bool IsChecked { get; set; } = true;
    public int Range { get; set; } 
    public int Counter { get; set; }
    

  }
}
