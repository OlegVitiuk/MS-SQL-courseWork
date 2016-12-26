namespace course
{
    partial class group
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.deputsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBestDataSet = new course.myBestDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deputsTableAdapter = new course.myBestDataSetTableAdapters.deputsTableAdapter();
            this.autrhorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autrhorityTableAdapter = new course.myBestDataSetTableAdapters.autrhorityTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.authorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBestDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myBestDataSet2 = new course.myBestDataSet2();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.authorityTableAdapter = new course.myBestDataSet2TableAdapters.authorityTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deputsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autrhorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBestDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBestDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "deputs";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.deputsBindingSource;
            this.comboBox2.DisplayMember = "surname";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(82, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(112, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.TabStop = false;
            this.comboBox2.ValueMember = "id";
            // 
            // deputsBindingSource
            // 
            this.deputsBindingSource.DataMember = "deputs";
            this.deputsBindingSource.DataSource = this.myBestDataSetBindingSource;
            // 
            // myBestDataSetBindingSource
            // 
            this.myBestDataSetBindingSource.DataSource = this.myBestDataSet;
            this.myBestDataSetBindingSource.Position = 0;
            // 
            // myBestDataSet
            // 
            this.myBestDataSet.DataSetName = "myBestDataSet";
            this.myBestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.deputsBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.TabStop = false;
            this.comboBox1.ValueMember = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Get amount of answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // deputsTableAdapter
            // 
            this.deputsTableAdapter.ClearBeforeFill = true;
            // 
            // autrhorityBindingSource
            // 
            this.autrhorityBindingSource.DataMember = "autrhority";
            this.autrhorityBindingSource.DataSource = this.myBestDataSetBindingSource;
            // 
            // autrhorityTableAdapter
            // 
            this.autrhorityTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "region";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 10;
            this.button2.TabStop = false;
            this.button2.Text = "Get answers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.authorityBindingSource;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(51, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.TabStop = false;
            this.comboBox3.ValueMember = "name";
            // 
            // authorityBindingSource
            // 
            this.authorityBindingSource.DataMember = "authority";
            this.authorityBindingSource.DataSource = this.myBestDataSet2BindingSource;
            // 
            // myBestDataSet2BindingSource
            // 
            this.myBestDataSet2BindingSource.DataSource = this.myBestDataSet2;
            this.myBestDataSet2BindingSource.Position = 0;
            // 
            // myBestDataSet2
            // 
            this.myBestDataSet2.DataSetName = "myBestDataSet2";
            this.myBestDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.authorityBindingSource;
            this.comboBox4.DisplayMember = "type";
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(52, 50);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.TabStop = false;
            this.comboBox4.ValueMember = "id";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.authorityBindingSource;
            this.comboBox5.DisplayMember = "region";
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(52, 79);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 13;
            this.comboBox5.TabStop = false;
            this.comboBox5.ValueMember = "id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(229, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "authority";
            // 
            // authorityTableAdapter
            // 
            this.authorityTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(452, 183);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(91, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.TabStop = false;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.TabStop = false;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(452, 337);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "group";
            this.Text = "group";
            this.Load += new System.EventHandler(this.group_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deputsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autrhorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBestDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBestDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource myBestDataSetBindingSource;
        private myBestDataSet myBestDataSet;
        private System.Windows.Forms.BindingSource deputsBindingSource;
        private myBestDataSetTableAdapters.deputsTableAdapter deputsTableAdapter;
        private System.Windows.Forms.BindingSource autrhorityBindingSource;
        private myBestDataSetTableAdapters.autrhorityTableAdapter autrhorityTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource myBestDataSet2BindingSource;
        private myBestDataSet2 myBestDataSet2;
        private System.Windows.Forms.BindingSource authorityBindingSource;
        private myBestDataSet2TableAdapters.authorityTableAdapter authorityTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}