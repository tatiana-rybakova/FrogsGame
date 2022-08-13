namespace FrogsWinFormsApp
{
    partial class RoolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoolsForm));
            this.roolsPictureBox = new System.Windows.Forms.PictureBox();
            this.roolsTitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roolsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // roolsPictureBox
            // 
            this.roolsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roolsPictureBox.Image = global::FrogsWinFormsApp.Properties.Resources.win;
            this.roolsPictureBox.Location = new System.Drawing.Point(276, 12);
            this.roolsPictureBox.Name = "roolsPictureBox";
            this.roolsPictureBox.Size = new System.Drawing.Size(202, 167);
            this.roolsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.roolsPictureBox.TabIndex = 0;
            this.roolsPictureBox.TabStop = false;
            // 
            // roolsTitleLabel
            // 
            this.roolsTitleLabel.AutoSize = true;
            this.roolsTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roolsTitleLabel.Location = new System.Drawing.Point(296, 200);
            this.roolsTitleLabel.Name = "roolsTitleLabel";
            this.roolsTitleLabel.Size = new System.Drawing.Size(153, 28);
            this.roolsTitleLabel.TabIndex = 1;
            this.roolsTitleLabel.Text = "Правила игры";
            this.roolsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 84);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roolsTitleLabel);
            this.Controls.Add(this.roolsPictureBox);
            this.Name = "RoolsForm";
            this.Text = "RoolsForm";
            ((System.ComponentModel.ISupportInitialize)(this.roolsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox roolsPictureBox;
        private Label roolsTitleLabel;
        private Label label2;
    }
}