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
using System.Windows.Shapes;

namespace extoolsMemoryVisualizer
{
	/// <summary>
	/// Interaction logic for NumDialog.xaml
	/// </summary>
	public partial class NumDialog : Window
	{
		public int Sensitivity;

		public NumDialog()
		{
			InitializeComponent();
		}

		private void okButton_Click(object sender, RoutedEventArgs e)
		{
			int val = 0;
			if(int.TryParse(sensitivity.Text, out val))
			{
				Sensitivity = val;
			}
			this.DialogResult = true;
		}
	}
}
