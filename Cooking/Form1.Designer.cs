namespace Cooking
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.ListBoxNotes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxBookmarks = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.buttonSpr = new System.Windows.Forms.Button();
            this.buttonAboutProg = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 569);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.txtNote);
            this.tabPage1.Controls.Add(this.ListBoxNotes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1109, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заметки";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 38);
            this.button8.TabIndex = 6;
            this.button8.Text = "К главному окну";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(568, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 42);
            this.button7.TabIndex = 5;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(204, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(557, 285);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.White;
            this.txtNote.Location = new System.Drawing.Point(204, 25);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(557, 20);
            this.txtNote.TabIndex = 1;
            // 
            // ListBoxNotes
            // 
            this.ListBoxNotes.BackColor = System.Drawing.Color.White;
            this.ListBoxNotes.FormattingEnabled = true;
            this.ListBoxNotes.Location = new System.Drawing.Point(7, 59);
            this.ListBoxNotes.Name = "ListBoxNotes";
            this.ListBoxNotes.Size = new System.Drawing.Size(190, 329);
            this.ListBoxNotes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.listBoxBookmarks);
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск рецептов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(216, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "Добавить закладку";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 34);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "Удалить закладку";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Переименовать закладку";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnSearchRecipes_Click);
            // 
            // listBoxBookmarks
            // 
            this.listBoxBookmarks.FormattingEnabled = true;
            this.listBoxBookmarks.Location = new System.Drawing.Point(7, 72);
            this.listBoxBookmarks.Name = "listBoxBookmarks";
            this.listBoxBookmarks.Size = new System.Drawing.Size(284, 511);
            this.listBoxBookmarks.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(297, 33);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(804, 550);
            this.webBrowser1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(7, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1025, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 6;
            this.button9.Text = "Стили";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonRes
            // 
            this.buttonRes.BackColor = System.Drawing.Color.Linen;
            this.buttonRes.Location = new System.Drawing.Point(49, 593);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(75, 39);
            this.buttonRes.TabIndex = 1;
            this.buttonRes.Text = "Рецепты";
            this.buttonRes.UseVisualStyleBackColor = false;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // buttonSpr
            // 
            this.buttonSpr.BackColor = System.Drawing.Color.Linen;
            this.buttonSpr.Location = new System.Drawing.Point(146, 593);
            this.buttonSpr.Name = "buttonSpr";
            this.buttonSpr.Size = new System.Drawing.Size(75, 39);
            this.buttonSpr.TabIndex = 2;
            this.buttonSpr.Text = "Справка";
            this.buttonSpr.UseVisualStyleBackColor = false;
            this.buttonSpr.Click += new System.EventHandler(this.buttonSpr_Click);
            // 
            // buttonAboutProg
            // 
            this.buttonAboutProg.BackColor = System.Drawing.Color.Linen;
            this.buttonAboutProg.Location = new System.Drawing.Point(245, 593);
            this.buttonAboutProg.Name = "buttonAboutProg";
            this.buttonAboutProg.Size = new System.Drawing.Size(90, 39);
            this.buttonAboutProg.TabIndex = 3;
            this.buttonAboutProg.Text = "О программе";
            this.buttonAboutProg.UseVisualStyleBackColor = false;
            this.buttonAboutProg.Click += new System.EventHandler(this.buttonAboutProg_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Linen;
            this.buttonExit.Location = new System.Drawing.Point(356, 593);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 39);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.Resize += new System.EventHandler(this.buttonExit_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1129, 644);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAboutProg);
            this.Controls.Add(this.buttonSpr);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Кулинария";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ListBox ListBoxNotes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox listBoxBookmarks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Button buttonSpr;
        private System.Windows.Forms.Button buttonAboutProg;
        private System.Windows.Forms.Button buttonExit;
    }
}

