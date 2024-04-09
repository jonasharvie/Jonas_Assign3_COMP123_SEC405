using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jonas_Assign3_COMP123_SEC405
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> premiers = new Dictionary<string, Premier>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * see Theatre lab 2 for how to get list
             */
            initializedGUI();
        }

        private void initializedGUI()
        {
            for (int i = 0; i < Premier.GetPremiers().Count; i++)
            {
                premiers.Add(Premier.GetPremiers()[i].GenerateKey(), Premier.GetPremiers()[i]);
            }

            // Display the dictionary
            foreach (var item in premiers)
            {
                //MessageBox.Show($"Key: {item.Key}, Value: {item.Value.Party}");
                listBox1.Items.Add(item.Key.ToString());
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Key: {listBox1.SelectedItem.ToString()}");
            /*
             * 
             * 
             */
        }
    }
}
