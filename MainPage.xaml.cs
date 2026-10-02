namespace Mobilne._1._3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int count2 = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if(count >= 1)
            {
                Etykieta2.Text = "Aplikacja działa poprawnie";
            }
            else
            {
                Etykieta2.Text = "Witamy w aplikacji";
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnCounterClickedd(object? sender, EventArgs e)
        {
            count2++;
            if(count2 >= 1)
            {
                Etykieta2.Text = "Witamy W Aplikacji";
            }
           
        }
    }
}
