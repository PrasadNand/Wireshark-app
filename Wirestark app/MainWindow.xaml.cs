using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Linq;
using System.Windows;

using System.Reflection;


namespace Wirestark_app
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	/// 
	

	public partial class MainWindow : Window
	{
		
		public MainWindow()
		{


			InitializeComponent();

			string version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
			versiontxtbox.Text= version;

			







		}


	

		private void Window_ContentRendered(object sender, EventArgs e)
		{
		//versiontxtbox.Text = Application.P

		}

		private void PlayButton_Click(object sender, RoutedEventArgs e)
		{


			Updater upd = new Updater();
			upd.Show();
			Close();

		}
	}
}



