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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtApePaterno = new TextBox();
            txtNombres = new TextBox();
            txtNroDoc = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtApMaterno = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 3;
            label1.Text = "Número Documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 104);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombres:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(55, 222);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(136, 222);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtApePaterno
            // 
            txtApePaterno.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApePaterno.Location = new Point(111, 130);
            txtApePaterno.Name = "txtApePaterno";
            txtApePaterno.Size = new Size(161, 21);
            txtApePaterno.TabIndex = 7;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(111, 101);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(161, 21);
            txtNombres.TabIndex = 8;
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(136, 26);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(139, 23);
            txtNroDoc.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 138);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 10;
            label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 176);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 11;
            label4.Text = "Apellido Materno:";
            // 
            // txtApMaterno
            // 
            txtApMaterno.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtApMaterno.Location = new Point(111, 168);
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(161, 21);
            txtApMaterno.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(12, 74);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 13;
            label5.Text = "Datos Generales:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(284, 261);
            Controls.Add(label5);
            Controls.Add(txtApMaterno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNroDoc);
            Controls.Add(txtNombres);
            Controls.Add(txtApePaterno);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox txtApePaterno;
        private TextBox txtNombres;
        private TextBox txtNroDoc;
        private Label label3;
        private Label label4;
        private TextBox txtApMaterno;
        private Label label5;
    }
}