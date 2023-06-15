namespace PaintFigurasV1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.figurasToolStripMenuItem,
            this.lapizToolStripMenuItem,
            this.borradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadradoToolStripMenuItem,
            this.rectánguloToolStripMenuItem,
            this.triánguloToolStripMenuItem,
            this.circuloToolStripMenuItem,
            this.trapecioToolStripMenuItem});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cuadradoToolStripMenuItem.Image")));
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cuadradoToolStripMenuItem.Text = "Rombo";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);
            // 
            // rectánguloToolStripMenuItem
            // 
            this.rectánguloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rectánguloToolStripMenuItem.Image")));
            this.rectánguloToolStripMenuItem.Name = "rectánguloToolStripMenuItem";
            this.rectánguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rectánguloToolStripMenuItem.Text = "Rectángulo";
            this.rectánguloToolStripMenuItem.Click += new System.EventHandler(this.rectánguloToolStripMenuItem_Click);
            // 
            // triánguloToolStripMenuItem
            // 
            this.triánguloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("triánguloToolStripMenuItem.Image")));
            this.triánguloToolStripMenuItem.Name = "triánguloToolStripMenuItem";
            this.triánguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triánguloToolStripMenuItem.Text = "Triángulo";
            this.triánguloToolStripMenuItem.Click += new System.EventHandler(this.triánguloToolStripMenuItem_Click);
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("circuloToolStripMenuItem.Image")));
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circuloToolStripMenuItem.Text = "Circulo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // trapecioToolStripMenuItem
            // 
            this.trapecioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trapecioToolStripMenuItem.Image")));
            this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
            this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trapecioToolStripMenuItem.Text = "Pentagono";
            this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.trapecioToolStripMenuItem_Click);
            // 
            // lapizToolStripMenuItem
            // 
            this.lapizToolStripMenuItem.Name = "lapizToolStripMenuItem";
            this.lapizToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.lapizToolStripMenuItem.Text = "Lapiz";
            this.lapizToolStripMenuItem.Click += new System.EventHandler(this.lapizToolStripMenuItem_Click);
            // 
            // borradorToolStripMenuItem
            // 
            this.borradorToolStripMenuItem.Name = "borradorToolStripMenuItem";
            this.borradorToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.borradorToolStripMenuItem.Text = "Borrador";
            this.borradorToolStripMenuItem.Click += new System.EventHandler(this.borradorToolStripMenuItem_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic.Location = new System.Drawing.Point(0, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(311, 210);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pic);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectánguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triánguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lapizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borradorToolStripMenuItem;
        private System.Windows.Forms.PictureBox pic;
    }
}

