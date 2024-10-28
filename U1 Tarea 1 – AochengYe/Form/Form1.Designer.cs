namespace U1_Tarea_1___AochengYe
{
    partial class FormularioPrincipal
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRes = new System.Windows.Forms.PictureBox();
            this.btnMaxi = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblLayoutMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAnnadir = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.pctBoxDavinci = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.panel2.SuspendLayout();
            this.tblLayoutMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxDavinci)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBarraTitulo.Controls.Add(this.btnRes);
            this.panelBarraTitulo.Controls.Add(this.btnMaxi);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Controls.Add(this.btnMin);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(2248, 52);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRes.Image = global::U1_Tarea_1___AochengYe.Properties.Resources.res;
            this.btnRes.Location = new System.Drawing.Point(2181, 12);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(26, 25);
            this.btnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRes.TabIndex = 4;
            this.btnRes.TabStop = false;
            this.btnRes.Visible = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxi.Image = global::U1_Tarea_1___AochengYe.Properties.Resources.maxi;
            this.btnMaxi.Location = new System.Drawing.Point(2181, 12);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(26, 25);
            this.btnMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaxi.TabIndex = 5;
            this.btnMaxi.TabStop = false;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::U1_Tarea_1___AochengYe.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(2211, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::U1_Tarea_1___AochengYe.Properties.Resources.minimazar;
            this.btnMin.Location = new System.Drawing.Point(2150, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.tblLayoutMenu);
            this.panel2.Controls.Add(this.pctBoxDavinci);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 1340);
            this.panel2.TabIndex = 1;
            // 
            // tblLayoutMenu
            // 
            this.tblLayoutMenu.ColumnCount = 1;
            this.tblLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutMenu.Controls.Add(this.btnSalir, 0, 6);
            this.tblLayoutMenu.Controls.Add(this.btnListar, 0, 5);
            this.tblLayoutMenu.Controls.Add(this.btnEliminar, 0, 4);
            this.tblLayoutMenu.Controls.Add(this.btnConsultar, 0, 3);
            this.tblLayoutMenu.Controls.Add(this.btnModificar, 0, 2);
            this.tblLayoutMenu.Controls.Add(this.btnAnnadir, 0, 1);
            this.tblLayoutMenu.Controls.Add(this.btnPrincipal, 0, 0);
            this.tblLayoutMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutMenu.Location = new System.Drawing.Point(0, 232);
            this.tblLayoutMenu.Name = "tblLayoutMenu";
            this.tblLayoutMenu.RowCount = 7;
            this.tblLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblLayoutMenu.Size = new System.Drawing.Size(256, 1108);
            this.tblLayoutMenu.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 951);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 154);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Location = new System.Drawing.Point(3, 793);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(250, 152);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(3, 635);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(250, 152);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Image = global::U1_Tarea_1___AochengYe.Properties.Resources.book_and_pencil_32px;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(3, 477);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(250, 152);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(3, 319);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(250, 152);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnnadir
            // 
            this.btnAnnadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnnadir.FlatAppearance.BorderSize = 0;
            this.btnAnnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnadir.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnadir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnadir.Image")));
            this.btnAnnadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnadir.Location = new System.Drawing.Point(3, 161);
            this.btnAnnadir.Name = "btnAnnadir";
            this.btnAnnadir.Size = new System.Drawing.Size(250, 152);
            this.btnAnnadir.TabIndex = 1;
            this.btnAnnadir.Text = "Añadir";
            this.btnAnnadir.UseVisualStyleBackColor = true;
            this.btnAnnadir.Click += new System.EventHandler(this.btnAnnadir_Click);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnPrincipal.Image")));
            this.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Location = new System.Drawing.Point(3, 3);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(250, 152);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // pctBoxDavinci
            // 
            this.pctBoxDavinci.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctBoxDavinci.Image = global::U1_Tarea_1___AochengYe.Properties.Resources.Screenshot_2024_10_16_162830;
            this.pctBoxDavinci.Location = new System.Drawing.Point(0, 0);
            this.pctBoxDavinci.Name = "pctBoxDavinci";
            this.pctBoxDavinci.Size = new System.Drawing.Size(256, 232);
            this.pctBoxDavinci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxDavinci.TabIndex = 12;
            this.pctBoxDavinci.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(256, 284);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1992, 1108);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(16, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(546, 56);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "IES LEONARDO DA VINCI";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(256, 52);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1992, 232);
            this.panelTitulo.TabIndex = 3;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2248, 1392);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tblLayoutMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxDavinci)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnMaxi;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnRes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tblLayoutMenu;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAnnadir;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.PictureBox pctBoxDavinci;
    }
}

