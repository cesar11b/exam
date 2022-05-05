
namespace exam
{
    partial class DetailsValues
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblDetailValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(3, 9);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(75, 13);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "DetailWeather";
            // 
            // lblDetailValue
            // 
            this.lblDetailValue.AutoSize = true;
            this.lblDetailValue.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailValue.Location = new System.Drawing.Point(19, 44);
            this.lblDetailValue.Name = "lblDetailValue";
            this.lblDetailValue.Size = new System.Drawing.Size(57, 18);
            this.lblDetailValue.TabIndex = 1;
            this.lblDetailValue.Text = "Value";
            // 
            // DetailsValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetailValue);
            this.Controls.Add(this.lblDetail);
            this.Name = "DetailsValues";
            this.Size = new System.Drawing.Size(106, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblDetail;
        public System.Windows.Forms.Label lblDetailValue;
    }

}
