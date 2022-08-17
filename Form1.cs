using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShop
{
    public partial class Form1 : Form
    {
        private EShop partsShop;

        public Form1()
        {
            partsShop = new EShop();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Part part1 = new Part();
            part1.PartName = "";
            part1.Description = "Engine head component";

            partsShop.Parts.Add(part1);

            Part part2 = new Part();
            part2.PartName = "";
            part2.Description = "Engine block component";

            partsShop.Parts.Add(part2);

            Part part3 = new Part();
            part3.PartName = "";
            part3.Description = "Drivetrain component";

            partsShop.Parts.Add(part3);

            Part1.Text = partsShop.Parts[0].PartName;
            Part2.Text = partsShop.Parts[1].PartName;
            Part3.Text = partsShop.Parts[2].PartName;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Vlad, ©Copyright 2022", "AutoZone Inc.");

        }
        private void addPart_Click(object sender, EventArgs e)
        {
            formAddPart addPartPopup = new formAddPart();

            DialogResult result = addPartPopup.ShowDialog();

            if (result == DialogResult.OK)
            {
                partsShop.Parts.Add(addPartPopup.NewPart);
            }
            int numberOfParts = partsShop.Parts.Count;
            Part4.Text = partsShop.Parts[numberOfParts - 1].PartName;
            partDescription2.Text = partsShop.Parts[numberOfParts - 1].Description;


        }

    }
}
