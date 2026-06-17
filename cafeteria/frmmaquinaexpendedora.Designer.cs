namespace cafeteria
{
    partial class frmmaquinaexpendedora
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblinventario = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.nudcantidad = new System.Windows.Forms.NumericUpDown();
            this.btmcomprar = new System.Windows.Forms.Button();
            this.lstproductos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAQUNA EXPRES";
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(43, 90);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(297, 24);
            this.cmbProductos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRODUCTOS";
            // 
            // lblinventario
            // 
            this.lblinventario.AutoSize = true;
            this.lblinventario.Location = new System.Drawing.Point(40, 160);
            this.lblinventario.Name = "lblinventario";
            this.lblinventario.Size = new System.Drawing.Size(89, 16);
            this.lblinventario.TabIndex = 4;
            this.lblinventario.Text = "INVENTARIO";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(40, 134);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(57, 16);
            this.lblprecio.TabIndex = 5;
            this.lblprecio.Text = "PRECIO";
            // 
            // nudcantidad
            // 
            this.nudcantidad.Location = new System.Drawing.Point(43, 224);
            this.nudcantidad.Name = "nudcantidad";
            this.nudcantidad.Size = new System.Drawing.Size(120, 22);
            this.nudcantidad.TabIndex = 6;
            // 
            // btmcomprar
            // 
            this.btmcomprar.Location = new System.Drawing.Point(295, 289);
            this.btmcomprar.Name = "btmcomprar";
            this.btmcomprar.Size = new System.Drawing.Size(199, 59);
            this.btmcomprar.TabIndex = 7;
            this.btmcomprar.Text = "COMPRAR";
            this.btmcomprar.UseVisualStyleBackColor = true;
            // 
            // lstproductos
            // 
            this.lstproductos.FormattingEnabled = true;
            this.lstproductos.ItemHeight = 16;
            this.lstproductos.Location = new System.Drawing.Point(43, 343);
            this.lstproductos.Name = "lstproductos";
            this.lstproductos.Size = new System.Drawing.Size(120, 84);
            this.lstproductos.TabIndex = 8;
            // 
            // frmmaquinaexpendedora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstproductos);
            this.Controls.Add(this.btmcomprar);
            this.Controls.Add(this.nudcantidad);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblinventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.label1);
            this.Name = "frmmaquinaexpendedora";
            this.Text = "frmmaquinaexpendedora";
            this.Load += new System.EventHandler(this.frmmaquinaexpendedora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudcantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblinventario;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.NumericUpDown nudcantidad;
        private System.Windows.Forms.Button btmcomprar;
        private System.Windows.Forms.ListBox lstproductos;
    }
}