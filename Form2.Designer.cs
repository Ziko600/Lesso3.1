namespace Lesso3._1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.productname = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.TextBox();
            this.origin_country = new System.Windows.Forms.TextBox();
            this.product_cost = new System.Windows.Forms.TextBox();
            this.origincountry = new System.Windows.Forms.Label();
            this.productcost = new System.Windows.Forms.Label();
            this.okbtn = new System.Windows.Forms.Button();
            this.canselbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productname
            // 
            this.productname.AutoSize = true;
            this.productname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productname.Location = new System.Drawing.Point(47, 66);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(87, 15);
            this.productname.TabIndex = 0;
            this.productname.Text = "Product Name:";
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(47, 84);
            this.product_name.Multiline = true;
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(169, 29);
            this.product_name.TabIndex = 1;
            // 
            // origin_country
            // 
            this.origin_country.Location = new System.Drawing.Point(47, 144);
            this.origin_country.Multiline = true;
            this.origin_country.Name = "origin_country";
            this.origin_country.Size = new System.Drawing.Size(169, 29);
            this.origin_country.TabIndex = 2;
            // 
            // product_cost
            // 
            this.product_cost.Location = new System.Drawing.Point(47, 215);
            this.product_cost.Multiline = true;
            this.product_cost.Name = "product_cost";
            this.product_cost.Size = new System.Drawing.Size(169, 29);
            this.product_cost.TabIndex = 3;
            // 
            // origincountry
            // 
            this.origincountry.AutoSize = true;
            this.origincountry.Location = new System.Drawing.Point(47, 126);
            this.origincountry.Name = "origincountry";
            this.origincountry.Size = new System.Drawing.Size(89, 15);
            this.origincountry.TabIndex = 4;
            this.origincountry.Text = "Origin Country:";
            // 
            // productcost
            // 
            this.productcost.AutoSize = true;
            this.productcost.Location = new System.Drawing.Point(47, 187);
            this.productcost.Name = "productcost";
            this.productcost.Size = new System.Drawing.Size(79, 15);
            this.productcost.TabIndex = 5;
            this.productcost.Text = "Product Cost:";
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(47, 275);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(62, 32);
            this.okbtn.TabIndex = 6;
            this.okbtn.Text = "Ok";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // canselbtn
            // 
            this.canselbtn.Location = new System.Drawing.Point(154, 275);
            this.canselbtn.Name = "canselbtn";
            this.canselbtn.Size = new System.Drawing.Size(62, 32);
            this.canselbtn.TabIndex = 7;
            this.canselbtn.Text = "Cancel";
            this.canselbtn.UseVisualStyleBackColor = true;
            this.canselbtn.Click += new System.EventHandler(this.canselbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 362);
            this.Controls.Add(this.canselbtn);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.productcost);
            this.Controls.Add(this.origincountry);
            this.Controls.Add(this.product_cost);
            this.Controls.Add(this.origin_country);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.productname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label productname;
        public TextBox product_name;
        public TextBox origin_country;
        public TextBox product_cost;
        public Label origincountry;
        public Label productcost;
        public Button okbtn;
        public Button canselbtn;
    }
}