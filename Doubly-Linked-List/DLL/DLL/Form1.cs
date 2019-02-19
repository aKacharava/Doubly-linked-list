using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL
{
    public partial class Form1 : Form
    {
        int[] arrayMan = new int[9];
        Random generateNumbers = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayMan.Length; i++)
            {
                arrayMan[i] = generateNumbers.Next(0, 11);
                lbxLeft.Items.Add(arrayMan[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbxLeft.Items.Clear();
            lbxRight.Items.Clear();

            for (int i = 0; i < arrayMan.Length; i++)
            {
                arrayMan[i] = generateNumbers.Next(0, 11);
                lbxLeft.Items.Add(arrayMan[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrayMan.Length; i++)
            {
                Note.pBLA(arrayMan[i]);
            }

            arrayMan = Note.addToArray();

            for (int i = 0; i < arrayMan.Length; i++)
            {
                lbxRight.Items.Add(arrayMan[i]);
            }
        }
    }
}
