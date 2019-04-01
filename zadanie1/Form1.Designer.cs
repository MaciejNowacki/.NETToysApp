namespace zadanie1
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
            this.listOfToys = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listOfCreated = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valueOfSpeed = new System.Windows.Forms.TextBox();
            this.DecreaseSpeed = new System.Windows.Forms.Button();
            this.IncreaseSpeed = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valueOfAlt = new System.Windows.Forms.TextBox();
            this.DecreaseAlt = new System.Windows.Forms.Button();
            this.IncreaseAlt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.valueOfDepth = new System.Windows.Forms.TextBox();
            this.DecreaseDepth = new System.Windows.Forms.Button();
            this.IncreaseDepth = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfToys
            // 
            this.listOfToys.FormattingEnabled = true;
            this.listOfToys.Items.AddRange(new object[] {
            "Car",
            "Plane",
            "Submarine",
            "Computer"});
            this.listOfToys.Location = new System.Drawing.Point(60, 41);
            this.listOfToys.Name = "listOfToys";
            this.listOfToys.Size = new System.Drawing.Size(204, 615);
            this.listOfToys.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(355, 156);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(156, 43);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOfCreated
            // 
            this.listOfCreated.FormattingEnabled = true;
            this.listOfCreated.Location = new System.Drawing.Point(601, 41);
            this.listOfCreated.Name = "listOfCreated";
            this.listOfCreated.Size = new System.Drawing.Size(163, 615);
            this.listOfCreated.TabIndex = 2;
            this.listOfCreated.Click += new System.EventHandler(this.listOfCreated_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valueOfSpeed);
            this.groupBox1.Controls.Add(this.DecreaseSpeed);
            this.groupBox1.Controls.Add(this.IncreaseSpeed);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(816, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "speed";
            // 
            // valueOfSpeed
            // 
            this.valueOfSpeed.Location = new System.Drawing.Point(87, 38);
            this.valueOfSpeed.Name = "valueOfSpeed";
            this.valueOfSpeed.ReadOnly = true;
            this.valueOfSpeed.Size = new System.Drawing.Size(66, 20);
            this.valueOfSpeed.TabIndex = 1;
            this.valueOfSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DecreaseSpeed
            // 
            this.DecreaseSpeed.Location = new System.Drawing.Point(159, 36);
            this.DecreaseSpeed.Name = "DecreaseSpeed";
            this.DecreaseSpeed.Size = new System.Drawing.Size(75, 23);
            this.DecreaseSpeed.TabIndex = 0;
            this.DecreaseSpeed.Text = "-";
            this.DecreaseSpeed.UseVisualStyleBackColor = true;
            this.DecreaseSpeed.Click += new System.EventHandler(this.DecreaseSpeed_Click);
            // 
            // IncreaseSpeed
            // 
            this.IncreaseSpeed.Location = new System.Drawing.Point(6, 36);
            this.IncreaseSpeed.Name = "IncreaseSpeed";
            this.IncreaseSpeed.Size = new System.Drawing.Size(75, 23);
            this.IncreaseSpeed.TabIndex = 0;
            this.IncreaseSpeed.Text = "+";
            this.IncreaseSpeed.UseVisualStyleBackColor = true;
            this.IncreaseSpeed.Click += new System.EventHandler(this.IncreaseSpeed_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.valueOfAlt);
            this.groupBox2.Controls.Add(this.DecreaseAlt);
            this.groupBox2.Controls.Add(this.IncreaseAlt);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(816, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 72);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "alt";
            // 
            // valueOfAlt
            // 
            this.valueOfAlt.Location = new System.Drawing.Point(87, 38);
            this.valueOfAlt.Name = "valueOfAlt";
            this.valueOfAlt.ReadOnly = true;
            this.valueOfAlt.Size = new System.Drawing.Size(66, 20);
            this.valueOfAlt.TabIndex = 1;
            this.valueOfAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DecreaseAlt
            // 
            this.DecreaseAlt.Location = new System.Drawing.Point(159, 36);
            this.DecreaseAlt.Name = "DecreaseAlt";
            this.DecreaseAlt.Size = new System.Drawing.Size(75, 23);
            this.DecreaseAlt.TabIndex = 0;
            this.DecreaseAlt.Text = "-";
            this.DecreaseAlt.UseVisualStyleBackColor = true;
            this.DecreaseAlt.Click += new System.EventHandler(this.DecreaseAlt_Click);
            // 
            // IncreaseAlt
            // 
            this.IncreaseAlt.Location = new System.Drawing.Point(6, 36);
            this.IncreaseAlt.Name = "IncreaseAlt";
            this.IncreaseAlt.Size = new System.Drawing.Size(75, 23);
            this.IncreaseAlt.TabIndex = 0;
            this.IncreaseAlt.Text = "+";
            this.IncreaseAlt.UseVisualStyleBackColor = true;
            this.IncreaseAlt.Click += new System.EventHandler(this.IncreaseAlt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.valueOfDepth);
            this.groupBox3.Controls.Add(this.DecreaseDepth);
            this.groupBox3.Controls.Add(this.IncreaseDepth);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(816, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 72);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "depth";
            // 
            // valueOfDepth
            // 
            this.valueOfDepth.Location = new System.Drawing.Point(87, 38);
            this.valueOfDepth.Name = "valueOfDepth";
            this.valueOfDepth.ReadOnly = true;
            this.valueOfDepth.Size = new System.Drawing.Size(66, 20);
            this.valueOfDepth.TabIndex = 1;
            this.valueOfDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DecreaseDepth
            // 
            this.DecreaseDepth.Location = new System.Drawing.Point(159, 36);
            this.DecreaseDepth.Name = "DecreaseDepth";
            this.DecreaseDepth.Size = new System.Drawing.Size(75, 23);
            this.DecreaseDepth.TabIndex = 0;
            this.DecreaseDepth.Text = "-";
            this.DecreaseDepth.UseVisualStyleBackColor = true;
            this.DecreaseDepth.Click += new System.EventHandler(this.DecreaseDepth_Click);
            // 
            // IncreaseDepth
            // 
            this.IncreaseDepth.Location = new System.Drawing.Point(6, 36);
            this.IncreaseDepth.Name = "IncreaseDepth";
            this.IncreaseDepth.Size = new System.Drawing.Size(75, 23);
            this.IncreaseDepth.TabIndex = 0;
            this.IncreaseDepth.Text = "+";
            this.IncreaseDepth.UseVisualStyleBackColor = true;
            this.IncreaseDepth.Click += new System.EventHandler(this.IncreaseDepth_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(355, 224);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(156, 43);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 690);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listOfCreated);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listOfToys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfToys;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listOfCreated;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valueOfSpeed;
        private System.Windows.Forms.Button DecreaseSpeed;
        private System.Windows.Forms.Button IncreaseSpeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox valueOfAlt;
        private System.Windows.Forms.Button DecreaseAlt;
        private System.Windows.Forms.Button IncreaseAlt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox valueOfDepth;
        private System.Windows.Forms.Button DecreaseDepth;
        private System.Windows.Forms.Button IncreaseDepth;
        private System.Windows.Forms.Button buttonRemove;
    }
}

