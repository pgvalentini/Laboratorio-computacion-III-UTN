
namespace TP_03_SQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bConectar = new System.Windows.Forms.Button();
            this.tBServidor = new System.Windows.Forms.TextBox();
            this.tBPuerto = new System.Windows.Forms.TextBox();
            this.tBContra = new System.Windows.Forms.TextBox();
            this.tBUsuario = new System.Windows.Forms.TextBox();
            this.tBID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BD";
            // 
            // bConectar
            // 
            this.bConectar.Location = new System.Drawing.Point(107, 207);
            this.bConectar.Name = "bConectar";
            this.bConectar.Size = new System.Drawing.Size(75, 23);
            this.bConectar.TabIndex = 5;
            this.bConectar.Text = "Conectar";
            this.bConectar.UseVisualStyleBackColor = true;
            this.bConectar.Click += new System.EventHandler(this.bConectar_Click);
            // 
            // tBServidor
            // 
            this.tBServidor.Location = new System.Drawing.Point(112, 27);
            this.tBServidor.Name = "tBServidor";
            this.tBServidor.Size = new System.Drawing.Size(100, 20);
            this.tBServidor.TabIndex = 6;
            // 
            // tBPuerto
            // 
            this.tBPuerto.Location = new System.Drawing.Point(112, 59);
            this.tBPuerto.Name = "tBPuerto";
            this.tBPuerto.Size = new System.Drawing.Size(100, 20);
            this.tBPuerto.TabIndex = 7;
            // 
            // tBContra
            // 
            this.tBContra.Location = new System.Drawing.Point(112, 123);
            this.tBContra.Name = "tBContra";
            this.tBContra.PasswordChar = '*';
            this.tBContra.Size = new System.Drawing.Size(100, 20);
            this.tBContra.TabIndex = 8;
            // 
            // tBUsuario
            // 
            this.tBUsuario.Location = new System.Drawing.Point(112, 91);
            this.tBUsuario.Name = "tBUsuario";
            this.tBUsuario.Size = new System.Drawing.Size(100, 20);
            this.tBUsuario.TabIndex = 9;
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(112, 160);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(100, 20);
            this.tBID.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 260);
            this.Controls.Add(this.tBID);
            this.Controls.Add(this.tBUsuario);
            this.Controls.Add(this.tBContra);
            this.Controls.Add(this.tBPuerto);
            this.Controls.Add(this.tBServidor);
            this.Controls.Add(this.bConectar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bConectar;
        private System.Windows.Forms.TextBox tBServidor;
        private System.Windows.Forms.TextBox tBPuerto;
        private System.Windows.Forms.TextBox tBContra;
        private System.Windows.Forms.TextBox tBUsuario;
        private System.Windows.Forms.TextBox tBID;
    }
}

