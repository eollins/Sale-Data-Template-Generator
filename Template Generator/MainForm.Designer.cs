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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not imported";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Not imported";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 629);
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
    }
}

