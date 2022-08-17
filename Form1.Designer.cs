namespace EShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addPartButton = new System.Windows.Forms.Button();
            this.Part1 = new System.Windows.Forms.Label();
            this.Part2 = new System.Windows.Forms.Label();
            this.Part3 = new System.Windows.Forms.Label();
            this.Part4 = new System.Windows.Forms.Label();
            this.PartsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.partDescription1 = new System.Windows.Forms.Label();
            this.partDescription2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(93, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(107, 22);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartButton.Location = new System.Drawing.Point(332, 63);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(154, 34);
            this.addPartButton.TabIndex = 1;
            this.addPartButton.Text = "Add New Part";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPart_Click);
            // 
            // Part1
            // 
            this.Part1.AutoSize = true;
            this.Part1.Location = new System.Drawing.Point(24, 28);
            this.Part1.Name = "Part1";
            this.Part1.Size = new System.Drawing.Size(0, 13);
            this.Part1.TabIndex = 2;
            // 
            // Part2
            // 
            this.Part2.AutoSize = true;
            this.Part2.Location = new System.Drawing.Point(138, 51);
            this.Part2.Name = "Part2";
            this.Part2.Size = new System.Drawing.Size(0, 13);
            this.Part2.TabIndex = 3;
            // 
            // Part3
            // 
            this.Part3.AutoSize = true;
            this.Part3.Location = new System.Drawing.Point(314, 52);
            this.Part3.Name = "Part3";
            this.Part3.Size = new System.Drawing.Size(0, 13);
            this.Part3.TabIndex = 4;
            // 
            // Part4
            // 
            this.Part4.AutoSize = true;
            this.Part4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Part4.Location = new System.Drawing.Point(671, 58);
            this.Part4.Name = "Part4";
            this.Part4.Size = new System.Drawing.Size(0, 16);
            this.Part4.TabIndex = 5;
            // 
            // PartsList
            // 
            this.PartsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartsList.FormattingEnabled = true;
            this.PartsList.Items.AddRange(new object[] {
            "Head Gasket",
            "Injector",
            "Camshaft",
            "Brake pads",
            "Brake rotors",
            "Rod",
            "Piston",
            "Valves"});
            this.PartsList.Location = new System.Drawing.Point(27, 79);
            this.PartsList.Name = "PartsList";
            this.PartsList.Size = new System.Drawing.Size(159, 21);
            this.PartsList.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select car part:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "New part:";
            // 
            // partDescription1
            // 
            this.partDescription1.AutoSize = true;
            this.partDescription1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDescription1.Location = new System.Drawing.Point(576, 81);
            this.partDescription1.Name = "partDescription1";
            this.partDescription1.Size = new System.Drawing.Size(103, 16);
            this.partDescription1.TabIndex = 10;
            this.partDescription1.Text = "Part description:";
            // 
            // partDescription2
            // 
            this.partDescription2.AutoSize = true;
            this.partDescription2.Location = new System.Drawing.Point(685, 83);
            this.partDescription2.Name = "partDescription2";
            this.partDescription2.Size = new System.Drawing.Size(0, 13);
            this.partDescription2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.partDescription2);
            this.Controls.Add(this.partDescription1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsList);
            this.Controls.Add(this.Part4);
            this.Controls.Add(this.Part3);
            this.Controls.Add(this.Part2);
            this.Controls.Add(this.Part1);
            this.Controls.Add(this.addPartButton);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "AutoZone Car Parts Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Label Part1;
        private System.Windows.Forms.Label Part2;
        private System.Windows.Forms.Label Part3;
        private System.Windows.Forms.Label Part4;
        private System.Windows.Forms.ComboBox PartsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label partDescription1;
        private System.Windows.Forms.Label partDescription2;
    }
}

