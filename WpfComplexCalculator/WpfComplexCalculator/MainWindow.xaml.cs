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
using ComplexCalculatorService;
using System.ComponentModel;

namespace WpfComplexCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bAddDouble_Click(object sender, RoutedEventArgs e)
        {
            var ComplexCalc = new ComplexServicesClient();

            lResult.Content = ComplexCalc.AddFourValueAsync(double.Parse(tFirstReal.Text), 
                double.Parse(tSecondReal.Text), double.Parse(tFirstImaginary.Text), double.Parse(tSecondImaginary.Text)).Result;
        }

        private void bSubDouble_Click(object sender, RoutedEventArgs e)
        {
            var ComplexCalc = new ComplexServicesClient();

            lResult.Content = ComplexCalc.SubtractFourValue(double.Parse(tFirstReal.Text),
                double.Parse(tSecondReal.Text), double.Parse(tFirstImaginary.Text), double.Parse(tSecondImaginary.Text));
        }

        private void bMultipyDouble_Click(object sender, RoutedEventArgs e)
        {
            var ComplexCalc = new ComplexServicesClient();

            lResult.Content = ComplexCalc.MultiplyFourValue(double.Parse(tFirstReal.Text),
                double.Parse(tSecondReal.Text), double.Parse(tFirstImaginary.Text), double.Parse(tSecondImaginary.Text));
        }

        private void bDivDouble_Click(object sender, RoutedEventArgs e)
        {
            var ComplexCalc = new ComplexServicesClient();

            lResult.Content = ComplexCalc.DivisionFourValue(double.Parse(tFirstReal.Text),
                double.Parse(tSecondReal.Text), double.Parse(tFirstImaginary.Text), double.Parse(tSecondImaginary.Text));
        }

        private void bAddComplex_Click(object sender, RoutedEventArgs e)
        {
            var ComplexCalc = new ComplexServicesClient();
            var FirstComplex = new ComplexType();
            var SecondComplex = new ComplexType();

            FirstComplex.RealValueOperation = double.Parse(tFirstReal.Text);
            FirstComplex.ImaginryValueOperation = double.Parse(tFirstImaginary.Text);

            SecondComplex.RealValueOperation = double.Parse(tSecondReal.Text);
            SecondComplex.ImaginryValueOperation = double.Parse(tSecondImaginary.Text);


            lResult.Content = ComplexCalc.AddTwoValue(FirstComplex,SecondComplex);
        }

        private void bSubComplex_Click(object sender, RoutedEventArgs e)
        {
            var ComplexCalc = new ComplexServicesClient();
            var FirstComplex = new ComplexType();
            var SecondComplex = new ComplexType();

            FirstComplex.RealValueOperation = double.Parse(tFirstReal.Text);
            FirstComplex.ImaginryValueOperation = double.Parse(tFirstImaginary.Text);

            SecondComplex.RealValueOperation = double.Parse(tSecondReal.Text);
            SecondComplex.ImaginryValueOperation = double.Parse(tSecondImaginary.Text);


            lResult.Content = ComplexCalc.SubtractTwoValue(FirstComplex, SecondComplex);
        }

        private void bMultipyComplex_Click(object sender, RoutedEventArgs e)
        {
            var ComplexCalc = new ComplexServicesClient();
            var FirstComplex = new ComplexType();
            var SecondComplex = new ComplexType();

            FirstComplex.RealValueOperation = double.Parse(tFirstReal.Text);
            FirstComplex.ImaginryValueOperation = double.Parse(tFirstImaginary.Text);

            SecondComplex.RealValueOperation = double.Parse(tSecondReal.Text);
            SecondComplex.ImaginryValueOperation = double.Parse(tSecondImaginary.Text);


            lResult.Content = ComplexCalc.MultiplyTwoValue(FirstComplex, SecondComplex);
        }

        private void bDivComplex_Click(object sender, RoutedEventArgs e)
        {
            var ComplexCalc = new ComplexServicesClient();
            var FirstComplex = new ComplexType();
            var SecondComplex = new ComplexType();

            FirstComplex.RealValueOperation = double.Parse(tFirstReal.Text);
            FirstComplex.ImaginryValueOperation = double.Parse(tFirstImaginary.Text);

            SecondComplex.RealValueOperation = double.Parse(tSecondReal.Text);
            SecondComplex.ImaginryValueOperation = double.Parse(tSecondImaginary.Text);


            lResult.Content = ComplexCalc.DivisionTwoValue(FirstComplex, SecondComplex);
        }
    }
}
