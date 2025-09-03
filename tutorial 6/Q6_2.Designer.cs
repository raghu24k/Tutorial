namespace WindowsFormsApp1
{
    partial class Q6_2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.fill_btn = new System.Windows.Forms.Button();
            this.Count_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.sort_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.lblselection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(106, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // fill_btn
            // 
            this.fill_btn.Location = new System.Drawing.Point(313, 22);
            this.fill_btn.Name = "fill_btn";
            this.fill_btn.Size = new System.Drawing.Size(75, 23);
            this.fill_btn.TabIndex = 2;
            this.fill_btn.Text = "Fill";
            this.fill_btn.UseVisualStyleBackColor = true;
            this.fill_btn.Click += new System.EventHandler(this.fill_btn_Click);
            // 
            // Count_btn
            // 
            this.Count_btn.Location = new System.Drawing.Point(106, 169);
            this.Count_btn.Name = "Count_btn";
            this.Count_btn.Size = new System.Drawing.Size(75, 23);
            this.Count_btn.TabIndex = 3;
            this.Count_btn.Text = "Count";
            this.Count_btn.UseVisualStyleBackColor = true;
            this.Count_btn.Click += new System.EventHandler(this.Count_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(313, 117);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 4;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // sort_btn
            // 
            this.sort_btn.Location = new System.Drawing.Point(313, 69);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(75, 23);
            this.sort_btn.TabIndex = 5;
            this.sort_btn.Text = "Sort";
            this.sort_btn.UseVisualStyleBackColor = true;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(295, 169);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(142, 23);
            this.remove_btn.TabIndex = 6;
            this.remove_btn.Text = "Remove Item";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(113, 238);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(122, 16);
            this.lblcount.TabIndex = 7;
            this.lblcount.Text = "Display Total items";
            // 
            // lblselection
            // 
            this.lblselection.AutoSize = true;
            this.lblselection.Location = new System.Drawing.Point(301, 238);
            this.lblselection.Name = "lblselection";
            this.lblselection.Size = new System.Drawing.Size(94, 16);
            this.lblselection.TabIndex = 8;
            this.lblselection.Text = "Your Selection";
            // 
            // Q6_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblselection);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.sort_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.Count_btn);
            this.Controls.Add(this.fill_btn);
            this.Controls.Add(this.listBox1);
            this.Name = "Q6_2";
            this.Text = "Q6_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button fill_btn;
        private System.Windows.Forms.Button Count_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblselection;
    }
}