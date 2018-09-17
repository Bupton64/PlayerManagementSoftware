namespace NewTeamForm {
    partial class NewTeamForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.newTeamNameLabel = new System.Windows.Forms.Label();
            this.newTeamGroundLabel = new System.Windows.Forms.Label();
            this.newTeamCoachLabel = new System.Windows.Forms.Label();
            this.newTeamYearLabel = new System.Windows.Forms.Label();
            this.newTeamRegionLabel = new System.Windows.Forms.Label();
            this.newTeamNameInput = new System.Windows.Forms.TextBox();
            this.newTeamGroundInput = new System.Windows.Forms.TextBox();
            this.newTeamCoachInput = new System.Windows.Forms.TextBox();
            this.newTeamYearInput = new System.Windows.Forms.TextBox();
            this.newTeamRegionInput = new System.Windows.Forms.TextBox();
            this.addNewTeamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Team ";
            // 
            // newTeamNameLabel
            // 
            this.newTeamNameLabel.AutoSize = true;
            this.newTeamNameLabel.Location = new System.Drawing.Point(86, 139);
            this.newTeamNameLabel.Name = "newTeamNameLabel";
            this.newTeamNameLabel.Size = new System.Drawing.Size(49, 17);
            this.newTeamNameLabel.TabIndex = 1;
            this.newTeamNameLabel.Text = "Name:";
            // 
            // newTeamGroundLabel
            // 
            this.newTeamGroundLabel.AutoSize = true;
            this.newTeamGroundLabel.Location = new System.Drawing.Point(86, 186);
            this.newTeamGroundLabel.Name = "newTeamGroundLabel";
            this.newTeamGroundLabel.Size = new System.Drawing.Size(101, 17);
            this.newTeamGroundLabel.TabIndex = 2;
            this.newTeamGroundLabel.Text = "Home Ground:";
            // 
            // newTeamCoachLabel
            // 
            this.newTeamCoachLabel.AutoSize = true;
            this.newTeamCoachLabel.Location = new System.Drawing.Point(86, 232);
            this.newTeamCoachLabel.Name = "newTeamCoachLabel";
            this.newTeamCoachLabel.Size = new System.Drawing.Size(103, 17);
            this.newTeamCoachLabel.TabIndex = 3;
            this.newTeamCoachLabel.Text = "Coach\'s Name:";
            // 
            // newTeamYearLabel
            // 
            this.newTeamYearLabel.AutoSize = true;
            this.newTeamYearLabel.Location = new System.Drawing.Point(86, 278);
            this.newTeamYearLabel.Name = "newTeamYearLabel";
            this.newTeamYearLabel.Size = new System.Drawing.Size(102, 17);
            this.newTeamYearLabel.TabIndex = 4;
            this.newTeamYearLabel.Text = "Year Founded:";
            // 
            // newTeamRegionLabel
            // 
            this.newTeamRegionLabel.AutoSize = true;
            this.newTeamRegionLabel.Location = new System.Drawing.Point(86, 323);
            this.newTeamRegionLabel.Name = "newTeamRegionLabel";
            this.newTeamRegionLabel.Size = new System.Drawing.Size(57, 17);
            this.newTeamRegionLabel.TabIndex = 5;
            this.newTeamRegionLabel.Text = "Region:";
            // 
            // newTeamNameInput
            // 
            this.newTeamNameInput.Location = new System.Drawing.Point(272, 138);
            this.newTeamNameInput.Name = "newTeamNameInput";
            this.newTeamNameInput.Size = new System.Drawing.Size(170, 22);
            this.newTeamNameInput.TabIndex = 6;
            // 
            // newTeamGroundInput
            // 
            this.newTeamGroundInput.Location = new System.Drawing.Point(272, 183);
            this.newTeamGroundInput.Name = "newTeamGroundInput";
            this.newTeamGroundInput.Size = new System.Drawing.Size(170, 22);
            this.newTeamGroundInput.TabIndex = 7;
            // 
            // newTeamCoachInput
            // 
            this.newTeamCoachInput.Location = new System.Drawing.Point(272, 227);
            this.newTeamCoachInput.Name = "newTeamCoachInput";
            this.newTeamCoachInput.Size = new System.Drawing.Size(170, 22);
            this.newTeamCoachInput.TabIndex = 8;
            // 
            // newTeamYearInput
            // 
            this.newTeamYearInput.Location = new System.Drawing.Point(272, 273);
            this.newTeamYearInput.Name = "newTeamYearInput";
            this.newTeamYearInput.Size = new System.Drawing.Size(170, 22);
            this.newTeamYearInput.TabIndex = 9;
            // 
            // newTeamRegionInput
            // 
            this.newTeamRegionInput.Location = new System.Drawing.Point(272, 318);
            this.newTeamRegionInput.Name = "newTeamRegionInput";
            this.newTeamRegionInput.Size = new System.Drawing.Size(170, 22);
            this.newTeamRegionInput.TabIndex = 10;
            // 
            // addNewTeamButton
            // 
            this.addNewTeamButton.Location = new System.Drawing.Point(194, 397);
            this.addNewTeamButton.Name = "addNewTeamButton";
            this.addNewTeamButton.Size = new System.Drawing.Size(75, 23);
            this.addNewTeamButton.TabIndex = 12;
            this.addNewTeamButton.Text = "Add...";
            this.addNewTeamButton.UseVisualStyleBackColor = true;
            this.addNewTeamButton.Click += new System.EventHandler(this.addNewTeamButton_Click);
            // 
            // NewTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 565);
            this.Controls.Add(this.addNewTeamButton);
            this.Controls.Add(this.newTeamRegionInput);
            this.Controls.Add(this.newTeamYearInput);
            this.Controls.Add(this.newTeamCoachInput);
            this.Controls.Add(this.newTeamGroundInput);
            this.Controls.Add(this.newTeamNameInput);
            this.Controls.Add(this.newTeamRegionLabel);
            this.Controls.Add(this.newTeamYearLabel);
            this.Controls.Add(this.newTeamCoachLabel);
            this.Controls.Add(this.newTeamGroundLabel);
            this.Controls.Add(this.newTeamNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "NewTeamForm";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label newTeamNameLabel;
        private System.Windows.Forms.Label newTeamGroundLabel;
        private System.Windows.Forms.Label newTeamCoachLabel;
        private System.Windows.Forms.Label newTeamYearLabel;
        private System.Windows.Forms.Label newTeamRegionLabel;
        private System.Windows.Forms.TextBox newTeamNameInput;
        private System.Windows.Forms.TextBox newTeamGroundInput;
        private System.Windows.Forms.TextBox newTeamCoachInput;
        private System.Windows.Forms.TextBox newTeamYearInput;
        private System.Windows.Forms.TextBox newTeamRegionInput;
        private System.Windows.Forms.Button addNewTeamButton;
    }
}

