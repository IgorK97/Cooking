using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace Cooking
{
    enum State
    {
        StartMenu=0,
        Note=2,
        AboutProgram=3,
        MainWindow,
        Recipies,
        Styles,
        AddingStar
    }
    public partial class Form1 : Form
    {
        List<string> recipeNotes = new List<string>();
        List<string> bookmarks = new List<string>();
        State state;
        Form2 formAddStar;
        Form4 formSpr;
        Form5 formAboutProg;
        Form6 formStyles;
        public Form1()
        {
            InitializeComponent();
            int BrowserVer, RegVal;
            state = State.StartMenu;
            // get the installed IE version
            //using (WebBrowser Wb = new WebBrowser())
                BrowserVer = webBrowser1.Version.Major;

            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key
            using (RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree))
                if (Key.GetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe") == null)
                    Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
            webBrowser1.ScriptErrorsSuppressed = true;
            buttonRes.Height = this.Size.Height / 10;
            buttonSpr.Height = this.Size.Height / 10;
            buttonAboutProg.Height = this.Size.Height / 10;
            buttonExit.Height = this.Size.Height / 10;
            buttonRes.Width = this.Size.Width / 5;
            buttonSpr.Width = this.Size.Width / 5;
            buttonAboutProg.Width = this.Size.Width / 5;
            buttonExit.Width = this.Size.Width / 5;
            buttonRes.Location = new Point(this.Size.Width / 2 - buttonRes.Width / 2, this.Size.Height / 10);
            buttonSpr.Location = new Point(this.Size.Width / 2 - buttonRes.Width / 2, this.Size.Height / 10*3);
            buttonAboutProg.Location = new Point(this.Size.Width / 2 - buttonRes.Width / 2, this.Size.Height / 10*5);
            buttonExit.Location = new Point(this.Size.Width / 2 - buttonRes.Width / 2, this.Size.Height / 10*7);
            tabControl1.Height = this.Height - 60;
            tabControl1.Width = this.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecipeNotes();
            LoadBookmarks();
        }
        private void LoadRecipeNotes()
        {
            if (File.Exists("notes.txt"))
            {
                recipeNotes.AddRange(File.ReadAllLines("recipeNotes.txt"));
                ListBoxNotes.DataSource=new BindingSource(recipeNotes,null);
            }
        }

        private void LoadBookmarks()
        {
            if (File.Exists("bookmarks.txt"))
            {
                bookmarks.AddRange(File.ReadAllLines("bookmarks.txt"));
                listBoxBookmarks.DataSource = new BindingSource(bookmarks, null);
            }
        }

        private void SaveRecipeNotes()
        {
            File.WriteAllLines("notes.txt", recipeNotes);
        }

        private void SaveBookmarks()
        {
            File.WriteAllLines("bookmarks.txt", bookmarks);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNote.Text))
            {
                recipeNotes.Add(txtNote.Text);
                ListBoxNotes.DataSource = new BindingSource(recipeNotes, null);
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if (ListBoxNotes.SelectedItem != null)
            {
                recipeNotes.Remove(ListBoxNotes.SelectedItem.ToString());
                ListBoxNotes.DataSource = new BindingSource(recipeNotes, null);
                SaveRecipeNotes();
            }
        }

        private void btnSearchRecipes_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            if (!string.IsNullOrWhiteSpace(query))
            {
                webBrowser1.Navigate("https://www.povarenok.ru/recipes/poisk/" + query);
            }
        }
        private void btnBookmark_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Url != null)
            {
                bookmarks.Add(webBrowser1.Url.ToString());
                listBoxBookmarks.DataSource = new BindingSource(bookmarks, null);
                SaveBookmarks();
            }
            else
            {
                MessageBox.Show("No pageis currently loaded to bookmark.");
            }
        }

        private void tnOpenBookmark_Click(object sender, EventArgs e)
        {
            if (listBoxBookmarks.SelectedItem != null)
            {
                webBrowser1.Navigate(listBoxBookmarks.SelectedItem.ToString());
            }
        }

        private void btnDeleteBookmark_Click(object sender, EventArgs e)
        {
            if (listBoxBookmarks.SelectedItem != null)
            {
                bookmarks.Remove(listBoxBookmarks.SelectedItem.ToString());
                listBoxBookmarks.DataSource = new BindingSource(bookmarks, null);
                SaveBookmarks();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com");
        }

        private void buttonExit_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (state == State.StartMenu)
            {
                buttonRes.Height = this.Size.Height / 10;
                buttonSpr.Height = this.Size.Height / 10;
                buttonAboutProg.Height = this.Size.Height / 10;
                buttonExit.Height = this.Size.Height / 10;
                buttonRes.Width = this.Size.Width / 5;
                buttonSpr.Width = this.Size.Width / 5;
                buttonAboutProg.Width = this.Size.Width / 5;
                buttonExit.Width = this.Size.Width / 5;
                buttonRes.Location = new Point(this.Size.Width / 2 - buttonRes.Width / 2, this.Size.Height / 10);
                buttonSpr.Location = new Point(this.Size.Width / 2 - buttonRes.Width / 2, this.Size.Height / 10 * 3);
                buttonAboutProg.Location = new Point(this.Size.Width / 2 - buttonRes.Width / 2, this.Size.Height / 10 * 5);
                buttonExit.Location = new Point(this.Size.Width / 2 - buttonRes.Width / 2, this.Size.Height / 10 * 7);
            }
            else
            {
                tabControl1.Height = this.Height-60;
                tabControl1.Width = this.Width;
            }
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            state = State.MainWindow;
            buttonRes.Visible = false;
            buttonAboutProg.Visible = false;
            buttonSpr.Visible = false;
            buttonExit.Visible = false;
            buttonRes.Enabled = false;
            buttonAboutProg.Enabled = false;
            buttonSpr.Enabled = false;
            buttonExit.Enabled = false;
            tabControl1.Enabled = true;
            tabControl1.Visible = true;
        }

        private void buttonSpr_Click(object sender, EventArgs e)
        {
            formSpr = new Form4();
            formSpr.ShowDialog();
        }

        private void buttonAboutProg_Click(object sender, EventArgs e)
        {
            formAboutProg = new Form5();
            formAboutProg.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            state = State.StartMenu;
            state = State.MainWindow;
            buttonRes.Visible = true;
            buttonAboutProg.Visible = true;
            buttonSpr.Visible = true;
            buttonExit.Visible = true;
            buttonRes.Enabled = true;
            buttonAboutProg.Enabled = true;
            buttonSpr.Enabled = true;
            buttonExit.Enabled = true;
            tabControl1.Enabled = false;
            tabControl1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            formStyles = new Form6();
            formStyles.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formAddStar = new Form2();
            formAddStar.ShowDialog();
        }
    }
}
