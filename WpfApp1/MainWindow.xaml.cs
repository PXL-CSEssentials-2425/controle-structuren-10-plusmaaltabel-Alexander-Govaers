﻿using System;
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

namespace WpfApp1
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


        private void optelButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            bool validInput = int.TryParse(inputTextBox.Text, out int inputUser);



            for (int i = 1; i <= inputUser; i++)
            {
                resultTextBox.Text += $"\t{i}";



            }

            resultTextBox.Text += $"\n";

            for (int i = 1; i <= inputUser; i++)
            {
                resultTextBox.Text += $"{i}\t";

                for (int j = 1; j <= inputUser; j++)
                {

                    resultTextBox.Text += $"{i + j}\t";

                }

                resultTextBox.Text += $"\n";

            }




        }

        private void vermenigvuldigbutton_Click(object sender, RoutedEventArgs e)
        {
            bool validInput = int.TryParse(inputTextBox.Text, out int inputUser);


            for (int i = 1; i <= inputUser; i++)
            {
                resultTextBox.Text += $"\t{i}";



            }

            resultTextBox.Text += $"\n\n";

            for (int i = 1; i <= inputUser; i++)
            {
                resultTextBox.Text += $"{i}\t";


                for (int j = 1; j <= inputUser; j++)
                {

                    resultTextBox.Text += $"{i * j}\t";

                }

                resultTextBox.Text += $"\n";

            }
        }
}
