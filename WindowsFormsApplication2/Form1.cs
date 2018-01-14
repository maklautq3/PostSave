using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        CookieContainer container = new CookieContainer();
        List<string> ObjIDUrl = new List<string>();
        String targetObjUrl;
        String targetObjId;
        String DirPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            DirPath= Directory.GetCurrentDirectory();


        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            MessageBox.Show(HTTPDashboardRequest.Siteauthorization(container));
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = DirPath;
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            richTextBox2.Text = Helper.TaskSave(targetObjId, openFileDialog1.FileName, richTextBox3.Text);
            btnPostSave.Enabled = true;


        }

        private void btnGetAnon_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText(HTTPDashboardRequest.Siteauthorization(container));
            List<string> comboboxID = new List<string>();
            richTextBox1.AppendText(HTTPDashboardRequest.FindAnon(tbIdAnon.Text, container, out comboboxID, out ObjIDUrl));
            cbAnonList.Items.AddRange(comboboxID.ToArray());
            if(comboboxID.Count>0)
            {
                cbAnonList.Enabled = true;
                btnSaveId.Enabled = true;
            }
        }

        private void cbAnonList_SelectedIndexChanged(object sender, EventArgs e)
        {

            int t = cbAnonList.SelectedIndex;
            targetObjUrl = ObjIDUrl[t];
            targetObjId = targetObjUrl.Substring(27);
            targetObjId = targetObjId.Substring(0, 24);
            grbSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("\n"+HTTPDashboardRequest.Siteauthorization(container));
            richTextBox1.AppendText("\n"+HTTPDashboardRequest.EditSave(container, richTextBox2.Text,targetObjUrl));
            richTextBox2.Clear();
        }

        private void btnSaveId_Click(object sender, EventArgs e)
        {
            int t = cbAnonList.SelectedIndex;
            targetObjUrl = ObjIDUrl[t];
            targetObjId = targetObjUrl.Substring(27);
            targetObjId = targetObjId.Substring(0,24);
            Properties.Settings.Default.ObjIDUrl = targetObjUrl;
            Properties.Settings.Default.ObjID = targetObjId;
            Properties.Settings.Default.Save();
            tbDefaultID.Text = Properties.Settings.Default.ObjID;
            Form1.ActiveForm.Text = Properties.Settings.Default.ObjID;



        }

        private void btnUseDefaultID_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.ObjID!= String.Empty)
            {
                grbSave.Enabled = true;
                tbDefaultID.Text = Properties.Settings.Default.ObjID;
                targetObjUrl = Properties.Settings.Default.ObjIDUrl;
                targetObjId  = Properties.Settings.Default.ObjID;
            }
        }

        private void cbChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(DirPath);
            // Для извлечения имени файла используется цикл foreach и свойство files.name
            foreach (FileInfo files in dir.GetFiles())
            {
                if(files.Name.Contains(cbChapters.Text)) cbTasks.Items.Add(files.Name);
            }


            //var files = Directory.GetFiles(DirPath, "*.*").Where(s => s.Contains(cbChapters.Text));
            //cbTasks.Items.AddRange(files.ToArray());

        }

        private void cbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

            richTextBox2.Text = Helper.TaskSave(targetObjId, DirPath + "/" + cbTasks.Text, richTextBox3.Text);
            btnPostSave.Enabled = true;
            
        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void chbEditRE_CheckedChanged(object sender, EventArgs e)
        {
            if (chbEditRE.Checked == true) richTextBox2.ReadOnly = false;
            else richTextBox2.ReadOnly = true;

        }
    }
    }

