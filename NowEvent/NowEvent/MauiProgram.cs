using Java.Lang;
using static Java.Util.Jar.Attributes;

using static System.Net.Mime.MediaTypeNames;

< ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"
             x: Class = "YourNamespace.PinPage" >
    < StackLayout >
        < Label Text = "Enter PIN" />
        < StackLayout Orientation = "Horizontal" >
            < Entry Placeholder = "●" IsPassword = "true" x: Name = "Digit1Entry" MaxLength = "1" WidthRequest = "50" />
            < Entry Placeholder = "●" IsPassword = "true" x: Name = "Digit2Entry" MaxLength = "1" WidthRequest = "50" />
            < Entry Placeholder = "●" IsPassword = "true" x: Name = "Digit3Entry" MaxLength = "1" WidthRequest = "50" />
            < Entry Placeholder = "●" IsPassword = "true" x: Name = "Digit4Entry" MaxLength = "1" WidthRequest = "50" />
        </ StackLayout >
        < Button Text = "Submit" Clicked = "OnSubmitClicked" />
    </ StackLayout >
</ ContentPage >
