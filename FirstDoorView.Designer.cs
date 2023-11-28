namespace ChooseGame
{
    partial class FirstDoorView
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
            this.parushButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parushButton
            // 
            this.parushButton.BackgroundImage = global::ChooseGame.Properties.Resources._20171030105429;
            this.parushButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.parushButton.Location = new System.Drawing.Point(205, 146);
            this.parushButton.Name = "parushButton";
            this.parushButton.Size = new System.Drawing.Size(388, 192);
            this.parushButton.TabIndex = 1;
            this.parushButton.UseVisualStyleBackColor = true;
            this.parushButton.Click += new System.EventHandler(this.parushButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 70);
            this.label1.TabIndex = 4;
            this.label1.Text = "YOU ARE IN PARUSH\'S GAMING ROOM ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 70);
            this.label2.TabIndex = 5;
            this.label2.Text = "CLICK ON THE DESKTOP";
            // 
            // FirstDoorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChooseGame.Properties.Resources._1000_F_480603273_SSCjQbLbcd1qsfreRwMGWpuK61M90gA71;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parushButton);
            this.Name = "FirstDoorView";
            this.Text = "FirstDoorView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parushButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}