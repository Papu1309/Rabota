﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lstSpisok.Items.Add("Понедельник");
            lstSpisok.Items.Add("Вторник");
            lstSpisok.Items.Add("Среда");
            lstSpisok.Items.Add("Четверг");
            lstSpisok.Items.Add("Пятница");
            lstSpisok.Items.Add("Суббота");
            lstSpisok.Items.Add("Воскресенье");
            LoadTextFromFile("C:\\Users\\Ильмир\\Desktop\\File3.txt");
        }
        private void LoadTextFromFile(string filePath)
        {
          txbText.Text = File.ReadAllText(filePath);
          
        }
    }
}
