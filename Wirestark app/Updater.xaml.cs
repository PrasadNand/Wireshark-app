
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Linq;
using Microsoft.Office.Interop.Word;
using System.Windows;
using System.Collections.Generic;
using Version = System.Version;

namespace Wirestark_app
{
	

public partial class Updater : System.Windows.Window
	{			


		public Updater()
		{
			InitializeComponent();
			Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
			Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();

			object fileName = "C:\\Users\\nandi\\OneDrive\\Desktop\\Wireshark_Release_Notes.docx";
			// Define an object to pass to the API for missing parameters
			object missing = System.Type.Missing;
			doc = word.Documents.Open(ref fileName, ref missing, ref missing);

			String read = string.Empty;
			List<string> data = new List<string>();
			for (int i = 0; i < doc.Paragraphs.Count; i++)
			{
				string temp = doc.Paragraphs[i + 1].Range.Text.Trim();
				if (temp != string.Empty)
					data.Add(temp);
			}
			doc.Close();
			word.Quit();
			foreach (var item in data)
			{
				releasetxtbox.Text += item;	}				
			
		}
	
		private void Updater_ContentRendered(object sender, EventArgs e)
		{
		
		}

		private void updbtn_Click(object sender, RoutedEventArgs e)
		{
			string version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
			System.Version currentVersion = new Version(version);
			DateTime d = DateTime.Now;
			string NewVersionString = new Version(currentVersion.Major,
			currentVersion.Minor, currentVersion.Build + 1).ToString();
			//
			MainWindow mw = new MainWindow();
			mw.versiontxtbox.Text = NewVersionString;
			mw.Show();
			Close();
		

		}	
			

		
	}
}

