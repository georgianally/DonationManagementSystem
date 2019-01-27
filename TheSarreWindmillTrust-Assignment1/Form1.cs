using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSarreWindmillTrust_Assignment1
{
    public partial class Form1 : Form
    {
        private List<Donor> mDonor = new List<Donor>();
        List<string> mRatings = new List<string> {"Bronze", "Silver", "Gold", "Diamond"};
        private Int32 currentDonor = 0;
        private Int32 UniqueIDIncrement;

        public Form1()
        {
            InitializeComponent();
            foreach (string r in mRatings)
            {
                uiDonorRatingComboBox.Items.Add(r);
            }
        }

        private void uiNewDonorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uiNewNameTextbox.Text) || string.IsNullOrWhiteSpace(uiFirstDonationAmountTextBox.Text))
            {
                MessageBox.Show("Please Enter Donor Name and Donation Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (uiAmountTextBox.Text.All(char.IsDigit))
            {
                string donorName = uiNewNameTextbox.Text;
                decimal amount = Convert.ToDecimal(uiFirstDonationAmountTextBox.Text);
                DateTime date = uiFirstDatePicker.Value;
                Int32 id = UniqueIDIncrement;
                mDonor.Add(new Donor(donorName, amount, date, id));
                uiNewIDTextBox.Text = mDonor[currentDonor].GetID().ToString();
                mDonor[currentDonor].RatingSystem();
                uiNewNameTextbox.Clear();
                currentDonor++;
                UniqueIDIncrement++;
            }
            else
            {
                MessageBox.Show("Only Enter Numeric Amount Into Donation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void uiDonateButton_Click(object sender, EventArgs e)
        {
            bool IdRecognised = mDonor.Any(don => don.GetID() == uiIDTextbox.Text);

            if (string.IsNullOrWhiteSpace(uiUniqueIDLabel.Text) || string.IsNullOrWhiteSpace(uiAmountTextBox.Text))
            {
                MessageBox.Show("Please Enter Unique ID and Donation Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IdRecognised == false)
            {
                MessageBox.Show("ID Not Recognised", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (uiAmountTextBox.Text.All(char.IsDigit))
            {
                string enteredID = uiIDTextbox.Text;

                foreach (Donor ID in mDonor.Where(o => o.GetID() == enteredID))
                {
                    ID.Deposit(Convert.ToDecimal(uiAmountTextBox.Text), uiDonateDateTimePicker.Value);
                    uiDonorNameTextBox.Text = ID.GetName();
                    ID.RatingSystem();
                    uiNumericTextBox.Text = ID.GetNumRating().ToString();
                    uiAdjectiveTextBox.Text = ID.GetAdjRating().ToString();
                    uiTotalAmountTextbox.Text = ID.GetTotalAmount().ToString();
                    uiLastAmountTextbox.Text = ID.GetLastAmount().ToString();
                    uiFirstDateTextbox.Text = ID.GetFirstDate().ToString();
                    uiLastDateTextbox.Text = ID.GetLastDate().ToString();
                }
            }
            else
            {
                MessageBox.Show("Only Enter Numeric Amount Into Donation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void uiDonorRatingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiDonorRatingTextBox.Clear();
            foreach (Donor d in mDonor)
            {
                if (d.GetAdjRating() == uiDonorRatingComboBox.Text)
                {
                    uiDonorRatingTextBox.Text += string.Format("{0, -20}{1, -10}", d.GetName(), d.GetID()) + Environment.NewLine;
                }
            }
        }
    }
}

