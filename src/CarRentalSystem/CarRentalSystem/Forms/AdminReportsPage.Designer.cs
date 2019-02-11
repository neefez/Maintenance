namespace CarRentalSystem.Forms
{
   partial class AdminReportsPage
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReportsPage));
         this.reportsPanel = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.viewLabel = new System.Windows.Forms.Label();
         this.fixedButton = new System.Windows.Forms.Button();
         this.denyButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.reportList = new System.Windows.Forms.ListBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.reportDetails = new System.Windows.Forms.RichTextBox();
         this.reportsPanel.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // reportsPanel
         // 
         this.reportsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.reportsPanel.Controls.Add(this.label2);
         this.reportsPanel.Controls.Add(this.viewLabel);
         this.reportsPanel.Controls.Add(this.fixedButton);
         this.reportsPanel.Controls.Add(this.denyButton);
         this.reportsPanel.Controls.Add(this.label1);
         this.reportsPanel.Controls.Add(this.reportList);
         this.reportsPanel.Controls.Add(this.panel1);
         this.reportsPanel.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.reportsPanel.ForeColor = System.Drawing.Color.DarkSlateGray;
         this.reportsPanel.Location = new System.Drawing.Point(387, 117);
         this.reportsPanel.Name = "reportsPanel";
         this.reportsPanel.Size = new System.Drawing.Size(894, 697);
         this.reportsPanel.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(64, 118);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(65, 35);
         this.label2.TabIndex = 7;
         this.label2.Text = "List:";
         // 
         // viewLabel
         // 
         this.viewLabel.AutoSize = true;
         this.viewLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.viewLabel.ForeColor = System.Drawing.Color.SteelBlue;
         this.viewLabel.Location = new System.Drawing.Point(45, 46);
         this.viewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.viewLabel.Name = "viewLabel";
         this.viewLabel.Size = new System.Drawing.Size(217, 44);
         this.viewLabel.TabIndex = 6;
         this.viewLabel.Text = "View Reports";
         // 
         // fixedButton
         // 
         this.fixedButton.Location = new System.Drawing.Point(392, 555);
         this.fixedButton.Name = "fixedButton";
         this.fixedButton.Size = new System.Drawing.Size(190, 72);
         this.fixedButton.TabIndex = 5;
         this.fixedButton.Text = "Mark as Fixed";
         this.fixedButton.UseVisualStyleBackColor = true;
         this.fixedButton.Click += new System.EventHandler(this.fixedButton_Click);
         // 
         // denyButton
         // 
         this.denyButton.Location = new System.Drawing.Point(642, 555);
         this.denyButton.Name = "denyButton";
         this.denyButton.Size = new System.Drawing.Size(190, 72);
         this.denyButton.TabIndex = 4;
         this.denyButton.Text = "Deny";
         this.denyButton.UseVisualStyleBackColor = true;
         this.denyButton.Click += new System.EventHandler(this.denyButton_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(386, 118);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(150, 35);
         this.label1.TabIndex = 2;
         this.label1.Text = "Comments:";
         // 
         // reportList
         // 
         this.reportList.FormattingEnabled = true;
         this.reportList.ItemHeight = 35;
         this.reportList.Location = new System.Drawing.Point(70, 158);
         this.reportList.Name = "reportList";
         this.reportList.Size = new System.Drawing.Size(272, 459);
         this.reportList.TabIndex = 0;
         this.reportList.SelectedIndexChanged += new System.EventHandler(this.reportList_SelectedIndexChanged);
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.White;
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.reportDetails);
         this.panel1.Location = new System.Drawing.Point(392, 158);
         this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(440, 333);
         this.panel1.TabIndex = 8;
         // 
         // reportDetails
         // 
         this.reportDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.reportDetails.Dock = System.Windows.Forms.DockStyle.Fill;
         this.reportDetails.Location = new System.Drawing.Point(0, 0);
         this.reportDetails.Name = "reportDetails";
         this.reportDetails.Size = new System.Drawing.Size(438, 331);
         this.reportDetails.TabIndex = 1;
         this.reportDetails.Text = "";
         // 
         // AdminReportsPage
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Gainsboro;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.ClientSize = new System.Drawing.Size(1551, 863);
         this.Controls.Add(this.reportsPanel);
         this.Name = "AdminReportsPage";
         this.Text = "AdminReportsPage";
         this.reportsPanel.ResumeLayout(false);
         this.reportsPanel.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel reportsPanel;
      private System.Windows.Forms.Button fixedButton;
      private System.Windows.Forms.Button denyButton;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.RichTextBox reportDetails;
      private System.Windows.Forms.ListBox reportList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Panel panel1;
    }
}