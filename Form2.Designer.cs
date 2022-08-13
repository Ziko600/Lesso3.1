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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 29);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 144);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 29);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(47, 215);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 29);
            this.textBox3.TabIndex = 3;
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
            // 
            // canselbtn
            // 
            this.canselbtn.Location = new System.Drawing.Point(154, 275);
            this.canselbtn.Name = "canselbtn";
            this.canselbtn.Size = new System.Drawing.Size(62, 32);
            this.canselbtn.TabIndex = 7;
            this.canselbtn.Text = "Cancel";
            this.canselbtn.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.productname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productname;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label origincountry;
        private Label productcost;
        private Button okbtn;
        private Button canselbtn;
    }
}