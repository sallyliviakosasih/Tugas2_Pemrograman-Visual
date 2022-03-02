/*
 * Created by SharpDevelop.
 * User: Sally
 * Date: 3/2/2022
 * Time: 3:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textbox_nama = new System.Windows.Forms.TextBox();
			this.textbox_nim = new System.Windows.Forms.TextBox();
			this.textbox_kelas = new System.Windows.Forms.TextBox();
			this.textbox_matakuliah = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Masukan Nama anda :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(33, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Masukan NIM anda :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Masukan Kelas anda :";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(33, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Masukan Matakuliah :";
			// 
			// textbox_nama
			// 
			this.textbox_nama.Location = new System.Drawing.Point(214, 53);
			this.textbox_nama.Name = "textbox_nama";
			this.textbox_nama.Size = new System.Drawing.Size(308, 22);
			this.textbox_nama.TabIndex = 4;
			// 
			// textbox_nim
			// 
			this.textbox_nim.Location = new System.Drawing.Point(214, 86);
			this.textbox_nim.Name = "textbox_nim";
			this.textbox_nim.Size = new System.Drawing.Size(308, 22);
			this.textbox_nim.TabIndex = 5;
			// 
			// textbox_kelas
			// 
			this.textbox_kelas.Location = new System.Drawing.Point(214, 118);
			this.textbox_kelas.Name = "textbox_kelas";
			this.textbox_kelas.Size = new System.Drawing.Size(308, 22);
			this.textbox_kelas.TabIndex = 6;
			// 
			// textbox_matakuliah
			// 
			this.textbox_matakuliah.Location = new System.Drawing.Point(214, 154);
			this.textbox_matakuliah.Name = "textbox_matakuliah";
			this.textbox_matakuliah.Size = new System.Drawing.Size(308, 22);
			this.textbox_matakuliah.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(114, 212);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(312, 37);
			this.button1.TabIndex = 8;
			this.button1.Text = "Klik Saya";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 476);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textbox_matakuliah);
			this.Controls.Add(this.textbox_kelas);
			this.Controls.Add(this.textbox_nim);
			this.Controls.Add(this.textbox_nama);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tugas 2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textbox_matakuliah;
		private System.Windows.Forms.TextBox textbox_kelas;
		private System.Windows.Forms.TextBox textbox_nim;
		private System.Windows.Forms.TextBox textbox_nama;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
