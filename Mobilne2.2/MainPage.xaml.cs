namespace Mobilne2._2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Imie.Text) || string.IsNullOrWhiteSpace(Miasto.Text))
            {
                Powitanie.Text = "Uzupełnij Dane!";
            }
            else { 

            count++;

            if (count >= 1)
                Powitanie.Text = " Witaj " + Imie.Text + " z miasta " + Miasto.Text;
            else
                Powitanie.Text = Powitanie.Text;
            }
        }
    }
}
