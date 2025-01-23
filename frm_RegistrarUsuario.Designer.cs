using System;
using System.Windows.Forms;

namespace Tarea4_5_AllanM
{
    partial class frm_RegistrarUsuario
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Button btn_Guardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txt_Nombre = new TextBox();
            this.txt_Apellido = new TextBox();
            this.lbl_Nombre = new Label();
            this.lbl_Apellido = new Label();
            this.btn_Guardar = new Button();

            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(150, 50);
            this.txt_Nombre.Size = new System.Drawing.Size(200, 22);

            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(150, 100);
            this.txt_Apellido.Size = new System.Drawing.Size(200, 22);

            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.Location = new System.Drawing.Point(50, 50);
            this.lbl_Nombre.Text = "Nombre:";

            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.Location = new System.Drawing.Point(50, 100);
            this.lbl_Apellido.Text = "Apellido:";

            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(150, 150);
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.Click += new EventHandler(this.btn_Guardar_Click);

            // 
            // frm_RegistrarUsuario
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.btn_Guardar);
            this.Text = "Registrar Usuario";
        }
    }
}
