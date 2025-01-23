namespace Tarea4_5_AllanM
{
    partial class frm_MenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar recursos usados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método requerido para el diseñador.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Respaldos = new System.Windows.Forms.Button();
            this.btn_RestaurarBD = new System.Windows.Forms.Button();
            this.btn_Personal = new System.Windows.Forms.Button();
            this.btn_Asistencia = new System.Windows.Forms.Button();
            this.pnl_bienvenida = new System.Windows.Forms.Panel();
            this.lbl_bienvenida = new System.Windows.Forms.Label();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_Recargar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.pnl_opciones.SuspendLayout();
            this.pnl_bienvenida.SuspendLayout();
            this.pnl_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pnl_opciones.Controls.Add(this.btn_Usuarios);
            this.pnl_opciones.Controls.Add(this.btn_Respaldos);
            this.pnl_opciones.Controls.Add(this.btn_RestaurarBD);
            this.pnl_opciones.Controls.Add(this.btn_Personal);
            this.pnl_opciones.Controls.Add(this.btn_Asistencia);
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_opciones.Location = new System.Drawing.Point(0, 0);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(200, 639);
            this.pnl_opciones.TabIndex = 8;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Location = new System.Drawing.Point(25, 422);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(150, 79);
            this.btn_Usuarios.TabIndex = 9;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click_1);
            // 
            // btn_Respaldos
            // 
            this.btn_Respaldos.Location = new System.Drawing.Point(25, 336);
            this.btn_Respaldos.Name = "btn_Respaldos";
            this.btn_Respaldos.Size = new System.Drawing.Size(150, 79);
            this.btn_Respaldos.TabIndex = 8;
            this.btn_Respaldos.Text = "Respaldos";
            this.btn_Respaldos.UseVisualStyleBackColor = true;
            this.btn_Respaldos.Click += new System.EventHandler(this.btn_Respaldos_Click);
            // 
            // btn_RestaurarBD
            // 
            this.btn_RestaurarBD.Location = new System.Drawing.Point(25, 250);
            this.btn_RestaurarBD.Name = "btn_RestaurarBD";
            this.btn_RestaurarBD.Size = new System.Drawing.Size(150, 79);
            this.btn_RestaurarBD.TabIndex = 7;
            this.btn_RestaurarBD.Text = "Restaurar BD";
            this.btn_RestaurarBD.UseVisualStyleBackColor = true;
            this.btn_RestaurarBD.Click += new System.EventHandler(this.btn_RestaurarBD_Click);
            // 
            // btn_Personal
            // 
            this.btn_Personal.Location = new System.Drawing.Point(25, 163);
            this.btn_Personal.Name = "btn_Personal";
            this.btn_Personal.Size = new System.Drawing.Size(150, 79);
            this.btn_Personal.TabIndex = 6;
            this.btn_Personal.Text = "Personal";
            this.btn_Personal.UseVisualStyleBackColor = true;
            this.btn_Personal.Click += new System.EventHandler(this.btn_Personal_Click);
            // 
            // btn_Asistencia
            // 
            this.btn_Asistencia.Location = new System.Drawing.Point(25, 73);
            this.btn_Asistencia.Name = "btn_Asistencia";
            this.btn_Asistencia.Size = new System.Drawing.Size(150, 79);
            this.btn_Asistencia.TabIndex = 5;
            this.btn_Asistencia.Text = "Asistencia";
            this.btn_Asistencia.UseVisualStyleBackColor = true;
            this.btn_Asistencia.Click += new System.EventHandler(this.btn_Asistencia_Click);
            // 
            // pnl_bienvenida
            // 
            this.pnl_bienvenida.BackColor = System.Drawing.Color.White;
            this.pnl_bienvenida.Controls.Add(this.lbl_bienvenida);
            this.pnl_bienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bienvenida.Location = new System.Drawing.Point(200, 0);
            this.pnl_bienvenida.Name = "pnl_bienvenida";
            this.pnl_bienvenida.Size = new System.Drawing.Size(600, 100);
            this.pnl_bienvenida.TabIndex = 10;
            // 
            // lbl_bienvenida
            // 
            this.lbl_bienvenida.AutoSize = true;
            this.lbl_bienvenida.Font = new System.Drawing.Font("MS Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bienvenida.Location = new System.Drawing.Point(122, 18);
            this.lbl_bienvenida.Name = "lbl_bienvenida";
            this.lbl_bienvenida.Size = new System.Drawing.Size(357, 64);
            this.lbl_bienvenida.TabIndex = 10;
            this.lbl_bienvenida.Text = "Bienvenido";
            this.lbl_bienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_info
            // 
            this.pnl_info.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_info.Controls.Add(this.dgv_Usuarios);
            this.pnl_info.Controls.Add(this.btn_Recargar);
            this.pnl_info.Controls.Add(this.btn_Registrar);
            this.pnl_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_info.Location = new System.Drawing.Point(200, 100);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(600, 539);
            this.pnl_info.TabIndex = 11;
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(100, 144);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(400, 300);
            this.dgv_Usuarios.TabIndex = 10;
            this.dgv_Usuarios.Visible = false;
            // 
            // btn_Recargar
            // 
            this.btn_Recargar.Location = new System.Drawing.Point(300, 94);
            this.btn_Recargar.Name = "btn_Recargar";
            this.btn_Recargar.Size = new System.Drawing.Size(150, 40);
            this.btn_Recargar.TabIndex = 9;
            this.btn_Recargar.Text = "Recargar Usuarios";
            this.btn_Recargar.UseVisualStyleBackColor = true;
            this.btn_Recargar.Visible = false;
            this.btn_Recargar.Click += new System.EventHandler(this.btn_Recargar_Click_1);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(100, 94);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(150, 40);
            this.btn_Registrar.TabIndex = 8;
            this.btn_Registrar.Text = "Registrar Usuario";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Visible = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click_1);
            // 
            // frm_MenuPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.Controls.Add(this.pnl_info);
            this.Controls.Add(this.pnl_bienvenida);
            this.Controls.Add(this.pnl_opciones);
            this.Name = "frm_MenuPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frm_MenuPrincipal_Load);
            this.pnl_opciones.ResumeLayout(false);
            this.pnl_bienvenida.ResumeLayout(false);
            this.pnl_bienvenida.PerformLayout();
            this.pnl_info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.Button btn_Respaldos;
        private System.Windows.Forms.Button btn_RestaurarBD;
        private System.Windows.Forms.Button btn_Personal;
        private System.Windows.Forms.Button btn_Asistencia;
        private System.Windows.Forms.Panel pnl_bienvenida;
        private System.Windows.Forms.Label lbl_bienvenida;
        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.Button btn_Recargar;
        private System.Windows.Forms.Button btn_Registrar;
    }
}

