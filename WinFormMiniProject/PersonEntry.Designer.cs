namespace WinFormMiniProject
{
   partial class PersonEntry
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
         this.firstNameLabel = new System.Windows.Forms.Label();
         this.lastNameLabel = new System.Windows.Forms.Label();
         this.firstNameText = new System.Windows.Forms.TextBox();
         this.lastNameText = new System.Windows.Forms.TextBox();
         this.isActiveChBox = new System.Windows.Forms.CheckBox();
         this.isActiveLabel = new System.Windows.Forms.Label();
         this.addressListBox = new System.Windows.Forms.ListBox();
         this.addressesLabel = new System.Windows.Forms.Label();
         this.addNewAddressButton = new System.Windows.Forms.Button();
         this.saveRecordButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // firstNameLabel
         // 
         this.firstNameLabel.AutoSize = true;
         this.firstNameLabel.Location = new System.Drawing.Point(77, 60);
         this.firstNameLabel.Name = "firstNameLabel";
         this.firstNameLabel.Size = new System.Drawing.Size(131, 29);
         this.firstNameLabel.TabIndex = 0;
         this.firstNameLabel.Text = "First Name";
         // 
         // lastNameLabel
         // 
         this.lastNameLabel.AutoSize = true;
         this.lastNameLabel.Location = new System.Drawing.Point(77, 114);
         this.lastNameLabel.Name = "lastNameLabel";
         this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
         this.lastNameLabel.TabIndex = 0;
         this.lastNameLabel.Text = "Last Name";
         // 
         // firstNameText
         // 
         this.firstNameText.Location = new System.Drawing.Point(242, 54);
         this.firstNameText.Name = "firstNameText";
         this.firstNameText.Size = new System.Drawing.Size(360, 35);
         this.firstNameText.TabIndex = 1;
         // 
         // lastNameText
         // 
         this.lastNameText.Location = new System.Drawing.Point(242, 108);
         this.lastNameText.Name = "lastNameText";
         this.lastNameText.Size = new System.Drawing.Size(360, 35);
         this.lastNameText.TabIndex = 2;
         // 
         // isActiveChBox
         // 
         this.isActiveChBox.AutoSize = true;
         this.isActiveChBox.Location = new System.Drawing.Point(242, 185);
         this.isActiveChBox.Name = "isActiveChBox";
         this.isActiveChBox.Size = new System.Drawing.Size(15, 14);
         this.isActiveChBox.TabIndex = 3;
         this.isActiveChBox.UseVisualStyleBackColor = true;
         // 
         // isActiveLabel
         // 
         this.isActiveLabel.AutoSize = true;
         this.isActiveLabel.Location = new System.Drawing.Point(77, 177);
         this.isActiveLabel.Name = "isActiveLabel";
         this.isActiveLabel.Size = new System.Drawing.Size(77, 29);
         this.isActiveLabel.TabIndex = 0;
         this.isActiveLabel.Text = "Active";
         // 
         // addressListBox
         // 
         this.addressListBox.FormattingEnabled = true;
         this.addressListBox.ItemHeight = 29;
         this.addressListBox.Location = new System.Drawing.Point(82, 298);
         this.addressListBox.Name = "addressListBox";
         this.addressListBox.Size = new System.Drawing.Size(520, 236);
         this.addressListBox.TabIndex = 0;
         this.addressListBox.TabStop = false;
         // 
         // addressesLabel
         // 
         this.addressesLabel.AutoSize = true;
         this.addressesLabel.Location = new System.Drawing.Point(77, 266);
         this.addressesLabel.Name = "addressesLabel";
         this.addressesLabel.Size = new System.Drawing.Size(128, 29);
         this.addressesLabel.TabIndex = 0;
         this.addressesLabel.Text = "Addresses";
         // 
         // addNewAddressButton
         // 
         this.addNewAddressButton.Location = new System.Drawing.Point(524, 250);
         this.addNewAddressButton.Name = "addNewAddressButton";
         this.addNewAddressButton.Size = new System.Drawing.Size(78, 42);
         this.addNewAddressButton.TabIndex = 4;
         this.addNewAddressButton.Text = "Add";
         this.addNewAddressButton.UseVisualStyleBackColor = true;
         this.addNewAddressButton.Click += new System.EventHandler(this.addNewAddressButton_Click);
         // 
         // saveRecordButton
         // 
         this.saveRecordButton.Location = new System.Drawing.Point(242, 540);
         this.saveRecordButton.Name = "saveRecordButton";
         this.saveRecordButton.Size = new System.Drawing.Size(177, 42);
         this.saveRecordButton.TabIndex = 5;
         this.saveRecordButton.Text = "Save";
         this.saveRecordButton.UseVisualStyleBackColor = true;
         this.saveRecordButton.Click += new System.EventHandler(this.saveRecordButton_Click);
         // 
         // PersonEntry
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(732, 605);
         this.Controls.Add(this.saveRecordButton);
         this.Controls.Add(this.addNewAddressButton);
         this.Controls.Add(this.addressListBox);
         this.Controls.Add(this.isActiveChBox);
         this.Controls.Add(this.lastNameText);
         this.Controls.Add(this.firstNameText);
         this.Controls.Add(this.isActiveLabel);
         this.Controls.Add(this.addressesLabel);
         this.Controls.Add(this.lastNameLabel);
         this.Controls.Add(this.firstNameLabel);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(7);
         this.Name = "PersonEntry";
         this.Text = "Person Entry Form By Iyad Shobaki";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label firstNameLabel;
      private System.Windows.Forms.Label lastNameLabel;
      private System.Windows.Forms.TextBox firstNameText;
      private System.Windows.Forms.TextBox lastNameText;
      private System.Windows.Forms.CheckBox isActiveChBox;
      private System.Windows.Forms.Label isActiveLabel;
      private System.Windows.Forms.ListBox addressListBox;
      private System.Windows.Forms.Label addressesLabel;
      private System.Windows.Forms.Button addNewAddressButton;
      private System.Windows.Forms.Button saveRecordButton;
   }
}

