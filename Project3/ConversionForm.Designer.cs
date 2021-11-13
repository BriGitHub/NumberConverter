namespace Project3
{
    partial class ConversionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionForm));
            this.fromDecimal = new System.Windows.Forms.Button();
            this.toDecimal = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.decValueBox = new System.Windows.Forms.TextBox();
            this.decValueLabel = new System.Windows.Forms.Label();
            this.intVal = new System.Windows.Forms.Label();
            this.intValBox = new System.Windows.Forms.TextBox();
            this.baseChooser = new System.Windows.Forms.NumericUpDown();
            this.baseLabel = new System.Windows.Forms.Label();
            this.resultChooser = new System.Windows.Forms.NumericUpDown();
            this.placeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.baseChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultChooser)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromDecimal
            // 
            this.fromDecimal.Location = new System.Drawing.Point(88, 284);
            this.fromDecimal.Name = "fromDecimal";
            this.fromDecimal.Size = new System.Drawing.Size(248, 55);
            this.fromDecimal.TabIndex = 0;
            this.fromDecimal.Text = "Convert From Decimal";
            this.fromDecimal.UseVisualStyleBackColor = true;
            this.fromDecimal.Click += new System.EventHandler(this.fromDecimal_Click);
            // 
            // toDecimal
            // 
            this.toDecimal.Location = new System.Drawing.Point(376, 284);
            this.toDecimal.Name = "toDecimal";
            this.toDecimal.Size = new System.Drawing.Size(255, 55);
            this.toDecimal.TabIndex = 1;
            this.toDecimal.Text = "Convert To Decimal";
            this.toDecimal.UseVisualStyleBackColor = true;
            this.toDecimal.Click += new System.EventHandler(this.toDecimal_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(666, 284);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(121, 55);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // decValueBox
            // 
            this.decValueBox.Location = new System.Drawing.Point(34, 120);
            this.decValueBox.Name = "decValueBox";
            this.decValueBox.Size = new System.Drawing.Size(238, 31);
            this.decValueBox.TabIndex = 3;
            this.decValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.decValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decValueBox_KeyPress);
            // 
            // decValueLabel
            // 
            this.decValueLabel.AutoSize = true;
            this.decValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decValueLabel.Location = new System.Drawing.Point(29, 81);
            this.decValueLabel.Name = "decValueLabel";
            this.decValueLabel.Size = new System.Drawing.Size(243, 25);
            this.decValueLabel.TabIndex = 4;
            this.decValueLabel.Text = "Decimal Integer Value";
            // 
            // intVal
            // 
            this.intVal.AutoSize = true;
            this.intVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intVal.Location = new System.Drawing.Point(429, 81);
            this.intVal.Name = "intVal";
            this.intVal.Size = new System.Drawing.Size(245, 25);
            this.intVal.TabIndex = 5;
            this.intVal.Text = "Integer Value in Base ";
            // 
            // intValBox
            // 
            this.intValBox.Location = new System.Drawing.Point(434, 120);
            this.intValBox.Name = "intValBox";
            this.intValBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.intValBox.Size = new System.Drawing.Size(492, 31);
            this.intValBox.TabIndex = 6;
            this.intValBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intValBox_KeyPress);
            // 
            // baseChooser
            // 
            this.baseChooser.Location = new System.Drawing.Point(540, 158);
            this.baseChooser.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.baseChooser.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.baseChooser.Name = "baseChooser";
            this.baseChooser.Size = new System.Drawing.Size(91, 31);
            this.baseChooser.TabIndex = 8;
            this.baseChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.baseChooser.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.baseChooser.ValueChanged += new System.EventHandler(this.baseChooser_ValueChanged);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(473, 164);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(61, 25);
            this.baseLabel.TabIndex = 9;
            this.baseLabel.Text = "Base";
            // 
            // resultChooser
            // 
            this.resultChooser.Location = new System.Drawing.Point(834, 162);
            this.resultChooser.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.resultChooser.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.resultChooser.Name = "resultChooser";
            this.resultChooser.Size = new System.Drawing.Size(92, 31);
            this.resultChooser.TabIndex = 10;
            this.resultChooser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultChooser.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.resultChooser.ValueChanged += new System.EventHandler(this.resultChooser_ValueChanged);
            // 
            // placeLabel
            // 
            this.placeLabel.AutoSize = true;
            this.placeLabel.Location = new System.Drawing.Point(661, 164);
            this.placeLabel.Name = "placeLabel";
            this.placeLabel.Size = new System.Drawing.Size(167, 25);
            this.placeLabel.TabIndex = 11;
            this.placeLabel.Text = "Places in Result";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 40);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 374);
            this.Controls.Add(this.placeLabel);
            this.Controls.Add(this.resultChooser);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.baseChooser);
            this.Controls.Add(this.intValBox);
            this.Controls.Add(this.intVal);
            this.Controls.Add(this.decValueLabel);
            this.Controls.Add(this.decValueBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.toDecimal);
            this.Controls.Add(this.fromDecimal);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConversionForm";
            this.Text = "Convert";
            this.Load += new System.EventHandler(this.ConversionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultChooser)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fromDecimal;
        private System.Windows.Forms.Button toDecimal;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox decValueBox;
        private System.Windows.Forms.Label decValueLabel;
        private System.Windows.Forms.Label intVal;
        private System.Windows.Forms.TextBox intValBox;
        private System.Windows.Forms.NumericUpDown baseChooser;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.NumericUpDown resultChooser;
        private System.Windows.Forms.Label placeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

