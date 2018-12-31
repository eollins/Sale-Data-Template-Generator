namespace Template_Generator
{
    partial class MainForm
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
            this.selectCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectItem = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.ListView();
            this.Log = new System.Windows.Forms.TextBox();
            this.Sport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Set = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.High = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Low = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Begin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectCard
            // 
            this.selectCard.Location = new System.Drawing.Point(13, 13);
            this.selectCard.Name = "selectCard";
            this.selectCard.Size = new System.Drawing.Size(265, 65);
            this.selectCard.TabIndex = 0;
            this.selectCard.Text = "Select Card File";
            this.selectCard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not imported";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Not imported";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectItem
            // 
            this.selectItem.Location = new System.Drawing.Point(13, 152);
            this.selectItem.Name = "selectItem";
            this.selectItem.Size = new System.Drawing.Size(265, 65);
            this.selectItem.TabIndex = 2;
            this.selectItem.Text = "Select Item File";
            this.selectItem.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sport,
            this.Year,
            this.Set,
            this.Number,
            this.Player,
            this.Grade,
            this.Sales,
            this.High,
            this.Avg,
            this.Low});
            this.Table.Location = new System.Drawing.Point(301, 13);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(1141, 696);
            this.Table.TabIndex = 4;
            this.Table.UseCompatibleStateImageBehavior = false;
            this.Table.View = System.Windows.Forms.View.Details;
            // 
            // Log
            // 
            this.Log.Enabled = false;
            this.Log.Location = new System.Drawing.Point(13, 324);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(265, 385);
            this.Log.TabIndex = 5;
            // 
            // Sport
            // 
            this.Sport.Text = "Sport";
            this.Sport.Width = 156;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 92;
            // 
            // Set
            // 
            this.Set.Text = "Set";
            this.Set.Width = 114;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 134;
            // 
            // Player
            // 
            this.Player.Text = "Player";
            this.Player.Width = 162;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            this.Grade.Width = 132;
            // 
            // Sales
            // 
            this.Sales.Text = "Sales";
            this.Sales.Width = 102;
            // 
            // High
            // 
            this.High.Text = "High";
            this.High.Width = 82;
            // 
            // Avg
            // 
            this.Avg.Text = "Avg";
            this.Avg.Width = 78;
            // 
            // Low
            // 
            this.Low.Text = "Low";
            this.Low.Width = 84;
            // 
            // Begin
            // 
            this.Begin.Enabled = false;
            this.Begin.Location = new System.Drawing.Point(13, 280);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(265, 38);
            this.Begin.TabIndex = 6;
            this.Begin.Text = "Begin";
            this.Begin.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 721);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectItem;
        private System.Windows.Forms.ListView Table;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.ColumnHeader Sport;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Set;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.ColumnHeader Sales;
        private System.Windows.Forms.ColumnHeader High;
        private System.Windows.Forms.ColumnHeader Avg;
        private System.Windows.Forms.ColumnHeader Low;
        private System.Windows.Forms.Button Begin;
    }
}

