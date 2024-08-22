namespace VehiclePartSolution
{
    partial class AdminView
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
            this.btnCarParts = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarParts
            // 
            this.btnCarParts.BackColor = System.Drawing.Color.White;
            this.btnCarParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarParts.Location = new System.Drawing.Point(499, 41);
            this.btnCarParts.Name = "btnCarParts";
            this.btnCarParts.Size = new System.Drawing.Size(220, 65);
            this.btnCarParts.TabIndex = 3;
            this.btnCarParts.Text = "Car Parts Manage";
            this.btnCarParts.UseVisualStyleBackColor = false;
            this.btnCarParts.Click += new System.EventHandler(this.btnCarParts_Click);
            // 
            // btnCar
            // 
            this.btnCar.BackColor = System.Drawing.Color.White;
            this.btnCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar.Location = new System.Drawing.Point(58, 41);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(234, 65);
            this.btnCar.TabIndex = 2;
            this.btnCar.Text = "Cars Manage";
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCarParts);
            this.Controls.Add(this.btnCar);
            this.Name = "AdminView";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarParts;
        private System.Windows.Forms.Button btnCar;
    }
}