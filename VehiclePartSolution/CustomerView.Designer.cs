namespace VehiclePartSolution
{
    partial class CustomerView
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
            this.btnCarOrder = new System.Windows.Forms.Button();
            this.btnCarPartsOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarOrder
            // 
            this.btnCarOrder.BackColor = System.Drawing.Color.White;
            this.btnCarOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarOrder.Location = new System.Drawing.Point(53, 50);
            this.btnCarOrder.Name = "btnCarOrder";
            this.btnCarOrder.Size = new System.Drawing.Size(151, 34);
            this.btnCarOrder.TabIndex = 0;
            this.btnCarOrder.Text = "Place Car Order";
            this.btnCarOrder.UseVisualStyleBackColor = false;
            this.btnCarOrder.Click += new System.EventHandler(this.btnCarOrder_Click);
            // 
            // btnCarPartsOrder
            // 
            this.btnCarPartsOrder.BackColor = System.Drawing.Color.White;
            this.btnCarPartsOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarPartsOrder.Location = new System.Drawing.Point(239, 50);
            this.btnCarPartsOrder.Name = "btnCarPartsOrder";
            this.btnCarPartsOrder.Size = new System.Drawing.Size(192, 34);
            this.btnCarPartsOrder.TabIndex = 1;
            this.btnCarPartsOrder.Text = "Place Car Parts Order";
            this.btnCarPartsOrder.UseVisualStyleBackColor = false;
            this.btnCarPartsOrder.Click += new System.EventHandler(this.btnCarPartsOrder_Click);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 327);
            this.Controls.Add(this.btnCarPartsOrder);
            this.Controls.Add(this.btnCarOrder);
            this.Name = "CustomerView";
            this.Text = "Customer Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarOrder;
        private System.Windows.Forms.Button btnCarPartsOrder;
    }
}