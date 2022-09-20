using System.ComponentModel.DataAnnotations;


namespace mudblazorserver1.Data
{
  public delegate void CounterHasChangedHandler();

  public class CounterModel
  {
    public event CounterHasChangedHandler CounterHasChanged;

    private int _counter;
    public int Counter 
    { get => _counter; 
      set {
        _counter = value;
        CounterHasChanged?.Invoke();
      } 
    }
    
   
  }

}
