using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using bouncingBall;
using System.Diagnostics;





namespace PtAssignment
{
    public partial class Form1 : Form
    {
        String conStr;
        OleDbConnection dbConnection = new OleDbConnection();
        int count=0;
        List<string> list = new List<string>();
        int imgCount = 0;
        public static Image photo = null;
        public static string[] formdata;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void Form1_Load(object sednder, EventArgs e)
        {
            //------------------------tab 3 ----------------
            conStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\harik\Documents\PtAssignDB.mdb";
            dbConnection.ConnectionString = conStr;
            dbConnection.Open();
            dbConnection.Close();
            
            string cmdStr = "Select * from Books";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdStr, conStr);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            //---------------

            //-------------tab 1 -- bounce
           
            //f.MdiParent = this;
           // f.Show();

            ///---------------
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnection.Open();
                OleDbCommand dbCommand = new OleDbCommand();
                dbCommand.Connection = dbConnection;
                dbCommand.CommandText = textBox1.Text;
                if (comboBox1.Text == "Retrieval")
                {
                    
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(textBox1.Text, conStr);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    MessageBox.Show("Successfully Executed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (comboBox1.Text == "Insert" || comboBox1.Text == "Deletion" || comboBox1.Text=="Update")
                {
                    //INSERT into Books  (id, title, author1, author2 , subject) VALUES('1234', 'Java 2', 'Balaguru',' ' , 'CSE')
                    //DELETE FROM Books WHERE (id = '123')
                    //UPDATE Books SET ( title ='C#')  WHERE (id = '12')
                    int i1 = dbCommand.ExecuteNonQuery();
                    if (i1==1)
                     MessageBox.Show("Successfully Executed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                     MessageBox.Show("Error in code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

              // if (comboBox1.Text == "Update"){
                    //update table Books (id, title, author1, author2 , subject) VALUES('1234', 'Java 2', 'Balaguru',' ' , 'CSE')  WHERE (id = '123'); }


            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }dbConnection.Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           // tabControl1.Size = new Size(this.ClientSize.Width-20, this.ClientSize.Height-20);
            //dataGridView1.Size= new Size(this.ClientSize.Width - 100, this.ClientSize.Height - 50);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string cmdStr = "Select * from Books";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdStr, conStr);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            if(radioButton1.Checked) 
            {
                label7.Text = "-result-";
                label7.BackColor = Color.Transparent;
                if (radioButton7.Checked)
                {
                    label7.Text = "Correct";
                    label7.BackColor = Color.LightGreen;
                    //tabPage1.BackColor = Color.Green;
                    radioButton1.Enabled = false;
                    radioButton7.Enabled = false;
                }

                else
                {
                    label7.Text = "Incorrect";
                    label7.BackColor = Color.IndianRed;
                }
                    
            }
            if (radioButton2.Checked)
            {
                label7.Text = "-result-";
                label7.BackColor = Color.Transparent;
                if (radioButton10.Checked)
                {
                    label7.Text = "Correct";
                    label7.BackColor = Color.LightGreen;
                    radioButton2.Enabled = false;
                    radioButton10.Enabled = false;
                }
                else
                {
                    label7.Text = "Incorrect";
                    label7.BackColor = Color.IndianRed;
                }
            }
            if (radioButton3.Checked)
            {
                label7.Text = "-result-";
                label7.BackColor = Color.Transparent;
                if (radioButton9.Checked)
                {
                    label7.Text = "Correct";
                    label7.BackColor = Color.LightGreen;
                    radioButton3.Enabled = false;
                    radioButton9.Enabled = false;
                }
                else
                {
                    label7.Text = "Incorrect";
                    label7.BackColor = Color.IndianRed;
                }
            }
            if (radioButton4.Checked)
            {
                label7.Text = "-result-";
                label7.BackColor = Color.Transparent;
                if (radioButton6.Checked)
                {
                    label7.Text = "Correct";
                    label7.BackColor = Color.LightGreen;
                    radioButton4.Enabled = false;
                    radioButton6.Enabled = false;
                }
                else
                {
                    label7.Text = "Incorrect";
                    label7.BackColor = Color.IndianRed;
                }
            }
            if (radioButton5.Checked)
            {
                label7.Text = "-result-";
                label7.BackColor = Color.Transparent;
                if (radioButton8.Checked)
                {
                    label7.Text = "Correct";
                    label7.BackColor = Color.LightGreen;
                    radioButton5.Enabled = false;
                    radioButton8.Enabled = false;
                }
                else
                {
                    label7.Text = "Incorrect";
                    label7.BackColor = Color.IndianRed;
                }
            }

            label9.Text = count+"";//converting int to string
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "-result-";
            label7.BackColor = Color.Transparent;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "-result-";
            label7.BackColor = Color.Transparent;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "-result-";
            label7.BackColor = Color.Transparent;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "-result-";
            label7.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (radioButton11.Checked) temp = radioButton11.Text;
            else if (radioButton12.Checked) temp = radioButton12.Text;
            else if (radioButton13.Checked) temp = radioButton13.Text;
            if (textBox7.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || temp == "" || textBox6.Text == "")
                MessageBox.Show("One or more fields are empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            photo = pictureBox1.Image;
            if (photo == null)
            {
                MessageBox.Show("Select a photo.", "No photo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                formdata = new string[] { textBox7.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, temp, textBox6.Text };
                Form2 f = new Form2();
                f.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.jpg, *.jpeg, *.png)|*.jpg| *.jpeg| *.png";
            //dlg.Multiselect = true;
            dlg.ShowDialog();
            String img = dlg.FileName;
            /*
            foreach(string f in files)
            {
                List.add(f);
            }*/
            pictureBox1.ImageLocation = img;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please choose multile images";
            ofd.Multiselect = true;
            ofd.Filter = "(*.jpg, *.jpeg, *.png)|*.jpg| *.jpeg| *.png";
            ofd.ShowDialog();

            string[] files = ofd.FileNames;

            foreach(string f in files)
            {
                list.Add(f);
            }

            pictureBox2.Image = new Bitmap(list[imgCount]);
            imgCount++;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(imgCount == 0)
            {
                imgCount = list.Count - 1;
            }
            pictureBox2.Image = new Bitmap(list[imgCount]);
            imgCount--;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (imgCount == list.Count-1)
            {
                imgCount =0;
            }
            pictureBox2.Image = new Bitmap(list[imgCount]);
            imgCount++;
        }

       

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void strechedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void centreImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            //f3.MdiParent = this;
            f3.Show();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8)
            {
                MessageBox.Show("Dont Enter alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox4.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains('@') || !textBox2.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch))
            {
                MessageBox.Show("Please enter valid name.", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox7.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
                button6.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                button6.Text = "Auto play";
            }

        }
     

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imgCount == list.Count - 1)
            {
                imgCount = 0;
            }
            pictureBox2.Image = new Bitmap(list[imgCount]);
            imgCount++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bouncingBall.Form1 f = new bouncingBall.Form1();
            f.Show();
        }

        private void runTheProgramFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.RuntimeTypeHandle H;
            System.Diagnostics.Process p1 = new Process();
            Process secondProc = new Process();
            secondProc.StartInfo.FileName = @"C:\Users\harik\source\repos\bouncingBall\bouncingBall\bin\Debug\bouncingBall.exe";
            secondProc.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
