using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr_5_teselko_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Triad triad;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addWithNumber_Click(object sender, RoutedEventArgs e)
        {
            bool isNumEmpty = Int32.TryParse(inputNumber.Text, out int number);
            bool isFirstEmpty = Int32.TryParse(triad1First.Text, out int triadFirst);
            bool isSecondEmpty = Int32.TryParse(triad1Second.Text, out int triadSecond);
            bool isThirdEmpty = Int32.TryParse(triad1Third.Text, out int triadThird);
            if (isNumEmpty && isFirstEmpty && isSecondEmpty && isThirdEmpty)
            {
                triad = new Triad(triadFirst, triadSecond, triadThird);
                triad = triad.AddNumber(number);
                outputResult.Text = $"{triad.First} {triad.Second} {triad.Third}";
            }
            else MessageBox.Show("Введите необходимые значения", "Ошибка");
        }

        private void multiplyByNumber_Click(object sender, RoutedEventArgs e)
        {
            bool isNumEmpty = Int32.TryParse(inputNumber.Text, out int number);
            bool isFirstEmpty = Int32.TryParse(triad1First.Text, out int triadFirst);
            bool isSecondEmpty = Int32.TryParse(triad1Second.Text, out int triadSecond);
            bool isThirdEmpty = Int32.TryParse(triad1Third.Text, out int triadThird);
            if (isNumEmpty && isFirstEmpty && isSecondEmpty && isThirdEmpty)
            {
                triad = new Triad(triadFirst, triadSecond, triadThird);
                triad = triad.MultiplyNumber(number);
                outputResult.Text = $"{triad.First} {triad.Second} {triad.Third}";
            }
            else MessageBox.Show("Введите необходимые значения", "Ошибка");
        }

        private void checkEquality_Click(object sender, RoutedEventArgs e)
        {
            bool isFirstEmpty = Int32.TryParse(triad1First.Text, out int triadFirst);
            bool isSecondEmpty = Int32.TryParse(triad1Second.Text, out int triadSecond);
            bool isThirdEmpty = Int32.TryParse(triad1Third.Text, out int triadThird);
            if (isFirstEmpty && isSecondEmpty && isThirdEmpty)
            {
                triad = new Triad(triadFirst, triadSecond, triadThird);
                outputResult.Text = triad.IsEqual().ToString();
            }
            else MessageBox.Show("Введите необходимые значения", "Ошибка");
        }

        private void addWithTriad_Click(object sender, RoutedEventArgs e)
        {
            
            bool isFirstEmpty = Int32.TryParse(triad1First.Text, out int triadFirst);
            bool isSecondEmpty = Int32.TryParse(triad1Second.Text, out int triadSecond);
            bool isThirdEmpty = Int32.TryParse(triad1Third.Text, out int triadThird);
            bool isFirstEmpty2 = Int32.TryParse(triad2First.Text, out int triadFirst2);
            bool isSecondEmpty2 = Int32.TryParse(triad2Second.Text, out int triadSecond2);
            bool isThirdEmpty2 = Int32.TryParse(triad2Third.Text, out int triadThird2);
            if(isFirstEmpty && isSecondEmpty && isThirdEmpty && isFirstEmpty2 && isSecondEmpty2 && isThirdEmpty2)
            {
                Triad secondTriad = new Triad(triadFirst2, triadSecond2, triadThird2);
                Triad firstTriad = new Triad(triadFirst, triadSecond, triadThird);
                firstTriad = firstTriad.AddTriad(secondTriad);
                outputResult.Text = firstTriad.ToString();
            }
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Теселько Максим ИСП - 34\n" +
                "Практическая работа №5\n" +
                "Использовать класс Triad (тройка чисел). Разработать операцию для сложения " +
                "триады с числом.Разработать операцию для сложения элементов одой триады с другой триадой", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
