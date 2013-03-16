//-----------------------------------------------------------------------
// <copyright file="SequentialGuidDemoForm.cs" company="Jeremy H. Todd">
//     Copyright © Jeremy H. Todd 2011
// </copyright>
//-----------------------------------------------------------------------
namespace SequentialGuid.Demo
{
  using System;
  using System.Text;
  using System.Windows.Forms;

  /// <summary>
  /// The demonstration form for sequential GUIDs.
  /// </summary>
  public partial class SequentialGuidDemoForm : Form
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="SequentialGuidDemoForm" /> class.
    /// </summary>
    public SequentialGuidDemoForm()
    {
      this.InitializeComponent();

      // Load the <see cref="SequentialGuidType" /> enumeration values into the combo box
      foreach (var value in Enum.GetValues(typeof(SequentialGuidType)))
      {
        this.methodComboBox.Items.Add(value);
      }

      this.methodComboBox.SelectedIndex = 0;
    }

    /// <summary>
    /// Updates the form when the user changes the value of the Method ComboBox.
    /// </summary>
    /// <param name="sender">The Method ComboBox.</param>
    /// <param name="e">Additional information related to the event.</param>
    private void MethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      string comments = string.Empty;

      switch ((SequentialGuidType)this.methodComboBox.SelectedItem)
      {
        case SequentialGuidType.SequentialAsBinary:
          comments = "GUIDs will be generated using the SequentialAsBinary method, which is appropriate " +
                     "if the values are going to be written to a binary field, such as a raw(16) column " +
                     "under Oracle, or a binary(16) column under MySQL.  These GUIDs are formatted by " +
                     "invoking Guid.ToByteArray() on the GUID value, then writing the results to a hex " +
                     "string.  This is most likely the way ORM frameworks would generate INSERT statements " +
                     "for writing to a binary field.  The sequential portion of the generated GUIDs will be " +
                     "highlighted in red.";
          break;

        case SequentialGuidType.SequentialAsString:
          comments = "GUIDs will be generated using the SequentialAsString method, which is appropriate " +
                     "if the values are going to be written to a string-based column (which would include " +
                     "char(36) columns under MySQL and other database, or a uuid column under PostgreSQL). " +
                     "These GUIDs are formatted by invoking Guid.ToString() on the GUID value. Why do " +
                     "string-based columns need a different format from binary columns?  Because a quirk " +
                     "of the way the .NET Framework handles GUIDs introduces endianness issues that need " +
                     "to be corrected when writing to a string.  The sequential portion of the generated " +
                     "GUIDs will be highlighted in red.";
          break;

        case SequentialGuidType.SequentialAtEnd:
          comments = "GUIDs will be generated using the SequentialAtEnd method, which is pretty much " +
                     "only appropriate for a Microsoft SQL Server uniqueidentifier column.  This special " +
                     "format is necessary because SQL Server uses an unusual ordering scheme for GUID " +
                     "values, basing the order on the last six bytes instead of starting from the beginning." +
                     "The sequential portion of the generated GUIDs will be highlighted in red.";
          break;
      }

      this.resultsTextBox.Clear();
      this.commentsTextBox.Text = comments;
    }

    /// <summary>
    /// Generates the GUIDs and displays them in the form.
    /// </summary>
    /// <param name="sender">The Generate button.</param>
    /// <param name="e">Additional information related to the event.</param>
    private void GenerateButton_Click(object sender, EventArgs e)
    {
      int count = 100;
      SequentialGuidType method = (SequentialGuidType)this.methodComboBox.SelectedItem;

      // Initialize the RTF text to enable color highlighting
      StringBuilder text = new StringBuilder();
      text.Append("{\\rtf1\\ansi\\deff0\n{\\colortbl;\\red0\\green0\\blue0;\\red128\\green0\\blue0;}\n");

      for (int i = 0; i < count; i++)
      {
        Guid guid = SequentialGuid.Create(method);
        string output = string.Empty;

        switch (method)
        {
          case SequentialGuidType.SequentialAsBinary:
            byte[] bytes = guid.ToByteArray();

            foreach (byte b in bytes)
            {
              output += string.Format("{0:x2}", b);
            }

            output = "\\cf2\n" + output.Substring(0, 12) + "\n\\cf1\n" + output.Substring(12) + "\n\\line\n";
            break;

          case SequentialGuidType.SequentialAsString:
            output = guid.ToString();
            output = "\\cf2\n" + output.Substring(0, 13) + "\n\\cf1\n" + output.Substring(13) + "\n\\line\n";
            break;

          case SequentialGuidType.SequentialAtEnd:
            output = guid.ToString();
            output = "\\cf1\n" + output.Substring(0, 24) + "\n\\cf2\n" + output.Substring(24) + "\n\\line\n";
            break;

          default:
            output = guid.ToString();
            break;
        }

        text.Append(output);
        System.Threading.Thread.Sleep(1);
      }

      this.resultsTextBox.Rtf = text.ToString();
    }
  }
}
