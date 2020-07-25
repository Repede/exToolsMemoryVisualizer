﻿using Microsoft.Win32;
using Newtonsoft.Json;
using System;
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

namespace extoolsMemoryVisualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<String> m_OpenedFiles = new List<string>();
        private List<MemDump> m_MemDumps = new List<MemDump>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnOpenClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Json *.json | *.json";
            open.Multiselect = true;
            open.Title = "Select Jsons";

            if (open.ShowDialog() == true)
            {
                m_OpenedFiles.Clear();
                m_OpenedFiles.AddRange(open.FileNames);
                m_OpenedFiles.Sort();
                ParseJson();
            }
        }

        private void ParseJson()
        {
            m_MemDumps.Clear();

            for(int i = 0; i < m_OpenedFiles.Count; ++i)
            {
                MemDump dump = JsonConvert.DeserializeObject<MemDump>(File.ReadAllText(m_OpenedFiles[i]));
                m_MemDumps.Add(dump);
            }
        }

        private void OnExitClicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}