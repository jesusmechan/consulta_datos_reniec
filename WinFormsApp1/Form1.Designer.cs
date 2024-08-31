namespace WinFormsApp1
{
    partial class Form1
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
            label1 = new Label();
            button1 = new Button();
            txtNroDoc = new TextBox();
            rbtnRuc = new RadioButton();
            rbtnDni = new RadioButton();
            label6 = new Label();
            panelDNI = new Panel();
            lblNombres = new Label();
            txtApePaterno = new TextBox();
            txtNombres = new TextBox();
            lblApellidoPaterno = new Label();
            lblApellidoMaterno = new Label();
            txtApMaterno = new TextBox();
            panelRUc = new Panel();
            lblDistrito = new Label();
            txtDistrito = new TextBox();
            lblProvincia = new Label();
            txtProvincia = new TextBox();
            lblDepartamento = new Label();
            txtDepartamento = new TextBox();
            txtCondicion = new TextBox();
            lblCondicion = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtUbigeo = new TextBox();
            lblUbigeo = new Label();
            lblDirección = new Label();
            txtRazonSocial = new TextBox();
            txtDireccion = new TextBox();
            lblRazonSocial = new Label();
            button2 = new Button();
            panelDNI.SuspendLayout();
            panelRUc.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(10, 78);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 3;
            label1.Text = "Número Documento:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(279, 77);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(134, 78);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(139, 23);
            txtNroDoc.TabIndex = 9;
            // 
            // rbtnRuc
            // 
            rbtnRuc.AutoSize = true;
            rbtnRuc.Location = new Point(216, 28);
            rbtnRuc.Name = "rbtnRuc";
            rbtnRuc.Size = new Size(48, 19);
            rbtnRuc.TabIndex = 14;
            rbtnRuc.TabStop = true;
            rbtnRuc.Text = "RUC";
            rbtnRuc.UseVisualStyleBackColor = true;
            // 
            // rbtnDni
            // 
            rbtnDni.AutoSize = true;
            rbtnDni.Location = new Point(165, 28);
            rbtnDni.Name = "rbtnDni";
            rbtnDni.Size = new Size(45, 19);
            rbtnDni.TabIndex = 15;
            rbtnDni.TabStop = true;
            rbtnDni.Text = "DNI";
            rbtnDni.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(25, 28);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 16;
            label6.Text = "Seleccionar Tipo Doc. :";
            // 
            // panelDNI
            // 
            panelDNI.Controls.Add(lblNombres);
            panelDNI.Controls.Add(txtApePaterno);
            panelDNI.Controls.Add(txtNombres);
            panelDNI.Controls.Add(lblApellidoPaterno);
            panelDNI.Controls.Add(lblApellidoMaterno);
            panelDNI.Controls.Add(txtApMaterno);
            panelDNI.Location = new Point(13, 107);
            panelDNI.Name = "panelDNI";
            panelDNI.Size = new Size(341, 115);
            panelDNI.TabIndex = 37;
            panelDNI.Visible = false;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombres.Location = new Point(53, 16);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(62, 15);
            lblNombres.TabIndex = 13;
            lblNombres.Text = "Nombres:";
            // 
            // txtApePaterno
            // 
            txtApePaterno.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApePaterno.Location = new Point(121, 42);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(161, 21);
            txtApePaterno.TabIndex = 14;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(121, 13);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(161, 21);
            txtNombres.TabIndex = 15;
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidoPaterno.Location = new Point(14, 50);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(100, 15);
            lblApellidoPaterno.TabIndex = 16;
            lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellidoMaterno.Location = new Point(10, 88);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(101, 15);
            lblApellidoMaterno.TabIndex = 17;
            lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // txtApMaterno
            // 
            txtApMaterno.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApMaterno.Location = new Point(121, 80);
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(161, 21);
            txtApMaterno.TabIndex = 18;
            // 
            // panelRUc
            // 
            panelRUc.Controls.Add(lblDistrito);
            panelRUc.Controls.Add(txtDistrito);
            panelRUc.Controls.Add(lblProvincia);
            panelRUc.Controls.Add(txtProvincia);
            panelRUc.Controls.Add(lblDepartamento);
            panelRUc.Controls.Add(txtDepartamento);
            panelRUc.Controls.Add(txtCondicion);
            panelRUc.Controls.Add(lblCondicion);
            panelRUc.Controls.Add(txtEstado);
            panelRUc.Controls.Add(lblEstado);
            panelRUc.Controls.Add(txtUbigeo);
            panelRUc.Controls.Add(lblUbigeo);
            panelRUc.Controls.Add(lblDirección);
            panelRUc.Controls.Add(txtRazonSocial);
            panelRUc.Controls.Add(txtDireccion);
            panelRUc.Controls.Add(lblRazonSocial);
            panelRUc.Location = new Point(13, 228);
            panelRUc.Name = "panelRUc";
            panelRUc.Size = new Size(341, 248);
            panelRUc.TabIndex = 38;
            panelRUc.Visible = false;
            // 
            // lblDistrito
            // 
            lblDistrito.AutoSize = true;
            lblDistrito.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDistrito.Location = new Point(56, 138);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.Size = new Size(49, 15);
            lblDistrito.TabIndex = 66;
            lblDistrito.Text = "Distrito:";
            // 
            // txtDistrito
            // 
            txtDistrito.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDistrito.Location = new Point(121, 132);
            txtDistrito.Name = "txtDistrito";
            txtDistrito.Size = new Size(161, 21);
            txtDistrito.TabIndex = 65;
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblProvincia.Location = new Point(51, 111);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new Size(60, 15);
            lblProvincia.TabIndex = 64;
            lblProvincia.Text = "Provincia:";
            // 
            // txtProvincia
            // 
            txtProvincia.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProvincia.Location = new Point(120, 105);
            txtProvincia.Name = "txtProvincia";
            txtProvincia.Size = new Size(161, 21);
            txtProvincia.TabIndex = 63;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepartamento.Location = new Point(24, 84);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(89, 15);
            lblDepartamento.TabIndex = 62;
            lblDepartamento.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepartamento.Location = new Point(120, 78);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(161, 21);
            txtDepartamento.TabIndex = 61;
            // 
            // txtCondicion
            // 
            txtCondicion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCondicion.Location = new Point(120, 213);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(161, 21);
            txtCondicion.TabIndex = 60;
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCondicion.Location = new Point(42, 219);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(66, 15);
            lblCondicion.TabIndex = 59;
            lblCondicion.Text = "Condición:";
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(120, 186);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(161, 21);
            txtEstado.TabIndex = 58;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(52, 192);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(49, 15);
            lblEstado.TabIndex = 57;
            lblEstado.Text = "Estado:";
            // 
            // txtUbigeo
            // 
            txtUbigeo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUbigeo.Location = new Point(120, 159);
            txtUbigeo.Name = "txtUbigeo";
            txtUbigeo.Size = new Size(161, 21);
            txtUbigeo.TabIndex = 56;
            // 
            // lblUbigeo
            // 
            lblUbigeo.AutoSize = true;
            lblUbigeo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUbigeo.Location = new Point(52, 165);
            lblUbigeo.Name = "lblUbigeo";
            lblUbigeo.Size = new Size(50, 15);
            lblUbigeo.TabIndex = 55;
            lblUbigeo.Text = "Ubigeo:";
            // 
            // lblDirección
            // 
            lblDirección.AutoSize = true;
            lblDirección.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDirección.Location = new Point(52, 57);
            lblDirección.Name = "lblDirección";
            lblDirección.Size = new Size(62, 15);
            lblDirección.TabIndex = 54;
            lblDirección.Text = "Dirección:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRazonSocial.Location = new Point(121, 22);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(215, 21);
            txtRazonSocial.TabIndex = 53;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(120, 51);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(216, 21);
            txtDireccion.TabIndex = 52;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRazonSocial.Location = new Point(33, 25);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(82, 15);
            lblRazonSocial.TabIndex = 51;
            lblRazonSocial.Text = "Razon Social:";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(135, 491);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 34;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(377, 523);
            Controls.Add(panelRUc);
            Controls.Add(panelDNI);
            Controls.Add(label6);
            Controls.Add(rbtnDni);
            Controls.Add(rbtnRuc);
            Controls.Add(txtNroDoc);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button2);
            Cursor = Cursors.Hand;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelDNI.ResumeLayout(false);
            panelDNI.PerformLayout();
            panelRUc.ResumeLayout(false);
            panelRUc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox txtNroDoc;
        private RadioButton rbtnRuc;
        private RadioButton rbtnDni;
        private Label label6;
        private Panel panelDNI;
        private Label lblNombres;
        private TextBox txtApePaterno;
        private TextBox txtNombres;
        private Label lblApellidoPaterno;
        private Label lblApellidoMaterno;
        private TextBox txtApMaterno;
        private Panel panelRUc;
        private Label lblDistrito;
        private TextBox txtDistrito;
        private Label lblProvincia;
        private TextBox txtProvincia;
        private Label lblDepartamento;
        private TextBox txtDepartamento;
        private TextBox txtCondicion;
        private Label lblCondicion;
        private TextBox txtEstado;
        private Label lblEstado;
        private TextBox txtUbigeo;
        private Label lblUbigeo;
        private Label lblDirección;
        private TextBox txtRazonSocial;
        private TextBox txtDireccion;
        private Label lblRazonSocial;
        private Button button2;
    }
}