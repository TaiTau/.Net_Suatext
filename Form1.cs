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
using System.Reflection;
using System.Security.Policy;
using System.Collections;
using System.Linq;

namespace Tesseract
{
    public partial class Form1 : Form
    {
        
        
        public string result1;
        public string[] arr2 = new string[100];
        public int j=0;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        public String[] GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound.ToArray();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {

            

            ///dưới này là code của tài
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.jpg", SearchOption.AllDirectories);
                    foreach (string fileName in files)
                    {
                        ListLineImage.Items.Add(fileName);
                    }
                    
   
                }
               
            }
  
            string filePath = @"D:/Tesseract/data/segment2/image_check.txt";

            string[] lines;
            string str;

            if (System.IO.File.Exists(filePath))
            {
                lines = System.IO.File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    
                    ListLineImage.Items.Remove(lines[i]);
                }

            }
            else
            {
                MessageBox.Show("File does not exist");
            }

            
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            string path2 = @"D:/Tesseract/data/segment2/image_check.txt";
            while (arr2[0] != "")
            {
                using (StreamWriter sw = new StreamWriter(path2, true))
                {
                    sw.WriteLine(arr2[j - 1].ToString());
                }
                arr2[j - 1] = "";
                j = j - 1;
            }
            j = j + 1;
            this.Close();
        }

        public void listBox1_Click(object sender, EventArgs e)
        {         
            //result1 = Path.GetFileNameWithoutExtension(ListLineImage.SelectedItem.ToString());// bỏ đuôi
            if (ListLineImage.SelectedItems.Count == 0)
            {
                MessageBox.Show("chưa chọn item");
            }
            else
            {           
                result1 = Path.GetFileNameWithoutExtension(ListLineImage.SelectedItem.ToString());// bỏ đuôi
                string path = ListLineImage.SelectedItem.ToString();  

                Image img = Image.FromFile(path);
                ptb1.Image = img;          

                //////xuất file txt
                string filePath = @"D:/Tesseract/data/segment2/" + result1 + ".txt";
                string str;

                if (System.IO.File.Exists(filePath))
                {
                    str = System.IO.File.ReadAllText(filePath);
                    textBox1.Text = str;
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.Focus();
                }
                else
                {
                   MessageBox.Show("File does not exist");
                }
                

            }
            
             
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListLineImage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btDel_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox1.Focus();
                if (ListLineImage.SelectedItems.Count == 0)
                {
                    MessageBox.Show("chưa chọn item");
                }
                else
                {
                    string result1 = Path.GetFileNameWithoutExtension(ListLineImage.SelectedItem.ToString());// bỏ đuôi
                    string path1 = ListLineImage.SelectedItem.ToString();
                    string path2 = @"D:/Tesseract/data/segment2/image_check.txt";
                    string fileLPath = @"D:/Tesseract/data/segment2/" + result1 + ".txt";
                    string str;
                    str = textBox1.Text;
                    System.IO.File.WriteAllText(fileLPath, str);


                    if (ListLineImage.SelectedItems.Count != 0)
                    {  
                        arr2[j] = ListLineImage.SelectedItem.ToString();
                        ListLineImage.Items.Remove(ListLineImage.SelectedItems[0]);
                        ListImagePass.Items.Add(path1);
                        j = j + 1;
                    }

                    ListLineImage.SelectedIndex = 0;
                    Image img2 = Image.FromFile(ListLineImage.SelectedItem.ToString());
                    ptb1.Image = img2;

                    //////xuất file txt

                    string str2;
                    string result2 = Path.GetFileNameWithoutExtension(ListLineImage.SelectedItem.ToString());// bỏ đuôi
                    string filePath2 = @"D:/Tesseract/data/segment2/" + result2 + ".txt";
                    if (System.IO.File.Exists(filePath2))
                    {
                        str2 = System.IO.File.ReadAllText(filePath2);
                        textBox1.Text = str2;
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("File does not exist");
                    }


                }

            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            

            if (ListImagePass.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn Item");
            }
            else
            {
                ListLineImage.Items.Add(ListImagePass.SelectedItem);
                ListImagePass.Items.Remove(ListImagePass.SelectedItem);
            }

        }
    }
}
