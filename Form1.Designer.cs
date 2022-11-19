namespace NumsToList
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnNumbersToList = new System.Windows.Forms.Button();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnNumbersToList
			// 
			this.btnNumbersToList.AutoSize = true;
			this.btnNumbersToList.Location = new System.Drawing.Point(12, 12);
			this.btnNumbersToList.Name = "btnNumbersToList";
			this.btnNumbersToList.Size = new System.Drawing.Size(776, 114);
			this.btnNumbersToList.TabIndex = 0;
			this.btnNumbersToList.Text = "Clipboard Numbers to List";
			this.btnNumbersToList.UseVisualStyleBackColor = true;
			this.btnNumbersToList.Click += new System.EventHandler(this.btnNumbersToList_Click);
			// 
			// tbOutput
			// 
			this.tbOutput.Cursor = System.Windows.Forms.Cursors.No;
			this.tbOutput.Location = new System.Drawing.Point(12, 132);
			this.tbOutput.Multiline = true;
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.ReadOnly = true;
			this.tbOutput.Size = new System.Drawing.Size(776, 306);
			this.tbOutput.TabIndex = 1;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.btnNumbersToList);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clipboard Numbers to List";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnNumbersToList;
		private TextBox tbOutput;
	}
}