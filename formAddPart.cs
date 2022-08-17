using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShop
{
    public partial class formAddPart : Form
    {
        public Part NewPart { get; set; }
        public formAddPart()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Part part = new Part();
            part.PartName = PartTextbox.Text;
            part.Description = DescriptionTextbox.Text;

            NewPart = part;

            this.DialogResult = DialogResult.OK;
        }
    }
}
