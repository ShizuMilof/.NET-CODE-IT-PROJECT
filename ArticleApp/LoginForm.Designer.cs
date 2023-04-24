namespace ArticleApp
{
    partial class LoginForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxUsername1 = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTUDENTI_PINDataSet3 = new ArticleApp.STUDENTI_PINDataSet3();
            this.aAusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aA_usersTableAdapter = new ArticleApp.STUDENTI_PINDataSet3TableAdapters.AA_usersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTI_PINDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAusersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.CausesValidation = false;
            this.textBoxUsername1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUsername1.Location = new System.Drawing.Point(282, 151);
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.Size = new System.Drawing.Size(187, 20);
            this.textBoxUsername1.TabIndex = 0;
            this.textBoxUsername1.TabStop = false;
            this.textBoxUsername1.Text = "Username";
            this.textBoxUsername1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassword.Location = new System.Drawing.Point(282, 201);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(187, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "LoginForm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(486, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Novi korisnik ? Registriraj se!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.usertypeidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aAusersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // sTUDENTI_PINDataSet3
            // 
            this.sTUDENTI_PINDataSet3.DataSetName = "STUDENTI_PINDataSet3";
            this.sTUDENTI_PINDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aAusersBindingSource
            // 
            this.aAusersBindingSource.DataMember = "AA_users";
            this.aAusersBindingSource.DataSource = this.sTUDENTI_PINDataSet3;
            // 
            // aA_usersTableAdapter
            // 
            this.aA_usersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // usertypeidDataGridViewTextBoxColumn
            // 
            this.usertypeidDataGridViewTextBoxColumn.DataPropertyName = "user_type_id";
            this.usertypeidDataGridViewTextBoxColumn.HeaderText = "user_type_id";
            this.usertypeidDataGridViewTextBoxColumn.Name = "usertypeidDataGridViewTextBoxColumn";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTI_PINDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aAusersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxUsername1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private STUDENTI_PINDataSet3 sTUDENTI_PINDataSet3;
        private System.Windows.Forms.BindingSource aAusersBindingSource;
        private STUDENTI_PINDataSet3TableAdapters.AA_usersTableAdapter aA_usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeidDataGridViewTextBoxColumn;
    }
}

