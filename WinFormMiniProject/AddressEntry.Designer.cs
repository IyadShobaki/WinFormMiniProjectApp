namespace WinFormMiniProject
{
   partial class AddressEntry
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
         this.cityText = new System.Windows.Forms.TextBox();
         this.streetAddressText = new System.Windows.Forms.TextBox();
         this.cityLabel = new System.Windows.Forms.Label();
         this.streetAddressLabel = new System.Windows.Forms.Label();
         this.stateLabel = new System.Windows.Forms.Label();
         this.zipCodeLabel = new System.Windows.Forms.Label();
         this.stateText = new System.Windows.Forms.TextBox();
         this.zipCodeText = new System.Windows.Forms.TextBox();
         this.headerLabel = new System.Windows.Forms.Label();
         this.saveAddressButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // cityText
         // 
         this.cityText.Location = new System.Drawing.Point(274, 141);
         this.cityText.Name = "cityText";
         this.cityText.Size = new System.Drawing.Size(360, 35);
         this.cityText.TabIndex = 2;
         // 
         // streetAddressText
         // 
         this.streetAddressText.Location = new System.Drawing.Point(274, 87);
         this.streetAddressText.Name = "streetAddressText";
         this.streetAddressText.Size = new System.Drawing.Size(360, 35);
         this.streetAddressText.TabIndex = 1;
         // 
         // cityLabel
         // 
         this.cityLabel.AutoSize = true;
         this.cityLabel.Location = new System.Drawing.Point(206, 147);
         this.cityLabel.Name = "cityLabel";
         this.cityLabel.Size = new System.Drawing.Size(53, 29);
         this.cityLabel.TabIndex = 0;
         this.cityLabel.Text = "City";
         // 
         // streetAddressLabel
         // 
         this.streetAddressLabel.AutoSize = true;
         this.streetAddressLabel.Location = new System.Drawing.Point(87, 87);
         this.streetAddressLabel.Name = "streetAddressLabel";
         this.streetAddressLabel.Size = new System.Drawing.Size(172, 29);
         this.streetAddressLabel.TabIndex = 0;
         this.streetAddressLabel.Text = "Street Address";
         // 
         // stateLabel
         // 
         this.stateLabel.AutoSize = true;
         this.stateLabel.Location = new System.Drawing.Point(191, 214);
         this.stateLabel.Name = "stateLabel";
         this.stateLabel.Size = new System.Drawing.Size(68, 29);
         this.stateLabel.TabIndex = 0;
         this.stateLabel.Text = "State";
         // 
         // zipCodeLabel
         // 
         this.zipCodeLabel.AutoSize = true;
         this.zipCodeLabel.Location = new System.Drawing.Point(147, 262);
         this.zipCodeLabel.Name = "zipCodeLabel";
         this.zipCodeLabel.Size = new System.Drawing.Size(112, 29);
         this.zipCodeLabel.TabIndex = 0;
         this.zipCodeLabel.Text = "Zip Code";
         // 
         // stateText
         // 
         this.stateText.Location = new System.Drawing.Point(274, 208);
         this.stateText.Name = "stateText";
         this.stateText.Size = new System.Drawing.Size(360, 35);
         this.stateText.TabIndex = 3;
         // 
         // zipCodeText
         // 
         this.zipCodeText.Location = new System.Drawing.Point(274, 262);
         this.zipCodeText.Name = "zipCodeText";
         this.zipCodeText.Size = new System.Drawing.Size(360, 35);
         this.zipCodeText.TabIndex = 4;
         // 
         // headerLabel
         // 
         this.headerLabel.AutoSize = true;
         this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.headerLabel.Location = new System.Drawing.Point(204, 23);
         this.headerLabel.Name = "headerLabel";
         this.headerLabel.Size = new System.Drawing.Size(249, 39);
         this.headerLabel.TabIndex = 7;
         this.headerLabel.Text = "Address Entry";
         // 
         // saveAddressButton
         // 
         this.saveAddressButton.Location = new System.Drawing.Point(274, 333);
         this.saveAddressButton.Name = "saveAddressButton";
         this.saveAddressButton.Size = new System.Drawing.Size(253, 68);
         this.saveAddressButton.TabIndex = 5;
         this.saveAddressButton.Text = "Save";
         this.saveAddressButton.UseVisualStyleBackColor = true;
         this.saveAddressButton.Click += new System.EventHandler(this.saveAddressButton_Click);
         // 
         // AddressEntry
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(737, 486);
         this.Controls.Add(this.saveAddressButton);
         this.Controls.Add(this.headerLabel);
         this.Controls.Add(this.zipCodeText);
         this.Controls.Add(this.stateText);
         this.Controls.Add(this.cityText);
         this.Controls.Add(this.zipCodeLabel);
         this.Controls.Add(this.streetAddressText);
         this.Controls.Add(this.stateLabel);
         this.Controls.Add(this.cityLabel);
         this.Controls.Add(this.streetAddressLabel);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
         this.Name = "AddressEntry";
         this.Text = "Address Entry Form by Iyad Shobaki";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox cityText;
      private System.Windows.Forms.TextBox streetAddressText;
      private System.Windows.Forms.Label cityLabel;
      private System.Windows.Forms.Label streetAddressLabel;
      private System.Windows.Forms.Label stateLabel;
      private System.Windows.Forms.Label zipCodeLabel;
      private System.Windows.Forms.TextBox stateText;
      private System.Windows.Forms.TextBox zipCodeText;
      private System.Windows.Forms.Label headerLabel;
      private System.Windows.Forms.Button saveAddressButton;
   }
}