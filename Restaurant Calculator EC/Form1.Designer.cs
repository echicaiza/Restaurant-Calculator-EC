namespace Restaurant_Calculator_EC
{
    partial class restaurantCalculator
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
            this.foodLabel = new System.Windows.Forms.Label();
            this.foodtextBox = new System.Windows.Forms.TextBox();
            this.tipLabel = new System.Windows.Forms.Label();
            this.tipcalcLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxcalcLabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.totalCalcLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(176, 38);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(138, 25);
            this.foodLabel.TabIndex = 0;
            this.foodLabel.Text = "Food Charge: ";
            // 
            // foodtextBox
            // 
            this.foodtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodtextBox.Location = new System.Drawing.Point(354, 35);
            this.foodtextBox.Name = "foodtextBox";
            this.foodtextBox.Size = new System.Drawing.Size(120, 30);
            this.foodtextBox.TabIndex = 1;
            this.foodtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipLabel.Location = new System.Drawing.Point(209, 103);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(105, 25);
            this.tipLabel.TabIndex = 2;
            this.tipLabel.Text = "Tip (20%):";
            // 
            // tipcalcLabel
            // 
            this.tipcalcLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tipcalcLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipcalcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipcalcLabel.Location = new System.Drawing.Point(354, 93);
            this.tipcalcLabel.Name = "tipcalcLabel";
            this.tipcalcLabel.Size = new System.Drawing.Size(122, 35);
            this.tipcalcLabel.TabIndex = 3;
            this.tipcalcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(176, 161);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(138, 25);
            this.taxLabel.TabIndex = 4;
            this.taxLabel.Text = "Tax (6.625%):";
            // 
            // taxcalcLabel
            // 
            this.taxcalcLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.taxcalcLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxcalcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxcalcLabel.Location = new System.Drawing.Point(354, 161);
            this.taxcalcLabel.Name = "taxcalcLabel";
            this.taxcalcLabel.Size = new System.Drawing.Size(122, 35);
            this.taxcalcLabel.TabIndex = 5;
            this.taxcalcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(247, 230);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(67, 25);
            this.totallabel.TabIndex = 6;
            this.totallabel.Text = "Total: ";
            // 
            // totalCalcLabel
            // 
            this.totalCalcLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totalCalcLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCalcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCalcLabel.Location = new System.Drawing.Point(353, 226);
            this.totalCalcLabel.Name = "totalCalcLabel";
            this.totalCalcLabel.Size = new System.Drawing.Size(123, 33);
            this.totalCalcLabel.TabIndex = 7;
            this.totalCalcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(207, 310);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(148, 42);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(412, 310);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 42);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restaurantCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalCalcLabel);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.taxcalcLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.tipcalcLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.foodtextBox);
            this.Controls.Add(this.foodLabel);
            this.Name = "restaurantCalculator";
            this.Text = "Restaurant Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.TextBox foodtextBox;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label tipcalcLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxcalcLabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label totalCalcLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

