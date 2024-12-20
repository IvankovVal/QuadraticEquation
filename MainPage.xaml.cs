namespace QuadraticEquation
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnActionBtnClicked(object sender, EventArgs e)
        {
            double coefA = double.Parse(coefficientA.Text);
            double coefB = double.Parse(coefficientB.Text);
            double coefC = double.Parse(coefficientC.Text);

            double discriminant = coefB * coefB - 4 * coefA * coefC;

            if (discriminant < 0) lblAnswer.Text = "Решений нет.";
            else if (discriminant > 0)
            {
                double x1 = -1 * coefB + Math.Sqrt(discriminant) / 2 * coefA;
                double x2 = -1 * coefB - Math.Sqrt(discriminant) / 2 * coefA;

                lblAnswer.Text = $"Уравнение имеет 2 корня x1 = {x1} и x2 = {x2}.";
            }
            else
            { 
            double x = -1 * coefB / 2 * coefA;
            lblAnswer.Text = $"Уравнение имеет 1 корня x = {x}.";
            }
        }
    }

}
