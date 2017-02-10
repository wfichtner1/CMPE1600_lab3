namespace CMPE1600_Lab3
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
            this.UI_OpenFile = new System.Windows.Forms.Button();
            this.UI_SaveFile = new System.Windows.Forms.Button();
            this.UI_DrawButton = new System.Windows.Forms.Button();
            this.UI_PlayBack = new System.Windows.Forms.Button();
            this.UI_EraseScreen = new System.Windows.Forms.Button();
            this.UI_EraseListButton = new System.Windows.Forms.Button();
            this.UI_DiameterUpDown = new System.Windows.Forms.NumericUpDown();
            this.UI_DiamLabel = new System.Windows.Forms.Label();
            this.UI_ColorBox = new System.Windows.Forms.GroupBox();
            this.UI_RedRadio = new System.Windows.Forms.RadioButton();
            this.UI_GreenRadio = new System.Windows.Forms.RadioButton();
            this.UI_BlueRadio = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.UI_ColorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UI_XcoorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UI_YcoorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UI_DiameterColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.UI_DiameterUpDown)).BeginInit();
            this.UI_ColorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_OpenFile
            // 
            this.UI_OpenFile.Location = new System.Drawing.Point(12, 12);
            this.UI_OpenFile.Name = "UI_OpenFile";
            this.UI_OpenFile.Size = new System.Drawing.Size(141, 23);
            this.UI_OpenFile.TabIndex = 0;
            this.UI_OpenFile.Text = "Open File";
            this.UI_OpenFile.UseVisualStyleBackColor = true;
            // 
            // UI_SaveFile
            // 
            this.UI_SaveFile.Location = new System.Drawing.Point(12, 41);
            this.UI_SaveFile.Name = "UI_SaveFile";
            this.UI_SaveFile.Size = new System.Drawing.Size(141, 23);
            this.UI_SaveFile.TabIndex = 1;
            this.UI_SaveFile.Text = "Save File";
            this.UI_SaveFile.UseVisualStyleBackColor = true;
            // 
            // UI_DrawButton
            // 
            this.UI_DrawButton.Location = new System.Drawing.Point(12, 70);
            this.UI_DrawButton.Name = "UI_DrawButton";
            this.UI_DrawButton.Size = new System.Drawing.Size(141, 23);
            this.UI_DrawButton.TabIndex = 2;
            this.UI_DrawButton.Text = "Draw";
            this.UI_DrawButton.UseVisualStyleBackColor = true;
            // 
            // UI_PlayBack
            // 
            this.UI_PlayBack.Location = new System.Drawing.Point(12, 99);
            this.UI_PlayBack.Name = "UI_PlayBack";
            this.UI_PlayBack.Size = new System.Drawing.Size(141, 23);
            this.UI_PlayBack.TabIndex = 3;
            this.UI_PlayBack.Text = "Play Back";
            this.UI_PlayBack.UseVisualStyleBackColor = true;
            // 
            // UI_EraseScreen
            // 
            this.UI_EraseScreen.Location = new System.Drawing.Point(12, 128);
            this.UI_EraseScreen.Name = "UI_EraseScreen";
            this.UI_EraseScreen.Size = new System.Drawing.Size(141, 23);
            this.UI_EraseScreen.TabIndex = 4;
            this.UI_EraseScreen.Text = "Erase Screen";
            this.UI_EraseScreen.UseVisualStyleBackColor = true;
            // 
            // UI_EraseListButton
            // 
            this.UI_EraseListButton.Location = new System.Drawing.Point(12, 157);
            this.UI_EraseListButton.Name = "UI_EraseListButton";
            this.UI_EraseListButton.Size = new System.Drawing.Size(141, 23);
            this.UI_EraseListButton.TabIndex = 5;
            this.UI_EraseListButton.Text = "Erase List";
            this.UI_EraseListButton.UseVisualStyleBackColor = true;
            // 
            // UI_DiameterUpDown
            // 
            this.UI_DiameterUpDown.Location = new System.Drawing.Point(13, 187);
            this.UI_DiameterUpDown.Name = "UI_DiameterUpDown";
            this.UI_DiameterUpDown.Size = new System.Drawing.Size(85, 20);
            this.UI_DiameterUpDown.TabIndex = 6;
            // 
            // UI_DiamLabel
            // 
            this.UI_DiamLabel.AutoSize = true;
            this.UI_DiamLabel.Location = new System.Drawing.Point(104, 189);
            this.UI_DiamLabel.Name = "UI_DiamLabel";
            this.UI_DiamLabel.Size = new System.Drawing.Size(49, 13);
            this.UI_DiamLabel.TabIndex = 7;
            this.UI_DiamLabel.Text = "Diameter";
            // 
            // UI_ColorBox
            // 
            this.UI_ColorBox.Controls.Add(this.UI_BlueRadio);
            this.UI_ColorBox.Controls.Add(this.UI_GreenRadio);
            this.UI_ColorBox.Controls.Add(this.UI_RedRadio);
            this.UI_ColorBox.Location = new System.Drawing.Point(12, 205);
            this.UI_ColorBox.Name = "UI_ColorBox";
            this.UI_ColorBox.Size = new System.Drawing.Size(105, 100);
            this.UI_ColorBox.TabIndex = 8;
            this.UI_ColorBox.TabStop = false;
            this.UI_ColorBox.Text = "Color";
            // 
            // UI_RedRadio
            // 
            this.UI_RedRadio.AutoSize = true;
            this.UI_RedRadio.Location = new System.Drawing.Point(7, 20);
            this.UI_RedRadio.Name = "UI_RedRadio";
            this.UI_RedRadio.Size = new System.Drawing.Size(45, 17);
            this.UI_RedRadio.TabIndex = 0;
            this.UI_RedRadio.TabStop = true;
            this.UI_RedRadio.Text = "Red";
            this.UI_RedRadio.UseVisualStyleBackColor = true;
            // 
            // UI_GreenRadio
            // 
            this.UI_GreenRadio.AutoSize = true;
            this.UI_GreenRadio.Location = new System.Drawing.Point(7, 44);
            this.UI_GreenRadio.Name = "UI_GreenRadio";
            this.UI_GreenRadio.Size = new System.Drawing.Size(54, 17);
            this.UI_GreenRadio.TabIndex = 1;
            this.UI_GreenRadio.TabStop = true;
            this.UI_GreenRadio.Text = "Green";
            this.UI_GreenRadio.UseVisualStyleBackColor = true;
            // 
            // UI_BlueRadio
            // 
            this.UI_BlueRadio.AutoSize = true;
            this.UI_BlueRadio.Location = new System.Drawing.Point(7, 68);
            this.UI_BlueRadio.Name = "UI_BlueRadio";
            this.UI_BlueRadio.Size = new System.Drawing.Size(46, 17);
            this.UI_BlueRadio.TabIndex = 2;
            this.UI_BlueRadio.TabStop = true;
            this.UI_BlueRadio.Text = "Blue";
            this.UI_BlueRadio.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UI_ColorColumn,
            this.UI_XcoorColumn,
            this.UI_YcoorColumn,
            this.UI_DiameterColumn});
            this.listView1.Location = new System.Drawing.Point(159, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(199, 282);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // UI_ColorColumn
            // 
            this.UI_ColorColumn.Text = "Color";
            // 
            // UI_XcoorColumn
            // 
            this.UI_XcoorColumn.Text = "x";
            this.UI_XcoorColumn.Width = 40;
            // 
            // UI_YcoorColumn
            // 
            this.UI_YcoorColumn.Text = "y";
            this.UI_YcoorColumn.Width = 34;
            // 
            // UI_DiameterColumn
            // 
            this.UI_DiameterColumn.Text = "Diameter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 306);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.UI_ColorBox);
            this.Controls.Add(this.UI_DiamLabel);
            this.Controls.Add(this.UI_DiameterUpDown);
            this.Controls.Add(this.UI_EraseListButton);
            this.Controls.Add(this.UI_EraseScreen);
            this.Controls.Add(this.UI_PlayBack);
            this.Controls.Add(this.UI_DrawButton);
            this.Controls.Add(this.UI_SaveFile);
            this.Controls.Add(this.UI_OpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UI_DiameterUpDown)).EndInit();
            this.UI_ColorBox.ResumeLayout(false);
            this.UI_ColorBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_OpenFile;
        private System.Windows.Forms.Button UI_SaveFile;
        private System.Windows.Forms.Button UI_DrawButton;
        private System.Windows.Forms.Button UI_PlayBack;
        private System.Windows.Forms.Button UI_EraseScreen;
        private System.Windows.Forms.Button UI_EraseListButton;
        private System.Windows.Forms.NumericUpDown UI_DiameterUpDown;
        private System.Windows.Forms.Label UI_DiamLabel;
        private System.Windows.Forms.GroupBox UI_ColorBox;
        private System.Windows.Forms.RadioButton UI_BlueRadio;
        private System.Windows.Forms.RadioButton UI_GreenRadio;
        private System.Windows.Forms.RadioButton UI_RedRadio;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader UI_ColorColumn;
        private System.Windows.Forms.ColumnHeader UI_XcoorColumn;
        private System.Windows.Forms.ColumnHeader UI_YcoorColumn;
        private System.Windows.Forms.ColumnHeader UI_DiameterColumn;
    }
}

