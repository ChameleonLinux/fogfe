namespace Fog_Editor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.license = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.save_file = new System.Windows.Forms.Button();
            this.open_file_button = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_records = new System.Windows.Forms.Label();
            this.upstream = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.license);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.save_file);
            this.panel1.Controls.Add(this.open_file_button);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 838);
            this.panel1.TabIndex = 0;
            // 
            // license
            // 
            this.license.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.license.Location = new System.Drawing.Point(3, 735);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(403, 42);
            this.license.TabIndex = 5;
            this.license.Text = "(c) 2016 Chameleon OS\r\nlicensed under GPL";
            this.license.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 16.75F);
            this.button2.Location = new System.Drawing.Point(0, 286);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(409, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // save_file
            // 
            this.save_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.save_file.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.save_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.save_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.save_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_file.Font = new System.Drawing.Font("Calibri", 16.75F);
            this.save_file.Location = new System.Drawing.Point(0, 217);
            this.save_file.Name = "save_file";
            this.save_file.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.save_file.Size = new System.Drawing.Size(409, 63);
            this.save_file.TabIndex = 2;
            this.save_file.Text = "Save file";
            this.save_file.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_file.UseVisualStyleBackColor = false;
            this.save_file.Click += new System.EventHandler(this.save_file_Click);
            // 
            // open_file_button
            // 
            this.open_file_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.open_file_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.open_file_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.open_file_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.open_file_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_file_button.Font = new System.Drawing.Font("Calibri", 16.75F);
            this.open_file_button.Location = new System.Drawing.Point(0, 148);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.open_file_button.Size = new System.Drawing.Size(409, 63);
            this.open_file_button.TabIndex = 1;
            this.open_file_button.Text = "Open file";
            this.open_file_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.open_file_button.UseVisualStyleBackColor = false;
            this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(36, 37);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(185, 78);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "FogFE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Destination,
            this.Type,
            this.Filename});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(427, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1029, 595);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Filename";
            this.Filename.Name = "Filename";
            // 
            // total_records
            // 
            this.total_records.AutoSize = true;
            this.total_records.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.total_records.Location = new System.Drawing.Point(426, 810);
            this.total_records.Name = "total_records";
            this.total_records.Size = new System.Drawing.Size(109, 19);
            this.total_records.TabIndex = 2;
            this.total_records.Text = "Total records: 0";
            // 
            // upstream
            // 
            this.upstream.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upstream.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.upstream.Location = new System.Drawing.Point(511, 613);
            this.upstream.Name = "upstream";
            this.upstream.Size = new System.Drawing.Size(184, 20);
            this.upstream.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.label1.Location = new System.Drawing.Point(429, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upstream:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1357, 613);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "New record";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.fog";
            this.openFileDialog1.Title = "Select file to open";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Choose where to save your fog file";
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1468, 838);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upstream);
            this.Controls.Add(this.total_records);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Fog File Editor (none)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button open_file_button;
        private System.Windows.Forms.Label license;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save_file;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label total_records;
        private System.Windows.Forms.TextBox upstream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

