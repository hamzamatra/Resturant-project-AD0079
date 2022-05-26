namespace Resturant_project_AD0079
{
    partial class Order
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
            this.txtchoosemenu = new System.Windows.Forms.TextBox();
            this.btnchoosefood = new System.Windows.Forms.Button();
            this.lblFood = new System.Windows.Forms.Label();
            this.btnx = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Menu";
            // 
            // txtchoosemenu
            // 
            this.txtchoosemenu.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchoosemenu.Location = new System.Drawing.Point(510, 69);
            this.txtchoosemenu.Multiline = true;
            this.txtchoosemenu.Name = "txtchoosemenu";
            this.txtchoosemenu.Size = new System.Drawing.Size(346, 53);
            this.txtchoosemenu.TabIndex = 1;
            // 
            // btnchoosefood
            // 
            this.btnchoosefood.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchoosefood.Location = new System.Drawing.Point(540, 128);
            this.btnchoosefood.Name = "btnchoosefood";
            this.btnchoosefood.Size = new System.Drawing.Size(291, 66);
            this.btnchoosefood.TabIndex = 2;
            this.btnchoosefood.Text = "Choose Food";
            this.btnchoosefood.UseVisualStyleBackColor = true;
            this.btnchoosefood.Click += new System.EventHandler(this.btnchoosefood_Click);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(377, 69);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(111, 45);
            this.lblFood.TabIndex = 4;
            this.lblFood.Text = "Food ";
            // 
            // btnx
            // 
            this.btnx.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.Location = new System.Drawing.Point(901, 61);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(74, 53);
            this.btnx.TabIndex = 13;
            this.btnx.Text = "x";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 467);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1614, 315);
            this.dataGridView1.TabIndex = 15;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1614, 782);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.btnchoosefood);
            this.Controls.Add(this.txtchoosemenu);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtchoosemenu;
        private System.Windows.Forms.Button btnchoosefood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}