/**
 * RozWorld_Editor.Dialog.About -- About and Licences Dialog
 * 
 * This source-code is part of the RozWorld Editor project by rozza of Oddmatics:
 * <<http://www.oddmatics.co.uk>>
 * <<http://roz.world/#editor>>
 * <<http://github.com/rozniak/RozWorld-Editor>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace RozWorld_Editor.Dialog
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            LabelAboutSummary.Text = LabelAboutSummary.Text.Replace("$VERSION", Application.ProductVersion);
        }


        /// <summary>
        /// [Event] "OK" button clicked.
        /// </summary>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// [Event] http://creativecommons.org/licenses/by-nc/4.0/legalcode link clicked.
        /// </summary>
        private void LinkLicence_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://creativecommons.org/licenses/by-nc/4.0/legalcode");
        }


        /// <summary>
        /// [Event] http://www.oddmatics.uk link clicked.
        /// </summary>
        private void LinkOddmatics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.oddmatics.uk");
        }


        /// <summary>
        /// [Event] https://github.com/rozniak/RozWorld-Editor link clicked.
        /// </summary>
        private void LinkRepository_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/rozniak/RozWorld-Editor");
        }
    }
}
