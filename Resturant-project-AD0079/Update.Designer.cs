namespace Resturant_project_AD0079
{
    partial class Update
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
            this.txtaddfood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddfood = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtaddfood
            // 
            this.txtaddfood.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddfood.Location = new System.Drawing.Point(219, 41);
            this.txtaddfood.Multiline = true;
            this.txtaddfood.Name = "txtaddfood";
            this.txtaddfood.Size = new System.Drawing.Size(336, 49);
            this.txtaddfood.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Food";
            // 
            // btnaddfood
            // 
            this.btnaddfood.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddfood.Location = new System.Drawing.Point(733, 23);
            this.btnaddfood.Name = "btnaddfood";
            this.btnaddfood.Size = new System.Drawing.Size(236, 82);
            this.btnaddfood.TabIndex = 10;
            this.btnaddfood.Text = "Add Food";
            this.btnaddfood.UseVisualStyleBackColor = true;
            this.btnaddfood.Click += new System.EventHandler(this.btnaddfood_Click);
            // 
            // btnx
            // 
            this.btnx.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.Location = new System.Drawing.Point(561, 41);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(74, 51);
            this.btnx.TabIndex = 12;
            this.btnx.Text = "x";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 315);
            this.dataGridView1.TabIndex = 16;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.btnaddfood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaddfood);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaddfood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddfood;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}