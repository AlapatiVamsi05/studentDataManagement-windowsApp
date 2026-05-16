namespace dbops_sql
{
    partial class StudentForm
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
            this.sid = new System.Windows.Forms.Label();
            this.stuIdTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.mobile = new System.Windows.Forms.Label();
            this.stuData = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.UpdBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stuData)).BeginInit();
            this.SuspendLayout();
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.Location = new System.Drawing.Point(40, 53);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(68, 16);
            this.sid.TabIndex = 0;
            this.sid.Text = "Student ID";
            this.sid.Click += new System.EventHandler(this.label1_Click);
            // 
            // stuIdTxt
            // 
            this.stuIdTxt.Location = new System.Drawing.Point(127, 47);
            this.stuIdTxt.Name = "stuIdTxt";
            this.stuIdTxt.Size = new System.Drawing.Size(235, 22);
            this.stuIdTxt.TabIndex = 1;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(127, 105);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(235, 22);
            this.nameTxt.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(40, 111);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(47, 16);
            this.name.TabIndex = 2;
            this.name.Text = "Name ";
            this.name.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(127, 168);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(235, 22);
            this.emailTxt.TabIndex = 5;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(40, 174);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(40, 16);
            this.email.TabIndex = 4;
            this.email.Text = "email";
            // 
            // mobileTxt
            // 
            this.mobileTxt.Location = new System.Drawing.Point(127, 231);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(235, 22);
            this.mobileTxt.TabIndex = 7;
            this.mobileTxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Location = new System.Drawing.Point(40, 237);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(51, 16);
            this.mobile.TabIndex = 6;
            this.mobile.Text = "Mobile ";
            this.mobile.Click += new System.EventHandler(this.label4_Click);
            // 
            // stuData
            // 
            this.stuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuData.Location = new System.Drawing.Point(406, 47);
            this.stuData.Name = "stuData";
            this.stuData.RowHeadersWidth = 51;
            this.stuData.RowTemplate.Height = 24;
            this.stuData.Size = new System.Drawing.Size(358, 321);
            this.stuData.TabIndex = 8;
            this.stuData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stuData_CellContentClick);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Green;
            this.addBtn.Location = new System.Drawing.Point(37, 332);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 36);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add Record";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Red;
            this.delBtn.Location = new System.Drawing.Point(153, 332);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(91, 36);
            this.delBtn.TabIndex = 10;
            this.delBtn.Text = "Delete Record";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdBtn
            // 
            this.UpdBtn.BackColor = System.Drawing.Color.Blue;
            this.UpdBtn.Location = new System.Drawing.Point(271, 332);
            this.UpdBtn.Name = "UpdBtn";
            this.UpdBtn.Size = new System.Drawing.Size(91, 36);
            this.UpdBtn.TabIndex = 11;
            this.UpdBtn.Text = "Update Record";
            this.UpdBtn.UseVisualStyleBackColor = false;
            this.UpdBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clrBtn.ForeColor = System.Drawing.Color.Black;
            this.clrBtn.Location = new System.Drawing.Point(156, 399);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(120, 30);
            this.clrBtn.TabIndex = 12;
            this.clrBtn.Text = "Clear Entered data";
            this.clrBtn.UseVisualStyleBackColor = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.UpdBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.stuData);
            this.Controls.Add(this.mobileTxt);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.name);
            this.Controls.Add(this.stuIdTxt);
            this.Controls.Add(this.sid);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.TextBox stuIdTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.DataGridView stuData;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button UpdBtn;
        private System.Windows.Forms.Button clrBtn;
    }
}

