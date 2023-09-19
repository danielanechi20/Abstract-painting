namespace proiect1
{
    partial class tablou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tablou));
            this.p = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.printdesen = new System.Windows.Forms.ToolStripButton();
            this.inks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.shapes = new System.Windows.Forms.ToolStripDropDownButton();
            this.linii = new System.Windows.Forms.ToolStripMenuItem();
            this.triunghiuri = new System.Windows.Forms.ToolStripMenuItem();
            this.dreptunghi = new System.Windows.Forms.ToolStripMenuItem();
            this.elipse = new System.Windows.Forms.ToolStripMenuItem();
            this.curbe = new System.Windows.Forms.ToolStripMenuItem();
            this.text = new System.Windows.Forms.ToolStripTextBox();
            this.start = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.paint = new System.Windows.Forms.ToolStripButton();
            this.fill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.info = new System.Windows.Forms.ToolStripButton();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.print = new System.Drawing.Printing.PrintDocument();
            this.pd = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(98, 80);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(636, 487);
            this.p.TabIndex = 0;
            this.p.TabStop = false;
            this.p.Click += new System.EventHandler(this.p_Click);
            this.p.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.p.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_MouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exit,
            this.toolStripSeparator1,
            this.save,
            this.printdesen,
            this.inks,
            this.toolStripSeparator5,
            this.shapes,
            this.text,
            this.start,
            this.toolStripSeparator3,
            this.paint,
            this.fill,
            this.toolStripSeparator4,
            this.info});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 57);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // exit
            // 
            this.exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(54, 54);
            this.exit.Text = "exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // save
            // 
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(54, 54);
            this.save.Text = "save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // printdesen
            // 
            this.printdesen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printdesen.Image = ((System.Drawing.Image)(resources.GetObject("printdesen.Image")));
            this.printdesen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printdesen.Name = "printdesen";
            this.printdesen.Size = new System.Drawing.Size(54, 54);
            this.printdesen.Text = "print";
            this.printdesen.Click += new System.EventHandler(this.print_Click);
            // 
            // inks
            // 
            this.inks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inks.Image = ((System.Drawing.Image)(resources.GetObject("inks.Image")));
            this.inks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inks.Name = "inks";
            this.inks.Size = new System.Drawing.Size(54, 54);
            this.inks.Text = "inks";
            this.inks.Click += new System.EventHandler(this.inks_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 57);
            // 
            // shapes
            // 
            this.shapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shapes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linii,
            this.triunghiuri,
            this.dreptunghi,
            this.elipse,
            this.curbe});
            this.shapes.Image = ((System.Drawing.Image)(resources.GetObject("shapes.Image")));
            this.shapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shapes.Name = "shapes";
            this.shapes.Size = new System.Drawing.Size(64, 54);
            this.shapes.Text = "toolStripDropDownButton1";
            // 
            // linii
            // 
            this.linii.Image = ((System.Drawing.Image)(resources.GetObject("linii.Image")));
            this.linii.Name = "linii";
            this.linii.Size = new System.Drawing.Size(184, 26);
            this.linii.Text = "Linii";
            this.linii.Click += new System.EventHandler(this.linii_Click);
            // 
            // triunghiuri
            // 
            this.triunghiuri.Image = ((System.Drawing.Image)(resources.GetObject("triunghiuri.Image")));
            this.triunghiuri.Name = "triunghiuri";
            this.triunghiuri.Size = new System.Drawing.Size(184, 26);
            this.triunghiuri.Text = "Triunghiuri";
            this.triunghiuri.Click += new System.EventHandler(this.triunghiuri_Click);
            // 
            // dreptunghi
            // 
            this.dreptunghi.Image = ((System.Drawing.Image)(resources.GetObject("dreptunghi.Image")));
            this.dreptunghi.Name = "dreptunghi";
            this.dreptunghi.Size = new System.Drawing.Size(184, 26);
            this.dreptunghi.Text = "Dreptunghiuri";
            this.dreptunghi.Click += new System.EventHandler(this.dreptunghi_Click);
            // 
            // elipse
            // 
            this.elipse.Image = ((System.Drawing.Image)(resources.GetObject("elipse.Image")));
            this.elipse.Name = "elipse";
            this.elipse.Size = new System.Drawing.Size(184, 26);
            this.elipse.Text = "Elipse";
            this.elipse.Click += new System.EventHandler(this.elipse_Click);
            // 
            // curbe
            // 
            this.curbe.Image = ((System.Drawing.Image)(resources.GetObject("curbe.Image")));
            this.curbe.Name = "curbe";
            this.curbe.Size = new System.Drawing.Size(184, 26);
            this.curbe.Text = "Curbe Bezier";
            this.curbe.Click += new System.EventHandler(this.curbe_Click);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(70, 57);
            // 
            // start
            // 
            this.start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(54, 54);
            this.start.Text = "start";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // paint
            // 
            this.paint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paint.Image = ((System.Drawing.Image)(resources.GetObject("paint.Image")));
            this.paint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paint.Name = "paint";
            this.paint.Size = new System.Drawing.Size(54, 54);
            this.paint.Text = "draw";
            this.paint.Click += new System.EventHandler(this.paint_Click);
            // 
            // fill
            // 
            this.fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fill.Image = ((System.Drawing.Image)(resources.GetObject("fill.Image")));
            this.fill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(54, 54);
            this.fill.Text = "fill";
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // info
            // 
            this.info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(54, 54);
            this.info.Text = "info";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // print
            // 
            this.print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_PrintPage);
            // 
            // pd
            // 
            this.pd.Document = this.print;
            this.pd.UseEXDialog = true;
            // 
            // tablou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 601);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.p);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tablou";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Tablou Abstract";
            this.Load += new System.EventHandler(this.tablou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton save;
        private System.Windows.Forms.ToolStripButton printdesen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox text;
        private System.Windows.Forms.ToolStripButton start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton paint;
        private System.Windows.Forms.ToolStripButton fill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton info;
        private System.Windows.Forms.ToolStripDropDownButton shapes;
        private System.Windows.Forms.ToolStripMenuItem linii;
        private System.Windows.Forms.ToolStripMenuItem triunghiuri;
        private System.Windows.Forms.ToolStripMenuItem dreptunghi;
        private System.Windows.Forms.ToolStripMenuItem elipse;
        private System.Windows.Forms.ToolStripMenuItem curbe;
        private System.Windows.Forms.ToolStripButton inks;
        private System.Windows.Forms.ColorDialog cd;
        private System.Drawing.Printing.PrintDocument print;
        private System.Windows.Forms.PrintDialog pd;
    }
    
}

