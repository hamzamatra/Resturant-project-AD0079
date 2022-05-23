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
            this.lstmenu = new System.Windows.Forms.ListBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.txtDrinks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.lstDrinks = new System.Windows.Forms.ListBox();
            this.btnx = new System.Windows.Forms.Button();
            this.btnx2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Menu";
            // 
            // txtchoosemenu
            // 
            this.txtchoosemenu.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchoosemenu.Location = new System.Drawing.Point(146, 98);
            this.txtchoosemenu.Multiline = true;
            this.txtchoosemenu.Name = "txtchoosemenu";
            this.txtchoosemenu.Size = new System.Drawing.Size(346, 53);
            this.txtchoosemenu.TabIndex = 1;
            // 
            // btnchoosefood
            // 
            this.btnchoosefood.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchoosefood.Location = new System.Drawing.Point(182, 240);
            this.btnchoosefood.Name = "btnchoosefood";
            this.btnchoosefood.Size = new System.Drawing.Size(291, 66);
            this.btnchoosefood.TabIndex = 2;
            this.btnchoosefood.Text = "Choose Food";
            this.btnchoosefood.UseVisualStyleBackColor = true;
            this.btnchoosefood.Click += new System.EventHandler(this.btnchoosefood_Click);
            // 
            // lstmenu
            // 
            this.lstmenu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstmenu.FormattingEnabled = true;
            this.lstmenu.ItemHeight = 28;
            this.lstmenu.Items.AddRange(new object[] {
            "blown",
            "Kabsa",
            "Pizza",
            "Burger",
            "Shawarma",
            "the pasta",
            "Fettuccine",
            "pastries",
            "biryani",
            "potato tray",
            "flower tray",
            "varicose veins",
            "stuffed zucchini",
            "kofta",
            "fish"});
            this.lstmenu.Location = new System.Drawing.Point(589, 12);
            this.lstmenu.Name = "lstmenu";
            this.lstmenu.Size = new System.Drawing.Size(232, 508);
            this.lstmenu.TabIndex = 3;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(12, 97);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(111, 45);
            this.lblFood.TabIndex = 4;
            this.lblFood.Text = "Food ";
            // 
            // txtDrinks
            // 
            this.txtDrinks.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrinks.Location = new System.Drawing.Point(146, 181);
            this.txtDrinks.Multiline = true;
            this.txtDrinks.Name = "txtDrinks";
            this.txtDrinks.Size = new System.Drawing.Size(346, 53);
            this.txtDrinks.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Drinks ";
            // 
            // btnDrinks
            // 
            this.btnDrinks.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinks.Location = new System.Drawing.Point(182, 329);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(291, 66);
            this.btnDrinks.TabIndex = 7;
            this.btnDrinks.Text = "Choose Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // lstDrinks
            // 
            this.lstDrinks.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDrinks.FormattingEnabled = true;
            this.lstDrinks.ItemHeight = 36;
            this.lstDrinks.Items.AddRange(new object[] {
            "Pepsi",
            "Mirinda",
            "Seven",
            "Fanta",
            "Shanny",
            "an orange",
            "apple",
            "Rani",
            "cocktail",
            "kiwi",
            "Lemon and mint",
            "Banana and strawberry"});
            this.lstDrinks.Location = new System.Drawing.Point(827, 9);
            this.lstDrinks.Name = "lstDrinks";
            this.lstDrinks.Size = new System.Drawing.Size(208, 508);
            this.lstDrinks.TabIndex = 8;
            // 
            // btnx
            // 
            this.btnx.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.Location = new System.Drawing.Point(498, 98);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(74, 53);
            this.btnx.TabIndex = 13;
            this.btnx.Text = "x";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btnx2
            // 
            this.btnx2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx2.Location = new System.Drawing.Point(498, 183);
            this.btnx2.Name = "btnx2";
            this.btnx2.Size = new System.Drawing.Size(74, 48);
            this.btnx2.TabIndex = 14;
            this.btnx2.Text = "x";
            this.btnx2.UseVisualStyleBackColor = true;
            this.btnx2.Click += new System.EventHandler(this.btnx2_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1033, 519);
            this.Controls.Add(this.btnx2);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.lstDrinks);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDrinks);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lstmenu);
            this.Controls.Add(this.btnchoosefood);
            this.Controls.Add(this.txtchoosemenu);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtchoosemenu;
        private System.Windows.Forms.Button btnchoosefood;
        private System.Windows.Forms.ListBox lstmenu;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.TextBox txtDrinks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.ListBox lstDrinks;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Button btnx2;
    }
}