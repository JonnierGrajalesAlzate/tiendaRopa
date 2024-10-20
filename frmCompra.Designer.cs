namespace PROCESO_CRUD
{
    partial class fmrCompra
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
            this.gbCompra = new System.Windows.Forms.GroupBox();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompra
            // 
            this.gbCompra.Controls.Add(this.label3);
            this.gbCompra.Controls.Add(this.label2);
            this.gbCompra.Controls.Add(this.linkLabel1);
            this.gbCompra.Controls.Add(this.label1);
            this.gbCompra.Controls.Add(this.pbProducto);
            this.gbCompra.Location = new System.Drawing.Point(12, 3);
            this.gbCompra.Name = "gbCompra";
            this.gbCompra.Size = new System.Drawing.Size(244, 410);
            this.gbCompra.TabIndex = 1;
            this.gbCompra.TabStop = false;
            this.gbCompra.Text = "Producto Elegido";
            // 
            // pbProducto
            // 
            this.pbProducto.Location = new System.Drawing.Point(17, 34);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(198, 147);
            this.pbProducto.TabIndex = 0;
            this.pbProducto.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOTA: para continuar con la compra comunicate con nosotros en nuestras distintas " +
    "redes sociales";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(17, 255);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(191, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.instagram.com/jonni.g21/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "WhatsApp  3024158318";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instagram  OrigenMedellin";
            // 
            // fmrCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCompra);
            this.Name = "fmrCompra";
            this.Text = "fmrCompra";
            this.gbCompra.ResumeLayout(false);
            this.gbCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbProducto;
    }
}