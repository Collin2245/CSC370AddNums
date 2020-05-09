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
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorBox = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.oooo = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.avgWeight = new System.Windows.Forms.Label();
            this.maxShim = new System.Windows.Forms.Label();
            this.minShim = new System.Windows.Forms.Label();
            this.maxShimWeight = new System.Windows.Forms.Label();
            this.minShimWeight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stDev = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.goalWeightInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.goalWeightLabel = new System.Windows.Forms.Label();
            this.varWeight = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
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
            this.InputBox.Size = new System.Drawing.Size(58, 20);
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
            this.label3.Location = new System.Drawing.Point(73, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Previously entered:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TotalBox
            // 
            this.TotalBox.AutoSize = true;
            this.TotalBox.Location = new System.Drawing.Point(177, 182);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(13, 13);
            this.TotalBox.TabIndex = 6;
            this.TotalBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Running total:";
            // 
            // PrevBox
            // 
            this.PrevBox.AutoSize = true;
            this.PrevBox.Location = new System.Drawing.Point(177, 169);
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
            this.button2.Location = new System.Drawing.Point(298, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(298, 169);
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
            this.helpToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem
            // 
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem.Name = "enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem";
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem.Text = "Instructions";
            this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem.Click += new System.EventHandler(this.enterShimWeightInTheEnterValueColumnThenClickAddToolStripMenuItem_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.AutoSize = true;
            this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ErrorBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorBox.Location = new System.Drawing.Point(141, 65);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(0, 13);
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
            this.saveButton.Location = new System.Drawing.Point(298, 227);
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Avg. shim weight:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // avgWeight
            // 
            this.avgWeight.AutoSize = true;
            this.avgWeight.Location = new System.Drawing.Point(177, 195);
            this.avgWeight.Name = "avgWeight";
            this.avgWeight.Size = new System.Drawing.Size(13, 13);
            this.avgWeight.TabIndex = 19;
            this.avgWeight.Text = "0";
            // 
            // maxShim
            // 
            this.maxShim.AutoSize = true;
            this.maxShim.Location = new System.Drawing.Point(73, 208);
            this.maxShim.Name = "maxShim";
            this.maxShim.Size = new System.Drawing.Size(88, 13);
            this.maxShim.TabIndex = 20;
            this.maxShim.Text = "Max shim weight:";
            this.maxShim.Click += new System.EventHandler(this.label6_Click);
            // 
            // minShim
            // 
            this.minShim.AutoSize = true;
            this.minShim.Location = new System.Drawing.Point(73, 221);
            this.minShim.Name = "minShim";
            this.minShim.Size = new System.Drawing.Size(85, 13);
            this.minShim.TabIndex = 21;
            this.minShim.Text = "Min shim weight:";
            // 
            // maxShimWeight
            // 
            this.maxShimWeight.AutoSize = true;
            this.maxShimWeight.Location = new System.Drawing.Point(177, 208);
            this.maxShimWeight.Name = "maxShimWeight";
            this.maxShimWeight.Size = new System.Drawing.Size(13, 13);
            this.maxShimWeight.TabIndex = 22;
            this.maxShimWeight.Text = "0";
            // 
            // minShimWeight
            // 
            this.minShimWeight.AutoSize = true;
            this.minShimWeight.Location = new System.Drawing.Point(177, 221);
            this.minShimWeight.Name = "minShimWeight";
            this.minShimWeight.Size = new System.Drawing.Size(13, 13);
            this.minShimWeight.TabIndex = 23;
            this.minShimWeight.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Standard deviation:";
            // 
            // stDev
            // 
            this.stDev.AutoSize = true;
            this.stDev.Location = new System.Drawing.Point(177, 234);
            this.stDev.Name = "stDev";
            this.stDev.Size = new System.Drawing.Size(13, 13);
            this.stDev.TabIndex = 25;
            this.stDev.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Goal weight:";
            // 
            // goalWeightInput
            // 
            this.goalWeightInput.Location = new System.Drawing.Point(279, 87);
            this.goalWeightInput.Name = "goalWeightInput";
            this.goalWeightInput.Size = new System.Drawing.Size(51, 20);
            this.goalWeightInput.TabIndex = 27;
            this.goalWeightInput.Text = "100";
            this.goalWeightInput.TextChanged += new System.EventHandler(this.goalWeightInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Amount until goal:";
            // 
            // goalWeightLabel
            // 
            this.goalWeightLabel.AutoSize = true;
            this.goalWeightLabel.Location = new System.Drawing.Point(177, 247);
            this.goalWeightLabel.Name = "goalWeightLabel";
            this.goalWeightLabel.Size = new System.Drawing.Size(25, 13);
            this.goalWeightLabel.TabIndex = 29;
            this.goalWeightLabel.Text = "100";
            // 
            // varWeight
            // 
            this.varWeight.Location = new System.Drawing.Point(12, 201);
            this.varWeight.Name = "varWeight";
            this.varWeight.Size = new System.Drawing.Size(52, 20);
            this.varWeight.TabIndex = 30;
            this.varWeight.Text = "5";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 46);
            this.button3.TabIndex = 31;
            this.button3.Text = "Click to add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OutputBox
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 279);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.varWeight);
            this.Controls.Add(this.goalWeightLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.goalWeightInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stDev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minShimWeight);
            this.Controls.Add(this.maxShimWeight);
            this.Controls.Add(this.minShim);
            this.Controls.Add(this.maxShim);
            this.Controls.Add(this.avgWeight);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label avgWeight;
        private System.Windows.Forms.Label maxShim;
        private System.Windows.Forms.Label minShim;
        private System.Windows.Forms.Label maxShimWeight;
        private System.Windows.Forms.Label minShimWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label stDev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox goalWeightInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label goalWeightLabel;
        private System.Windows.Forms.TextBox varWeight;
        private System.Windows.Forms.Button button3;
    }
}

