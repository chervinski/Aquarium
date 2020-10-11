namespace Aquarium
{
	partial class Form2
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
            this.databaseLabel = new System.Windows.Forms.Label();
            this.aquariumLabel = new System.Windows.Forms.Label();
            this.databaseComboBox = new System.Windows.Forms.ComboBox();
            this.aquariumComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.addDatabaseButton = new System.Windows.Forms.Button();
            this.addAquariumButton = new System.Windows.Forms.Button();
            this.showAquariumButton = new System.Windows.Forms.Button();
            this.removeDatabaseButton = new System.Windows.Forms.Button();
            this.removeAquariumButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.databaseLabel.Location = new System.Drawing.Point(12, 9);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(71, 18);
            this.databaseLabel.TabIndex = 0;
            this.databaseLabel.Text = "Database";
            // 
            // aquariumLabel
            // 
            this.aquariumLabel.AutoSize = true;
            this.aquariumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aquariumLabel.Location = new System.Drawing.Point(265, 9);
            this.aquariumLabel.Name = "aquariumLabel";
            this.aquariumLabel.Size = new System.Drawing.Size(70, 18);
            this.aquariumLabel.TabIndex = 1;
            this.aquariumLabel.Text = "Aquarium";
            // 
            // databaseComboBox
            // 
            this.databaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseComboBox.FormattingEnabled = true;
            this.databaseComboBox.Location = new System.Drawing.Point(12, 30);
            this.databaseComboBox.Name = "databaseComboBox";
            this.databaseComboBox.Size = new System.Drawing.Size(141, 21);
            this.databaseComboBox.TabIndex = 2;
            this.databaseComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // aquariumComboBox
            // 
            this.aquariumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aquariumComboBox.FormattingEnabled = true;
            this.aquariumComboBox.Location = new System.Drawing.Point(266, 30);
            this.aquariumComboBox.Name = "aquariumComboBox";
            this.aquariumComboBox.Size = new System.Drawing.Size(141, 21);
            this.aquariumComboBox.TabIndex = 3;
            this.aquariumComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(9, 214);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(141, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // speedNumericUpDown
            // 
            this.speedNumericUpDown.Location = new System.Drawing.Point(12, 262);
            this.speedNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.speedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedNumericUpDown.Name = "speedNumericUpDown";
            this.speedNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.speedNumericUpDown.TabIndex = 5;
            this.speedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(9, 193);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(12, 243);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(77, 16);
            this.speedLabel.TabIndex = 7;
            this.speedLabel.Text = "Max Speed";
            // 
            // addDatabaseButton
            // 
            this.addDatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDatabaseButton.Location = new System.Drawing.Point(156, 203);
            this.addDatabaseButton.Name = "addDatabaseButton";
            this.addDatabaseButton.Size = new System.Drawing.Size(81, 41);
            this.addDatabaseButton.TabIndex = 8;
            this.addDatabaseButton.Text = "Add to the database";
            this.addDatabaseButton.UseVisualStyleBackColor = true;
            this.addDatabaseButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addAquariumButton
            // 
            this.addAquariumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAquariumButton.Location = new System.Drawing.Point(156, 250);
            this.addAquariumButton.Name = "addAquariumButton";
            this.addAquariumButton.Size = new System.Drawing.Size(81, 41);
            this.addAquariumButton.TabIndex = 9;
            this.addAquariumButton.Text = "Add to the aquarium";
            this.addAquariumButton.UseVisualStyleBackColor = true;
            this.addAquariumButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showAquariumButton
            // 
            this.showAquariumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAquariumButton.Location = new System.Drawing.Point(300, 214);
            this.showAquariumButton.Name = "showAquariumButton";
            this.showAquariumButton.Size = new System.Drawing.Size(107, 75);
            this.showAquariumButton.TabIndex = 10;
            this.showAquariumButton.Text = "Show the aquarium";
            this.showAquariumButton.UseVisualStyleBackColor = true;
            this.showAquariumButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // removeDatabaseButton
            // 
            this.removeDatabaseButton.Enabled = false;
            this.removeDatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeDatabaseButton.Location = new System.Drawing.Point(15, 57);
            this.removeDatabaseButton.Name = "removeDatabaseButton";
            this.removeDatabaseButton.Size = new System.Drawing.Size(65, 25);
            this.removeDatabaseButton.TabIndex = 11;
            this.removeDatabaseButton.Text = "Remove";
            this.removeDatabaseButton.UseVisualStyleBackColor = true;
            this.removeDatabaseButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeAquariumButton
            // 
            this.removeAquariumButton.Enabled = false;
            this.removeAquariumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeAquariumButton.Location = new System.Drawing.Point(268, 57);
            this.removeAquariumButton.Name = "removeAquariumButton";
            this.removeAquariumButton.Size = new System.Drawing.Size(65, 25);
            this.removeAquariumButton.TabIndex = 12;
            this.removeAquariumButton.Text = "Remove";
            this.removeAquariumButton.UseVisualStyleBackColor = true;
            this.removeAquariumButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 301);
            this.Controls.Add(this.removeAquariumButton);
            this.Controls.Add(this.removeDatabaseButton);
            this.Controls.Add(this.showAquariumButton);
            this.Controls.Add(this.addAquariumButton);
            this.Controls.Add(this.addDatabaseButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.speedNumericUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.aquariumComboBox);
            this.Controls.Add(this.databaseComboBox);
            this.Controls.Add(this.aquariumLabel);
            this.Controls.Add(this.databaseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Aquarium manager";
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label databaseLabel;
		private System.Windows.Forms.Label aquariumLabel;
		private System.Windows.Forms.ComboBox databaseComboBox;
		private System.Windows.Forms.ComboBox aquariumComboBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.NumericUpDown speedNumericUpDown;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label speedLabel;
		private System.Windows.Forms.Button addDatabaseButton;
		private System.Windows.Forms.Button addAquariumButton;
		private System.Windows.Forms.Button showAquariumButton;
		private System.Windows.Forms.Button removeDatabaseButton;
		private System.Windows.Forms.Button removeAquariumButton;
	}
}