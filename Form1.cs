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

/*
 * COMP 123 Programming 2
 * Section 405
 * Winter 2024
 * Group 4
 * Assignment 3
 * Due Apr 21
 * Team Members:
 * Jonas Harvie
 * Maharaj Nath
 */

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
            initializedGUI();
        }

        private void initializedGUI()
        {
            // fill the dictionary with info from the list
            for (int i = 0; i < Premier.GetPremiers().Count; i++)
            {
                premiers.Add(Premier.GetPremiers()[i].GenerateKey(), Premier.GetPremiers()[i]);
            }

            // Fill the listbox witht the last names of all the Premiers
            foreach (var item in premiers)
            {
                listBox1.Items.Add(item.Key.ToString());
            }

            // set the initial Premier to be shown by picking the first one in the listbox
            UpdateGUI(listBox1.Items[0].ToString());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            UpdateGUI(listBox1.SelectedItem.ToString());
        }
        private void UpdateGUI(string key)
        {
            pictureBox1.ImageLocation = $"{key}.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // resizes so all images have the same height
            PremierNameLabel.Text = premiers[key].Name;
            PremierLifeLabel.Text = premiers[key].Life;
            PremierStartEndLabel.Text = $"{premiers[key].Start} - {premiers[key].End}";
        }


    }
}
