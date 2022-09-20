using Microsoft.AspNetCore.Components;
 


namespace mudblazorserver1.Data
{
  public class ChildComponentBase : ComponentBase
  {
    protected bool DarkThemeOn;
    
    [Inject]
    protected _RandomService randomService {get; set;}
    
    protected string AlertTheme => DarkThemeOn ? "dark" : "light";

    [Parameter]
    public RenderFragment ChildContent { get; set; }  

    protected override void OnInitialized()
    {
      DarkThemeOn = true;
    }
  }
}