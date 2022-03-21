namespace PRAKTIKUMWEEK5
{
    partial class Form1
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
            this.Label_Data = new System.Windows.Forms.Label();
            this.TxtBox_Data = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Label_Koleksi = new System.Windows.Forms.Label();
            this.Label_Setting = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.CheckBox_Aktif = new System.Windows.Forms.CheckBox();
            this.RadioButton_Merah = new System.Windows.Forms.RadioButton();
            this.RadioButton_Biru = new System.Windows.Forms.RadioButton();
            this.Label_Output = new System.Windows.Forms.Label();
            this.Label2_Output = new System.Windows.Forms.Label();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.Location = new System.Drawing.Point(28, 27);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(31, 15);
            this.Label_Data.TabIndex = 0;
            this.Label_Data.Text = "Data";
            this.Label_Data.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBox_Data
            // 
            this.TxtBox_Data.Location = new System.Drawing.Point(65, 24);
            this.TxtBox_Data.Name = "TxtBox_Data";
            this.TxtBox_Data.Size = new System.Drawing.Size(227, 23);
            this.TxtBox_Data.TabIndex = 1;
            this.TxtBox_Data.TextChanged += new System.EventHandler(this.TxtBox_Data_TextChanged);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(308, 24);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Label_Koleksi
            // 
            this.Label_Koleksi.AutoSize = true;
            this.Label_Koleksi.Location = new System.Drawing.Point(28, 77);
            this.Label_Koleksi.Name = "Label_Koleksi";
            this.Label_Koleksi.Size = new System.Drawing.Size(44, 15);
            this.Label_Koleksi.TabIndex = 3;
            this.Label_Koleksi.Text = "Koleksi";
            // 
            // Label_Setting
            // 
            this.Label_Setting.AutoSize = true;
            this.Label_Setting.Location = new System.Drawing.Point(254, 77);
            this.Label_Setting.Name = "Label_Setting";
            this.Label_Setting.Size = new System.Drawing.Size(44, 15);
            this.Label_Setting.TabIndex = 4;
            this.Label_Setting.Text = "Setting";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(28, 118);
            this.ListBox.Name = "ListBox";
            this.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox.Size = new System.Drawing.Size(186, 304);
            this.ListBox.TabIndex = 5;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // CheckBox_Aktif
            // 
            this.CheckBox_Aktif.AutoSize = true;
            this.CheckBox_Aktif.Location = new System.Drawing.Point(308, 77);
            this.CheckBox_Aktif.Name = "CheckBox_Aktif";
            this.CheckBox_Aktif.Size = new System.Drawing.Size(51, 19);
            this.CheckBox_Aktif.TabIndex = 6;
            this.CheckBox_Aktif.Text = "Aktif";
            this.CheckBox_Aktif.UseVisualStyleBackColor = true;
            this.CheckBox_Aktif.CheckedChanged += new System.EventHandler(this.CheckBox_Aktif_CheckedChanged);
            // 
            // RadioButton_Merah
            // 
            this.RadioButton_Merah.AutoSize = true;
            this.RadioButton_Merah.Location = new System.Drawing.Point(308, 102);
            this.RadioButton_Merah.Name = "RadioButton_Merah";
            this.RadioButton_Merah.Size = new System.Drawing.Size(96, 22);
            this.RadioButton_Merah.TabIndex = 7;
            this.RadioButton_Merah.TabStop = true;
            this.RadioButton_Merah.Text = "Warna Merah";
            this.RadioButton_Merah.UseCompatibleTextRendering = true;
            this.RadioButton_Merah.UseVisualStyleBackColor = true;
            this.RadioButton_Merah.CheckedChanged += new System.EventHandler(this.RadioButton_Merah_CheckedChanged);
            // 
            // RadioButton_Biru
            // 
            this.RadioButton_Biru.AutoSize = true;
            this.RadioButton_Biru.Location = new System.Drawing.Point(308, 127);
            this.RadioButton_Biru.Name = "RadioButton_Biru";
            this.RadioButton_Biru.Size = new System.Drawing.Size(83, 19);
            this.RadioButton_Biru.TabIndex = 8;
            this.RadioButton_Biru.TabStop = true;
            this.RadioButton_Biru.Text = "Warna Biru";
            this.RadioButton_Biru.UseVisualStyleBackColor = true;
            this.RadioButton_Biru.CheckedChanged += new System.EventHandler(this.RadioButton_Biru_CheckedChanged);
            // 
            // Label_Output
            // 
            this.Label_Output.AutoSize = true;
            this.Label_Output.Location = new System.Drawing.Point(254, 191);
            this.Label_Output.Name = "Label_Output";
            this.Label_Output.Size = new System.Drawing.Size(45, 15);
            this.Label_Output.TabIndex = 9;
            this.Label_Output.Text = "Output";
            // 
            // Label2_Output
            // 
            this.Label2_Output.AutoSize = true;
            this.Label2_Output.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2_Output.Location = new System.Drawing.Point(308, 291);
            this.Label2_Output.Name = "Label2_Output";
            this.Label2_Output.Size = new System.Drawing.Size(98, 30);
            this.Label2_Output.TabIndex = 10;
            this.Label2_Output.Text = "[EMPTY]";
            this.Label2_Output.Click += new System.EventHandler(this.Label2_Output_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(264, 399);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(187, 23);
            this.Button_Clear.TabIndex = 11;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 457);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Label2_Output);
            this.Controls.Add(this.Label_Output);
            this.Controls.Add(this.RadioButton_Biru);
            this.Controls.Add(this.RadioButton_Merah);
            this.Controls.Add(this.CheckBox_Aktif);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.Label_Setting);
            this.Controls.Add(this.Label_Koleksi);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.TxtBox_Data);
            this.Controls.Add(this.Label_Data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.TextBox TxtBox_Data;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Label Label_Koleksi;
        private System.Windows.Forms.Label Label_Setting;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.CheckBox CheckBox_Aktif;
        private System.Windows.Forms.RadioButton RadioButton_Merah;
        private System.Windows.Forms.RadioButton RadioButton_Biru;
        private System.Windows.Forms.Label Label_Output;
        private System.Windows.Forms.Label Label2_Output;
        private System.Windows.Forms.Button Button_Clear;
    }
}
