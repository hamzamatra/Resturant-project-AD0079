namespace Resturant_project_AD0079
{
    partial class opinion
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
            this.txtopinion = new System.Windows.Forms.TextBox();
            this.lblopinion = new System.Windows.Forms.Label();
            this.btnaddopinion = new System.Windows.Forms.Button();
            this.btnclearopinion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtopinion
            // 
            this.txtopinion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtopinion.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopinion.Location = new System.Drawing.Point(0, 0);
            this.txtopinion.Multiline = true;
            this.txtopinion.Name = "txtopinion";
            this.txtopinion.Size = new System.Drawing.Size(1015, 208);
            this.txtopinion.TabIndex = 0;
            // 
            // lblopinion
            // 
            this.lblopinion.AutoSize = true;
            this.lblopinion.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopinion.Location = new System.Drawing.Point(12, 256);
            this.lblopinion.Name = "lblopinion";
            this.lblopinion.Size = new System.Drawing.Size(0, 34);
            this.lblopinion.TabIndex = 1;
            // 
            // btnaddopinion
            // 
            this.btnaddopinion.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddopinion.Location = new System.Drawing.Point(164, 383);
            this.btnaddopinion.Name = "btnaddopinion";
            this.btnaddopinion.Size = new System.Drawing.Size(284, 53);
            this.btnaddopinion.TabIndex = 2;
            this.btnaddopinion.Text = "add your opinion ";
            this.btnaddopinion.UseVisualStyleBackColor = true;
            this.btnaddopinion.Click += new System.EventHandler(this.btnaddopinion_Click);
            // 
            // btnclearopinion
            // 
            this.btnclearopinion.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearopinion.Location = new System.Drawing.Point(490, 383);
            this.btnclearopinion.Name = "btnclearopinion";
            this.btnclearopinion.Size = new System.Drawing.Size(309, 53);
            this.btnclearopinion.TabIndex = 3;
            this.btnclearopinion.Text = "clear your opinion ";
            this.btnclearopinion.UseVisualStyleBackColor = true;
            this.btnclearopinion.Click += new System.EventHandler(this.btnclearopinion_Click);
            // 
            // opinion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 524);
            this.Controls.Add(this.btnclearopinion);
            this.Controls.Add(this.btnaddopinion);
            this.Controls.Add(this.lblopinion);
            this.Controls.Add(this.txtopinion);
            this.Name = "opinion";
            this.Text = "opinion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtopinion;
        private System.Windows.Forms.Label lblopinion;
        private System.Windows.Forms.Button btnaddopinion;
        private System.Windows.Forms.Button btnclearopinion;
    }
}