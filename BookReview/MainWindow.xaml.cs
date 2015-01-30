using System.Windows;

namespace BookReview
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public interface IEmployee
        {
            string Name { get; set; }
            int Counter { get; }
        }

        public class Employee : IEmployee
        {
            public static int numberOfEmployees;

        }
    }
}