namespace ArticleApp
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAArticleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.aAarticlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aAarticlesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTI_PINDataSet2 = new ArticleApp.STUDENTI_PINDataSet2();
            this.aAarticleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aA_articleTableAdapter = new ArticleApp.STUDENTI_PINDataSet2TableAdapters.AA_articleTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAArticleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAarticlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAarticlesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTI_PINDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAarticleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCreated,
            this.Title,
            this.ArticleType,
            this.User,
            this.Id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(33, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(604, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // DateCreated
            // 
            this.DateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCreated.DataPropertyName = "DateCreated";
            this.DateCreated.HeaderText = "DATUM";
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.ReadOnly = true;
            this.DateCreated.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "NASLOV";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ArticleType
            // 
            this.ArticleType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArticleType.DataPropertyName = "ArticleType";
            this.ArticleType.HeaderText = "TIP";
            this.ArticleType.Name = "ArticleType";
            this.ArticleType.ReadOnly = true;
            this.ArticleType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "KORISNIK";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            this.Id.Width = 41;
            // 
            // aAArticleBindingSource
            // 
            this.aAArticleBindingSource.DataMember = "AA_Article";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "UREDI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "BRIŠI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // aAarticlesBindingSource
            // 
            this.aAarticlesBindingSource.DataMember = "AA_articles";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DATUM",
            "NASLOV",
            "TIP",
            "KORISNIK"});
            this.comboBox1.Location = new System.Drawing.Point(33, 397);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(258, 396);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(506, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 24);
            this.button4.TabIndex = 6;
            this.button4.Text = "PRETRAŽI";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // aAarticlesBindingSource1
            // 
            this.aAarticlesBindingSource1.DataMember = "AA_articles";
            // 
            // sTUDENTI_PINDataSet2
            // 
            this.sTUDENTI_PINDataSet2.DataSetName = "STUDENTI_PINDataSet2";
            this.sTUDENTI_PINDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aAarticleBindingSource1
            // 
            this.aAarticleBindingSource1.DataMember = "AA_article";
            this.aAarticleBindingSource1.DataSource = this.sTUDENTI_PINDataSet2;
            // 
            // aA_articleTableAdapter
            // 
            this.aA_articleTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button5.Location = new System.Drawing.Point(700, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 21);
            this.button5.TabIndex = 11;
            this.button5.Text = "BACK TO LOGIN FORM";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAArticleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAarticlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAarticlesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTI_PINDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAarticleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource aAarticlesBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource aAarticlesBindingSource1;
        private System.Windows.Forms.BindingSource aAArticleBindingSource;
        private STUDENTI_PINDataSet2 sTUDENTI_PINDataSet2;
        private System.Windows.Forms.BindingSource aAarticleBindingSource1;
        private STUDENTI_PINDataSet2TableAdapters.AA_articleTableAdapter aA_articleTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}