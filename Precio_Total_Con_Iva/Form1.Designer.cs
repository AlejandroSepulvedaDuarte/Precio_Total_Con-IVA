namespace Precio_Total_Con_Iva
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
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalorproducto = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btningresonuevovalor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "El Iva y Valor Total de un producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el valor del producto:";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(24, 204);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(94, 22);
            this.lblsubtotal.TabIndex = 2;
            this.lblsubtotal.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Iva:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total:";
            // 
            // txtvalorproducto
            // 
            this.txtvalorproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorproducto.Location = new System.Drawing.Point(382, 89);
            this.txtvalorproducto.Name = "txtvalorproducto";
            this.txtvalorproducto.Size = new System.Drawing.Size(197, 29);
            this.txtvalorproducto.TabIndex = 5;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(156, 204);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(197, 29);
            this.txtsubtotal.TabIndex = 6;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtiva
            // 
            this.txtiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiva.Location = new System.Drawing.Point(156, 245);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(197, 29);
            this.txtiva.TabIndex = 7;
            this.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btncalcular.ForeColor = System.Drawing.Color.White;
            this.btncalcular.Location = new System.Drawing.Point(156, 147);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(197, 39);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Haz Click aquí  para calucular el Iva y el costo total del producto";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Precio_Total_Con_Iva.Properties.Resources._061016_2;
            this.pictureBox1.Location = new System.Drawing.Point(382, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(156, 287);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(197, 29);
            this.txttotal.TabIndex = 10;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btningresonuevovalor
            // 
            this.btningresonuevovalor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btningresonuevovalor.ForeColor = System.Drawing.Color.White;
            this.btningresonuevovalor.Location = new System.Drawing.Point(156, 334);
            this.btningresonuevovalor.Name = "btningresonuevovalor";
            this.btningresonuevovalor.Size = new System.Drawing.Size(197, 41);
            this.btningresonuevovalor.TabIndex = 11;
            this.btningresonuevovalor.Text = "Haz Click aquí para agregar otro valor";
            this.btningresonuevovalor.UseVisualStyleBackColor = false;
            this.btningresonuevovalor.Click += new System.EventHandler(this.btningresonuevovalor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btningresonuevovalor);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtiva);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txtvalorproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Precio Total ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalorproducto;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btningresonuevovalor;
    }
}

