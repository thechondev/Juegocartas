namespace Juegocartas
{
    partial class Wjuego
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wjuego));
            ListViewItem listViewItem1 = new ListViewItem("", 0);
            ListViewItem listViewItem2 = new ListViewItem("", 34);
            toolStripcontrols = new ToolStrip();
            tscmdrepartir = new ToolStripButton();
            tscmdverificar = new ToolStripButton();
            tabControl1 = new TabControl();
            TPjugador1 = new TabPage();
            lvjugador1 = new ListView();
            ICartas = new ImageList(components);
            TPjugador2 = new TabPage();
            lvjugador2 = new ListView();
            toolStripcontrols.SuspendLayout();
            tabControl1.SuspendLayout();
            TPjugador1.SuspendLayout();
            TPjugador2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripcontrols
            // 
            toolStripcontrols.Items.AddRange(new ToolStripItem[] { tscmdrepartir, tscmdverificar });
            toolStripcontrols.Location = new Point(0, 0);
            toolStripcontrols.Name = "toolStripcontrols";
            toolStripcontrols.Size = new Size(800, 55);
            toolStripcontrols.TabIndex = 0;
            toolStripcontrols.Text = "toolStrip1";
            // 
            // tscmdrepartir
            // 
            tscmdrepartir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tscmdrepartir.Image = (Image)resources.GetObject("tscmdrepartir.Image");
            tscmdrepartir.ImageScaling = ToolStripItemImageScaling.None;
            tscmdrepartir.ImageTransparentColor = Color.Magenta;
            tscmdrepartir.Name = "tscmdrepartir";
            tscmdrepartir.Size = new Size(52, 52);
            tscmdrepartir.Text = "repartir";
            tscmdrepartir.Click += tscmdrepartir_Click;
            // 
            // tscmdverificar
            // 
            tscmdverificar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tscmdverificar.Image = (Image)resources.GetObject("tscmdverificar.Image");
            tscmdverificar.ImageScaling = ToolStripItemImageScaling.None;
            tscmdverificar.ImageTransparentColor = Color.Magenta;
            tscmdverificar.Name = "tscmdverificar";
            tscmdverificar.Size = new Size(52, 52);
            tscmdverificar.Text = "verificar";
            tscmdverificar.Click += tscmdverificar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TPjugador1);
            tabControl1.Controls.Add(TPjugador2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 55);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 395);
            tabControl1.TabIndex = 1;
            // 
            // TPjugador1
            // 
            TPjugador1.BackColor = Color.OliveDrab;
            TPjugador1.BackgroundImageLayout = ImageLayout.None;
            TPjugador1.Controls.Add(lvjugador1);
            TPjugador1.Location = new Point(4, 24);
            TPjugador1.Name = "TPjugador1";
            TPjugador1.Padding = new Padding(3);
            TPjugador1.Size = new Size(792, 367);
            TPjugador1.TabIndex = 0;
            TPjugador1.Text = "Martin estrada contreras";
            // 
            // lvjugador1
            // 
            lvjugador1.BackColor = Color.OliveDrab;
            lvjugador1.Dock = DockStyle.Fill;
            lvjugador1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvjugador1.LargeImageList = ICartas;
            lvjugador1.Location = new Point(3, 3);
            lvjugador1.Name = "lvjugador1";
            lvjugador1.Size = new Size(786, 361);
            lvjugador1.TabIndex = 0;
            lvjugador1.UseCompatibleStateImageBehavior = false;
            // 
            // ICartas
            // 
            ICartas.ColorDepth = ColorDepth.Depth32Bit;
            ICartas.ImageStream = (ImageListStreamer)resources.GetObject("ICartas.ImageStream");
            ICartas.TransparentColor = Color.Transparent;
            ICartas.Images.SetKeyName(0, "CARTA1.JPG");
            ICartas.Images.SetKeyName(1, "CARTA2.JPG");
            ICartas.Images.SetKeyName(2, "CARTA3.JPG");
            ICartas.Images.SetKeyName(3, "CARTA4.JPG");
            ICartas.Images.SetKeyName(4, "CARTA5.JPG");
            ICartas.Images.SetKeyName(5, "CARTA6.JPG");
            ICartas.Images.SetKeyName(6, "CARTA7.JPG");
            ICartas.Images.SetKeyName(7, "CARTA8.JPG");
            ICartas.Images.SetKeyName(8, "CARTA9.JPG");
            ICartas.Images.SetKeyName(9, "CARTA10.JPG");
            ICartas.Images.SetKeyName(10, "CARTA11.JPG");
            ICartas.Images.SetKeyName(11, "CARTA12.JPG");
            ICartas.Images.SetKeyName(12, "CARTA13.JPG");
            ICartas.Images.SetKeyName(13, "CARTA14.JPG");
            ICartas.Images.SetKeyName(14, "CARTA15.JPG");
            ICartas.Images.SetKeyName(15, "CARTA16.JPG");
            ICartas.Images.SetKeyName(16, "CARTA17.JPG");
            ICartas.Images.SetKeyName(17, "CARTA18.JPG");
            ICartas.Images.SetKeyName(18, "CARTA19.JPG");
            ICartas.Images.SetKeyName(19, "CARTA20.JPG");
            ICartas.Images.SetKeyName(20, "CARTA21.JPG");
            ICartas.Images.SetKeyName(21, "CARTA22.JPG");
            ICartas.Images.SetKeyName(22, "CARTA23.JPG");
            ICartas.Images.SetKeyName(23, "CARTA24.JPG");
            ICartas.Images.SetKeyName(24, "CARTA25.JPG");
            ICartas.Images.SetKeyName(25, "CARTA26.JPG");
            ICartas.Images.SetKeyName(26, "CARTA27.JPG");
            ICartas.Images.SetKeyName(27, "CARTA28.JPG");
            ICartas.Images.SetKeyName(28, "CARTA29.JPG");
            ICartas.Images.SetKeyName(29, "CARTA30.JPG");
            ICartas.Images.SetKeyName(30, "CARTA31.JPG");
            ICartas.Images.SetKeyName(31, "CARTA32.JPG");
            ICartas.Images.SetKeyName(32, "CARTA33.JPG");
            ICartas.Images.SetKeyName(33, "CARTA34.JPG");
            ICartas.Images.SetKeyName(34, "CARTA35.JPG");
            ICartas.Images.SetKeyName(35, "CARTA36.JPG");
            ICartas.Images.SetKeyName(36, "CARTA37.JPG");
            ICartas.Images.SetKeyName(37, "CARTA38.JPG");
            ICartas.Images.SetKeyName(38, "CARTA39.JPG");
            ICartas.Images.SetKeyName(39, "CARTA40.JPG");
            ICartas.Images.SetKeyName(40, "CARTA41.JPG");
            ICartas.Images.SetKeyName(41, "CARTA42.JPG");
            ICartas.Images.SetKeyName(42, "CARTA43.JPG");
            ICartas.Images.SetKeyName(43, "CARTA44.JPG");
            ICartas.Images.SetKeyName(44, "CARTA45.JPG");
            ICartas.Images.SetKeyName(45, "CARTA46.JPG");
            ICartas.Images.SetKeyName(46, "CARTA47.JPG");
            ICartas.Images.SetKeyName(47, "CARTA48.JPG");
            ICartas.Images.SetKeyName(48, "CARTA49.JPG");
            ICartas.Images.SetKeyName(49, "Carta50.JPG");
            ICartas.Images.SetKeyName(50, "CARTA51.JPG");
            ICartas.Images.SetKeyName(51, "CARTA52.JPG");
            // 
            // TPjugador2
            // 
            TPjugador2.BackColor = Color.OliveDrab;
            TPjugador2.Controls.Add(lvjugador2);
            TPjugador2.Location = new Point(4, 24);
            TPjugador2.Name = "TPjugador2";
            TPjugador2.Padding = new Padding(3);
            TPjugador2.Size = new Size(792, 367);
            TPjugador2.TabIndex = 1;
            TPjugador2.Text = "Gambito";
            // 
            // lvjugador2
            // 
            lvjugador2.BackColor = Color.OliveDrab;
            lvjugador2.Dock = DockStyle.Fill;
            lvjugador2.Items.AddRange(new ListViewItem[] { listViewItem2 });
            lvjugador2.LargeImageList = ICartas;
            lvjugador2.Location = new Point(3, 3);
            lvjugador2.Name = "lvjugador2";
            lvjugador2.Size = new Size(786, 361);
            lvjugador2.TabIndex = 1;
            lvjugador2.UseCompatibleStateImageBehavior = false;
            // 
            // Wjuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(toolStripcontrols);
            Name = "Wjuego";
            Text = "Form1";
            toolStripcontrols.ResumeLayout(false);
            toolStripcontrols.PerformLayout();
            tabControl1.ResumeLayout(false);
            TPjugador1.ResumeLayout(false);
            TPjugador2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripcontrols;
        private ToolStripButton tscmdrepartir;
        private ToolStripButton tscmdverificar;
        private TabControl tabControl1;
        private TabPage TPjugador1;
        private TabPage TPjugador2;
        private ImageList ICartas;
        private ListView lvjugador1;
        private ListView lvjugador2;
    }
}
