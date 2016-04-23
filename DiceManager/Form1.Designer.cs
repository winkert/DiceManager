namespace DiceManager
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
            this.pnl_ButtonCollector = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Results = new System.Windows.Forms.TextBox();
            this.txt_RollName = new System.Windows.Forms.TextBox();
            this.btn_CreateRoll = new System.Windows.Forms.Button();
            this.txt_RollValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRollSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ButtonCollector
            // 
            this.pnl_ButtonCollector.Location = new System.Drawing.Point(12, 96);
            this.pnl_ButtonCollector.Name = "pnl_ButtonCollector";
            this.pnl_ButtonCollector.Size = new System.Drawing.Size(316, 241);
            this.pnl_ButtonCollector.TabIndex = 3;
            // 
            // txt_Results
            // 
            this.txt_Results.AcceptsReturn = true;
            this.txt_Results.Location = new System.Drawing.Point(334, 44);
            this.txt_Results.Multiline = true;
            this.txt_Results.Name = "txt_Results";
            this.txt_Results.ReadOnly = true;
            this.txt_Results.Size = new System.Drawing.Size(171, 293);
            this.txt_Results.TabIndex = 4;
            // 
            // txt_RollName
            // 
            this.txt_RollName.Location = new System.Drawing.Point(69, 44);
            this.txt_RollName.Name = "txt_RollName";
            this.txt_RollName.Size = new System.Drawing.Size(100, 20);
            this.txt_RollName.TabIndex = 0;
            // 
            // btn_CreateRoll
            // 
            this.btn_CreateRoll.Location = new System.Drawing.Point(175, 44);
            this.btn_CreateRoll.Name = "btn_CreateRoll";
            this.btn_CreateRoll.Size = new System.Drawing.Size(68, 23);
            this.btn_CreateRoll.TabIndex = 2;
            this.btn_CreateRoll.Text = "Create";
            this.btn_CreateRoll.UseVisualStyleBackColor = true;
            this.btn_CreateRoll.Click += new System.EventHandler(this.btn_CreateRoll_Click);
            // 
            // txt_RollValue
            // 
            this.txt_RollValue.Location = new System.Drawing.Point(69, 70);
            this.txt_RollValue.Name = "txt_RollValue";
            this.txt_RollValue.Size = new System.Drawing.Size(100, 20);
            this.txt_RollValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Roll";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveRollSetToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearResultsToolStripMenuItem,
            this.clearButtonsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearResultsToolStripMenuItem
            // 
            this.clearResultsToolStripMenuItem.Name = "clearResultsToolStripMenuItem";
            this.clearResultsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearResultsToolStripMenuItem.Text = "Clear Results";
            this.clearResultsToolStripMenuItem.Click += new System.EventHandler(this.clearResultsToolStripMenuItem_Click);
            // 
            // clearButtonsToolStripMenuItem
            // 
            this.clearButtonsToolStripMenuItem.Name = "clearButtonsToolStripMenuItem";
            this.clearButtonsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearButtonsToolStripMenuItem.Text = "Clear Buttons";
            this.clearButtonsToolStripMenuItem.Click += new System.EventHandler(this.clearButtonsToolStripMenuItem_Click);
            // 
            // saveRollSetToolStripMenuItem
            // 
            this.saveRollSetToolStripMenuItem.Name = "saveRollSetToolStripMenuItem";
            this.saveRollSetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveRollSetToolStripMenuItem.Text = "Save Roll Set";
            this.saveRollSetToolStripMenuItem.Click += new System.EventHandler(this.saveRollSetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Load Roll Set";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.loadRollSetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RollValue);
            this.Controls.Add(this.btn_CreateRoll);
            this.Controls.Add(this.txt_RollName);
            this.Controls.Add(this.txt_Results);
            this.Controls.Add(this.pnl_ButtonCollector);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dice Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_ButtonCollector;
        private System.Windows.Forms.TextBox txt_Results;
        private System.Windows.Forms.TextBox txt_RollName;
        private System.Windows.Forms.Button btn_CreateRoll;
        private System.Windows.Forms.TextBox txt_RollValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRollSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearButtonsToolStripMenuItem;
    }
}

