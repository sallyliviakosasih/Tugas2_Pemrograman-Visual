/*
 * Created by SharpDevelop.
 * User: Sally
 * Date: 3/2/2022
 * Time: 3:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string nama = this.textbox_nama.Text.ToString();
			string nim = this.textbox_nim.Text.ToString();
			string kelas = this.textbox_kelas.Text.ToString();
			string matkul = this.textbox_matakuliah.Text.ToString();
			
			if(nama.Length>0 && nim.Length>0 && kelas.Length>0 && matkul.Length>0) 
				MessageBox.Show("Nama : "+nama+"\n"+"NIM : "+nim+"\n"+"KOM : "+kelas+"\n"+"Matakuliah : "+matkul,matkul);
			else
				MessageBox.Show("Data Belum Lengkap","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
	}
}
