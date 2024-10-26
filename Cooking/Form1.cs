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
    public partial class Form1 : Form
    {
        List<string> recipeNotes = new List<string>();
        List<string> bookmarks = new List<string>();
        public Form1()
        {
            InitializeComponent();
            int BrowserVer, RegVal;

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
                webBrowser1.Navigate("https://www.foodwebsite.com/search?q=" + query);
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
    }
}
