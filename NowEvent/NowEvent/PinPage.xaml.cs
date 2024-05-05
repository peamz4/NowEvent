public partial class PinPage : ContentPage
{
    private const string CorrectPin = "1234"; // Define your correct PIN here

    public PinPage()
    {
        InitializeComponent();
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        string enteredPin = Digit1Entry.Text + Digit2Entry.Text + Digit3Entry.Text + Digit4Entry.Text;
        if (enteredPin == CorrectPin)
        {
            // Correct PIN, navigate to the main page
            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            // Incorrect PIN, show an error message
            await DisplayAlert("Error", "Incorrect PIN. Please try again.", "OK");
            // Clear the entry fields
            Digit1Entry.Text = Digit2Entry.Text = Digit3Entry.Text = Digit4Entry.Text = string.Empty;
        }
    }
}
