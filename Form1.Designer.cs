namespace Lesso3._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listform1 = new System.Windows.Forms.ListBox();
            this.editproduct = new System.Windows.Forms.Button();
            this.removeproduct = new System.Windows.Forms.Button();
            this.clearlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listform1
            // 
            this.listform1.FormattingEnabled = true;
            this.listform1.ItemHeight = 15;
            this.listform1.Location = new System.Drawing.Point(29, 25);
            this.listform1.Name = "listform1";
            this.listform1.Size = new System.Drawing.Size(220, 304);
            this.listform1.TabIndex = 0;
            // 
            // editproduct
            // 
            this.editproduct.Location = new System.Drawing.Point(29, 344);
            this.editproduct.Name = "editproduct";
            this.editproduct.Size = new System.Drawing.Size(220, 31);
            this.editproduct.TabIndex = 2;
            this.editproduct.Text = "Edit Product";
            this.editproduct.UseVisualStyleBackColor = true;
            this.editproduct.Click += new System.EventHandler(this.editproduct_Click);
            // 
            // removeproduct
            // 
            this.removeproduct.Location = new System.Drawing.Point(29, 381);
            this.removeproduct.Name = "removeproduct";
            this.removeproduct.Size = new System.Drawing.Size(220, 31);
            this.removeproduct.TabIndex = 3;
            this.removeproduct.Text = "Remove Product";
            this.removeproduct.UseVisualStyleBackColor = true;
            this.removeproduct.Click += new System.EventHandler(this.removeproduct_Click);
            // 
            // clearlist
            // 
            this.clearlist.Location = new System.Drawing.Point(29, 418);
            this.clearlist.Name = "clearlist";
            this.clearlist.Size = new System.Drawing.Size(220, 31);
            this.clearlist.TabIndex = 4;
            this.clearlist.Text = "Clear List";
            this.clearlist.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 466);
            this.Controls.Add(this.clearlist);
            this.Controls.Add(this.removeproduct);
            this.Controls.Add(this.editproduct);
            this.Controls.Add(this.listform1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public ListBox listform1;
        public Button editproduct;
        public Button removeproduct;
        public Button clearlist;
    }
}