//-----------------------------------------------------------------------
// <copyright file="SequentialGuidDemoForm.Designer.cs" company="Jeremy H. Todd">
//     Copyright © Jeremy H. Todd 2011
// </copyright>
//-----------------------------------------------------------------------
namespace SequentialGuid.Demo 
{
  /// <summary>
  /// The demonstration form for sequential GUIDs.
  /// </summary>
  public partial class SequentialGuidDemoForm 
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>The TextBox that contains the results of the GUID generation.</summary>
    private System.Windows.Forms.RichTextBox resultsTextBox;

    /// <summary>The button that begins GUID generation.</summary>
    private System.Windows.Forms.Button generateButton;
    
    /// <summary>The ComboBox specifying the GUID generation method.</summary>
    private System.Windows.Forms.ComboBox methodComboBox;
    
    /// <summary>The TextBox that contains the comments.</summary>
    private System.Windows.Forms.TextBox commentsTextBox;
    
    /// <summary>The label for the method ComboBox.</summary>
    private System.Windows.Forms.Label methodLabel;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) 
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
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
      this.resultsTextBox = new System.Windows.Forms.RichTextBox();
      this.generateButton = new System.Windows.Forms.Button();
      this.methodComboBox = new System.Windows.Forms.ComboBox();
      this.commentsTextBox = new System.Windows.Forms.TextBox();
      this.methodLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // resultsTextBox
      // 
      this.resultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultsTextBox.BackColor = System.Drawing.Color.White;
      this.resultsTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resultsTextBox.ForeColor = System.Drawing.Color.Black;
      this.resultsTextBox.Location = new System.Drawing.Point(152, 12);
      this.resultsTextBox.Name = "resultsTextBox";
      this.resultsTextBox.ReadOnly = true;
      this.resultsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
      this.resultsTextBox.Size = new System.Drawing.Size(546, 297);
      this.resultsTextBox.TabIndex = 3;
      this.resultsTextBox.Text = string.Empty;
      // 
      // generateButton
      // 
      this.generateButton.Location = new System.Drawing.Point(15, 72);
      this.generateButton.Name = "generateButton";
      this.generateButton.Size = new System.Drawing.Size(121, 23);
      this.generateButton.TabIndex = 2;
      this.generateButton.Text = "Generate";
      this.generateButton.UseVisualStyleBackColor = true;
      this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
      // 
      // methodComboBox
      // 
      this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.methodComboBox.FormattingEnabled = true;
      this.methodComboBox.Location = new System.Drawing.Point(15, 32);
      this.methodComboBox.Name = "methodComboBox";
      this.methodComboBox.Size = new System.Drawing.Size(121, 21);
      this.methodComboBox.TabIndex = 1;
      this.methodComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodComboBox_SelectedIndexChanged);
      // 
      // commentsTextBox
      // 
      this.commentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.commentsTextBox.BackColor = System.Drawing.Color.White;
      this.commentsTextBox.ForeColor = System.Drawing.Color.Black;
      this.commentsTextBox.Location = new System.Drawing.Point(152, 315);
      this.commentsTextBox.Multiline = true;
      this.commentsTextBox.Name = "commentsTextBox";
      this.commentsTextBox.ReadOnly = true;
      this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.commentsTextBox.Size = new System.Drawing.Size(546, 120);
      this.commentsTextBox.TabIndex = 4;
      // 
      // methodLabel
      // 
      this.methodLabel.AutoSize = true;
      this.methodLabel.Location = new System.Drawing.Point(12, 16);
      this.methodLabel.Name = "methodLabel";
      this.methodLabel.Size = new System.Drawing.Size(79, 13);
      this.methodLabel.TabIndex = 0;
      this.methodLabel.Text = "Select Method:";
      // 
      // SequentialGuidDemoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(710, 447);
      this.Controls.Add(this.methodLabel);
      this.Controls.Add(this.commentsTextBox);
      this.Controls.Add(this.methodComboBox);
      this.Controls.Add(this.generateButton);
      this.Controls.Add(this.resultsTextBox);
      this.Name = "SequentialGuidDemoForm";
      this.Text = "SequentialGuid Demonstration Form";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion
  }
}