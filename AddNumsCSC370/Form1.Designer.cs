namespace AddNumsCSC370
{
    partial class OutputBox
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrevBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorBox = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.oooo = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter value: ";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(144, 87);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(122, 20);
            this.InputBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Previously entered:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TotalBox
            // 
            this.TotalBox.AutoSize = true;
            this.TotalBox.Location = new System.Drawing.Point(177, 213);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(13, 13);
            this.TotalBox.TabIndex = 6;
            this.TotalBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Running total:";
            // 
            // PrevBox
            // 
            this.PrevBox.AutoSize = true;
            this.PrevBox.Location = new System.Drawing.Point(177, 184);
            this.PrevBox.Name = "PrevBox";
            this.PrevBox.Size = new System.Drawing.Size(13, 13);
            this.PrevBox.TabIndex = 8;
            this.PrevBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dr. Ferry\'s Steel Factory";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(236, 179);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(45, 23);
            this.undoButton.TabIndex = 11;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // ErrorBox
            // 
            this.ErrorBox.AutoSize = true;
            this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorBox.Location = new System.Drawing.Point(93, 235);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(0, 25);
            this.ErrorBox.TabIndex = 13;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(177, 156);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(13, 13);
            this.count.TabIndex = 15;
            this.count.Text = "0";
            // 
            // oooo
            // 
            this.oooo.AutoSize = true;
            this.oooo.Location = new System.Drawing.Point(73, 156);
            this.oooo.Name = "oooo";
            this.oooo.Size = new System.Drawing.Size(63, 13);
            this.oooo.TabIndex = 14;
            this.oooo.Text = "Shim count:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(0, 256);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(45, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(298, 256);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(45, 23);
            this.printButton.TabIndex = 17;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem
            // 
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem.Name = "enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem";
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem.Text = "Instructions";
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem.Click += new System.EventHandler(this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem_Click);
            // 
            // OutputBox
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 279);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.count);
            this.Controls.Add(this.oooo);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrevBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OutputBox";
            this.Text = "0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PrevBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label ErrorBox;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label oooo;
        private System.Windows.Forms.ToolStripMenuItem enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button printButton;
    }
}

