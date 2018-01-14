namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRead = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbDefaultID = new System.Windows.Forms.TextBox();
            this.btnSaveId = new System.Windows.Forms.Button();
            this.tbIdAnon = new System.Windows.Forms.TextBox();
            this.cbAnonList = new System.Windows.Forms.ComboBox();
            this.btnGetAnon = new System.Windows.Forms.Button();
            this.btnUseDefaultID = new System.Windows.Forms.Button();
            this.grbSave = new System.Windows.Forms.GroupBox();
            this.chbEditRE = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.cbChapters = new System.Windows.Forms.ComboBox();
            this.btnPostSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(6, 95);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(121, 23);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Открыть сохранение";
            this.btnRead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.tbDefaultID);
            this.groupBox1.Controls.Add(this.btnSaveId);
            this.groupBox1.Controls.Add(this.tbIdAnon);
            this.groupBox1.Controls.Add(this.cbAnonList);
            this.groupBox1.Controls.Add(this.btnGetAnon);
            this.groupBox1.Controls.Add(this.btnUseDefaultID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация и выбор ID пользователя";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(426, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(174, 111);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tbDefaultID
            // 
            this.tbDefaultID.Location = new System.Drawing.Point(216, 103);
            this.tbDefaultID.Name = "tbDefaultID";
            this.tbDefaultID.ReadOnly = true;
            this.tbDefaultID.Size = new System.Drawing.Size(204, 20);
            this.tbDefaultID.TabIndex = 12;
            // 
            // btnSaveId
            // 
            this.btnSaveId.Enabled = false;
            this.btnSaveId.Location = new System.Drawing.Point(239, 48);
            this.btnSaveId.Name = "btnSaveId";
            this.btnSaveId.Size = new System.Drawing.Size(164, 21);
            this.btnSaveId.TabIndex = 11;
            this.btnSaveId.Text = "Сохранить ID поумолчанию";
            this.btnSaveId.UseVisualStyleBackColor = true;
            this.btnSaveId.Click += new System.EventHandler(this.btnSaveId_Click);
            // 
            // tbIdAnon
            // 
            this.tbIdAnon.Location = new System.Drawing.Point(133, 22);
            this.tbIdAnon.Name = "tbIdAnon";
            this.tbIdAnon.Size = new System.Drawing.Size(100, 20);
            this.tbIdAnon.TabIndex = 10;
            this.tbIdAnon.Text = "8aec";
            // 
            // cbAnonList
            // 
            this.cbAnonList.Enabled = false;
            this.cbAnonList.FormattingEnabled = true;
            this.cbAnonList.Location = new System.Drawing.Point(6, 48);
            this.cbAnonList.Name = "cbAnonList";
            this.cbAnonList.Size = new System.Drawing.Size(227, 21);
            this.cbAnonList.TabIndex = 9;
            this.cbAnonList.SelectedIndexChanged += new System.EventHandler(this.cbAnonList_SelectedIndexChanged);
            // 
            // btnGetAnon
            // 
            this.btnGetAnon.Location = new System.Drawing.Point(6, 19);
            this.btnGetAnon.Name = "btnGetAnon";
            this.btnGetAnon.Size = new System.Drawing.Size(121, 23);
            this.btnGetAnon.TabIndex = 6;
            this.btnGetAnon.Text = "Найти пользователя";
            this.btnGetAnon.UseVisualStyleBackColor = true;
            this.btnGetAnon.Click += new System.EventHandler(this.btnGetAnon_Click);
            // 
            // btnUseDefaultID
            // 
            this.btnUseDefaultID.Location = new System.Drawing.Point(6, 100);
            this.btnUseDefaultID.Name = "btnUseDefaultID";
            this.btnUseDefaultID.Size = new System.Drawing.Size(195, 23);
            this.btnUseDefaultID.TabIndex = 1;
            this.btnUseDefaultID.Text = "Использовать ID (по умолчанию)";
            this.btnUseDefaultID.UseVisualStyleBackColor = true;
            this.btnUseDefaultID.Click += new System.EventHandler(this.btnUseDefaultID_Click);
            // 
            // grbSave
            // 
            this.grbSave.Controls.Add(this.chbEditRE);
            this.grbSave.Controls.Add(this.richTextBox2);
            this.grbSave.Controls.Add(this.richTextBox3);
            this.grbSave.Controls.Add(this.cbTasks);
            this.grbSave.Controls.Add(this.cbChapters);
            this.grbSave.Controls.Add(this.btnPostSave);
            this.grbSave.Controls.Add(this.btnRead);
            this.grbSave.Enabled = false;
            this.grbSave.Location = new System.Drawing.Point(12, 147);
            this.grbSave.Name = "grbSave";
            this.grbSave.Size = new System.Drawing.Size(606, 470);
            this.grbSave.TabIndex = 10;
            this.grbSave.TabStop = false;
            this.grbSave.Text = "Запись сохранения";
            // 
            // chbEditRE
            // 
            this.chbEditRE.AutoSize = true;
            this.chbEditRE.Location = new System.Drawing.Point(491, 447);
            this.chbEditRE.Name = "chbEditRE";
            this.chbEditRE.Size = new System.Drawing.Size(110, 17);
            this.chbEditRE.TabIndex = 12;
            this.chbEditRE.Text = "Редактирование";
            this.chbEditRE.UseVisualStyleBackColor = true;
            this.chbEditRE.CheckedChanged += new System.EventHandler(this.chbEditRE_CheckedChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(166, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(434, 424);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged_1);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(166, 233);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(434, 210);
            this.richTextBox3.TabIndex = 10;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // cbTasks
            // 
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(6, 46);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(121, 21);
            this.cbTasks.TabIndex = 9;
            this.cbTasks.SelectedIndexChanged += new System.EventHandler(this.cbTasks_SelectedIndexChanged);
            // 
            // cbChapters
            // 
            this.cbChapters.FormattingEnabled = true;
            this.cbChapters.Items.AddRange(new object[] {
            "Chapter1",
            "Chapter2",
            "Chapter3",
            "Chapter4",
            "Chapter5",
            "Chapter6",
            "Chapter7",
            "Chapter8",
            "Chapter9",
            "Chapter10",
            "Chapter11",
            "Chapter12"});
            this.cbChapters.Location = new System.Drawing.Point(6, 19);
            this.cbChapters.Name = "cbChapters";
            this.cbChapters.Size = new System.Drawing.Size(121, 21);
            this.cbChapters.TabIndex = 8;
            this.cbChapters.SelectedIndexChanged += new System.EventHandler(this.cbChapters_SelectedIndexChanged);
            // 
            // btnPostSave
            // 
            this.btnPostSave.Enabled = false;
            this.btnPostSave.Location = new System.Drawing.Point(6, 375);
            this.btnPostSave.Name = "btnPostSave";
            this.btnPostSave.Size = new System.Drawing.Size(154, 68);
            this.btnPostSave.TabIndex = 4;
            this.btnPostSave.Text = "Запись сохранения";
            this.btnPostSave.UseVisualStyleBackColor = true;
            this.btnPostSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 622);
            this.Controls.Add(this.grbSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PostSaver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbSave.ResumeLayout(false);
            this.grbSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAnonList;
        private System.Windows.Forms.Button btnGetAnon;
        private System.Windows.Forms.Button btnUseDefaultID;
        private System.Windows.Forms.TextBox tbIdAnon;
        private System.Windows.Forms.GroupBox grbSave;
        private System.Windows.Forms.Button btnPostSave;
        private System.Windows.Forms.Button btnSaveId;
        private System.Windows.Forms.TextBox tbDefaultID;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbChapters;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.CheckBox chbEditRE;
    }
}

