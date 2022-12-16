using System;
using System.Windows;

namespace Korporator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] answers = {
            "Very valuable insight!",
            "Under other circumstances, \nit would be meaningful to elaborate.",
            "There are no shortcuts on the road to success.",
            "I'm struggling to understand the core thought.",
            "This is a very beneficial expression.",
            "This does not strike me as the brightest thought.",
            "That is an unprecended level of unverifiable activity.",
            "Brilliant idea, let's create a PBI for it!",
            "We will have to create an action plan for this topic.",
            "That is not an issue, it is a feature request.",
            "Let's organize a meeting to clarify the situation.",
            "For this we'd need to review the unallocated team capacity.",
            "This might significantly impact our product pipeline."

        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = MyTextBox.Text;

                // Generate random number
                Random rnd = new Random();
                int index = rnd.Next(answers.Length);

                // Show random answer
                AnswerTextBlock.Text = (answers[index]);
         
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyTextBox.Clear();
        }

    }
}
