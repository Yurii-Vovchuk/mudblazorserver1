using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
// using Blazored.LocalStorage;
using MudBlazor;

namespace mudblazorserver1.Shared
{
    public partial class MainLayout
    {
        // [Inject]
        // public ILocalStorageService LocalStorage { get; set; }

        bool _drawerOpen = true;
        private string _themName = "light";
        private string themIcon = Icons.Filled.BrightnessLow;

        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        MudTheme _currentTheme = null;
        MudTheme _darkTheme = new MudTheme
        {
            Palette = new Palette
            {
                AppbarBackground = "#1F3143",
                AppbarText = "#FFFFFF",
                Primary = "#EC407A",
                Secondary = "#FFB74D",
                TextPrimary = "#1F3143",
                TextSecondary = "#DFE3E4",
                DrawerBackground = "#1F3143",
                DrawerText = "#FFFFFF",
                Surface = "#FFFFFF",
                ActionDefault = "#1F3143", // Radio, Checkbox...
                ActionDisabled = "#FFFFFF", // text disabl
                TextDisabled = "#DFE3E4",
                InfoContrastText = "#8E4CA9",
            }
        };
        MudTheme _lightTheme = new MudTheme
        {
            Palette = new Palette
            {
                AppbarBackground = "#BDBDBD",
                AppbarText = "#000000",
                Primary = "#EC407A",
                Secondary = "#FFB74D",
                TextPrimary = "#1F3143",
                TextSecondary = "#DFE3E4",
                DrawerBackground = "#ECEFF1",
                DrawerText = "#37474F",
                Surface = "#FFFFFF",
                ActionDefault = "#1F3143", // Radio, Checkbox...
                ActionDisabled = "#FFFFFF", // text disabl
                TextDisabled = "#DFE3E4",
                InfoContrastText = "#8E4CA9",
            }
        };

        private async Task ChangeThemeAsync()
        {
            if(_themName == "light")
            {
                _currentTheme = _darkTheme;
                _themName = "dark";
                themIcon = Icons.Filled.Brightness2;

            }
            else
            {
                _currentTheme = _lightTheme;
                _themName = "light";
                themIcon = Icons.Filled.BrightnessLow;
            }

        }

        // protected override async Task OnInitializedAsync()
        // {
        //     _currentTheme = _lightTheme;
        // }

        

    }

    
}