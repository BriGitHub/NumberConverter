///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project3/Project3
//	File Name:         ConversionForm.cs
//	Description:       ConversionForm Windows Form Application Code, the main form of the program
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brianna Martinson, martinson@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Friday, March 29, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    /// <summary>
    /// ConversionForm Windows Form Application Code
    /// Runs the main form of the program
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ConversionForm : Form
    {
        /// <summary>
        /// Default Constructor
        /// Initializes a new instance of the <see cref="ConversionForm"/> class.
        /// </summary>
        public ConversionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the ConversionForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ConversionForm_Load(object sender, EventArgs e)
        {
            this.Text = AssemblyProduct;
            intValBox.MaxLength = (int)resultChooser.Value;
        }

        /// <summary>
        /// Handles the Click event of the exit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the fromDecimal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void fromDecimal_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(decValueBox.Text))
                intValBox.Text = BaseConverter.FromDecimal(Int32.Parse(decValueBox.Text), (int)baseChooser.Value, intValBox.MaxLength);
        }

        /// <summary>
        /// Handles the Click event of the toDecimal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toDecimal_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(intValBox.Text))
                decValueBox.Text = BaseConverter.ToDecimal(intValBox.Text, (int)baseChooser.Value).ToString();
        }

        /// <summary>
        /// Handles the Click event of the helpToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.Show();
        }

        /// <summary>
        /// Handles the ValueChanged event of the resultChooser control.
        /// Sets the max length of the integer value box.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void resultChooser_ValueChanged(object sender, EventArgs e)
        {
            intValBox.MaxLength = (int)resultChooser.Value;
        }

        /// <summary>
        /// Handles the KeyPress event of the intValBox control.
        /// Makes sure the User's input is appropriate 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void intValBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] validUpper = new char[] { '\b', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};

            if (Array.IndexOf(validUpper, char.ToUpperInvariant(e.KeyChar)) > baseChooser.Value || Array.IndexOf(validUpper, char.ToUpperInvariant(e.KeyChar)) == -1)
                e.Handled = true;
        }

        /// <summary>
        /// Handles the ValueChanged event of the baseChooser control.
        /// Clears the text to prevent the text not working with the base it was changed to
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void baseChooser_ValueChanged(object sender, EventArgs e)
        {
            intValBox.Clear();
        }

        /// <summary>
        /// Handles the KeyPress event of the decValueBox control.
        /// Makes sure the User's input is appropriate
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void decValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] valid = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '\b'};

            if (Array.IndexOf(valid, e.KeyChar) == -1)
                e.Handled = true;
        }

        #region Assembly Attribute Accessors
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
