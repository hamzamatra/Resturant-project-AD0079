namespace Resturant_project_AD0079
{
    partial class Clear
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
            this.lstmenu = new System.Windows.Forms.ListBox();
            this.lstDrinks = new System.Windows.Forms.ListBox();
            this.btnclearfood = new System.Windows.Forms.Button();
            this.btncleardrinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lstmenu.Location = new System.Drawing.Point(332, 12);
            this.lstmenu.Name = "lstmenu";
            this.lstmenu.Size = new System.Drawing.Size(232, 340);
            this.lstmenu.TabIndex = 5;
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
            this.lstDrinks.Location = new System.Drawing.Point(719, 12);
            this.lstDrinks.Name = "lstDrinks";
            this.lstDrinks.Size = new System.Drawing.Size(208, 328);
            this.lstDrinks.TabIndex = 10;
            // 
            // btnclearfood
            // 
            this.btnclearfood.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearfood.Location = new System.Drawing.Point(357, 358);
            this.btnclearfood.Name = "btnclearfood";
            this.btnclearfood.Size = new System.Drawing.Size(166, 59);
            this.btnclearfood.TabIndex = 11;
            this.btnclearfood.Text = "Clear";
            this.btnclearfood.UseVisualStyleBackColor = true;
            this.btnclearfood.Click += new System.EventHandler(this.btnclearfood_Click);
            // 
            // btncleardrinks
            // 
            this.btncleardrinks.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncleardrinks.ForeColor = System.Drawing.Color.Black;
            this.btncleardrinks.Location = new System.Drawing.Point(728, 358);
            this.btncleardrinks.Name = "btncleardrinks";
            this.btncleardrinks.Size = new System.Drawing.Size(166, 59);
            this.btncleardrinks.TabIndex = 12;
            this.btncleardrinks.Text = "Clear";
            this.btncleardrinks.UseVisualStyleBackColor = true;
            this.btncleardrinks.Click += new System.EventHandler(this.btncleardrinks_Click);
            // 
            // Clear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 527);
            this.Controls.Add(this.btncleardrinks);
            this.Controls.Add(this.btnclearfood);
            this.Controls.Add(this.lstDrinks);
            this.Controls.Add(this.lstmenu);
            this.Name = "Clear";
            this.Text = "Clear";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstmenu;
        private System.Windows.Forms.ListBox lstDrinks;
        private System.Windows.Forms.Button btnclearfood;
        private System.Windows.Forms.Button btncleardrinks;
    }
}