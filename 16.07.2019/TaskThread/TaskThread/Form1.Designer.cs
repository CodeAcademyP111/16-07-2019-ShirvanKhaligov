namespace TaskThread
{
    partial class Form1
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
            this.BtnAsny = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnSyn = new System.Windows.Forms.Button();
            this.BtnParalel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAsny
            // 
            this.BtnAsny.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAsny.Location = new System.Drawing.Point(273, 33);
            this.BtnAsny.Name = "BtnAsny";
            this.BtnAsny.Size = new System.Drawing.Size(250, 50);
            this.BtnAsny.TabIndex = 0;
            this.BtnAsny.Text = "Get Content Url Asyn";
            this.BtnAsny.UseVisualStyleBackColor = true;
            this.BtnAsny.Click += new System.EventHandler(this.BtnAsny_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(258, 135);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(296, 199);
            this.listBox.TabIndex = 1;
            // 
            // btnSyn
            // 
            this.btnSyn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSyn.Location = new System.Drawing.Point(12, 33);
            this.btnSyn.Name = "btnSyn";
            this.btnSyn.Size = new System.Drawing.Size(255, 50);
            this.btnSyn.TabIndex = 2;
            this.btnSyn.Text = "Get Content Url Syn";
            this.btnSyn.UseVisualStyleBackColor = true;
            this.btnSyn.Click += new System.EventHandler(this.BtnSyn_Click);
            // 
            // BtnParalel
            // 
            this.BtnParalel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnParalel.Location = new System.Drawing.Point(529, 33);
            this.BtnParalel.Name = "BtnParalel";
            this.BtnParalel.Size = new System.Drawing.Size(259, 50);
            this.BtnParalel.TabIndex = 3;
            this.BtnParalel.Text = "Get Content Url Paralel";
            this.BtnParalel.UseVisualStyleBackColor = true;
            this.BtnParalel.Click += new System.EventHandler(this.BtnParalel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnParalel);
            this.Controls.Add(this.btnSyn);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.BtnAsny);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAsny;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnSyn;
        private System.Windows.Forms.Button BtnParalel;
    }
}

