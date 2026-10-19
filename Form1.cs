using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Rooming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Clear previous booking details
            lstBookDetails.Items.Clear();

            bool isApproved = true; // Bool flag to track validation

            try
            {
                // 1. Validate Guest Name
                string guestName = txtName.Text.Trim();
                if (string.IsNullOrEmpty(guestName))
                {
                    MessageBox.Show("Fadlan geli magaca martida (Guest Name cannot be empty).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

                // 2. Validate and Parse Guest Age (18 to 90)
                int age = Convert.ToInt32(txtAge.Text);
                if (age < 18 || age > 90)
                {
                    MessageBox.Show("Da'da martidu waa inay u dhexaysaa 18 iyo 90.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

                // 3. Validate and Parse Number of Nights (1 to 30)
                int nights = Convert.ToInt32(txtNights.Text);
                if (nights < 1 || nights > 30)
                {
                    MessageBox.Show("Tadaadku habeenada waa inuu u dhexeeyaa 1 iyo 30.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

                // 4. Validate and Parse Number of Guests (1 to 6)
                int guests = Convert.ToInt32(txtnumber.Text);
                if (guests < 1 || guests > 6)
                {
                    MessageBox.Show("Tadaadku martidu waa inuu u dhexeeyaa 1 iyo 6.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

                // 5. Room Type Selection and Capacity Validation
                string roomType = "";
                double roomRate = 0;

                if (rdostandred.Checked)
                {
                    roomType = "Standard";
                    if (guests > 2)
                    {
                        MessageBox.Show("Qolka Standard wuxuu qaadi karaa ugu badnaan 2 qof.", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isApproved = false;
                        return;
                    }
                }
                else if (rdonormal.Checked)
                {
                    roomType = "Normal";
                    if (guests > 4)
                    {
                        MessageBox.Show("Qolka Normal wuxuu qaadi karaa ugu badnaan 4 qof.", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isApproved = false;
                        return;
                    }
                }
                else if (rdoHigh.Checked)
                {
                    roomType = "Hight";
                    if (guests > 6)
                    {
                        MessageBox.Show("Qolka Hight wuxuu qaadi karaa ugu badnaan 6 qof.", "Capacity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isApproved = false;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Fadlan dooro nooca qolka (Room Type).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isApproved = false;
                    return;
                }

                // If all validations pass
                if (isApproved)
                {
                    // Room Rate Determination using Switch Statement
                    switch (roomType)
                    {
                        case "Standard":
                            roomRate = 50; // $50/night
                            break;
                        case "Normal":
                            roomRate = 80; // $80/night
                            break;
                        case "Hight":
                            roomRate = 130; // $130/night
                            break;
                    }

                    // Base Cost Calculation
                    double baseCost = roomRate * nights;

                    // Night Discount Logic
                    double nightDiscountRate = 0;
                    if (nights >= 10)
                    {
                        nightDiscountRate = 0.12; // 12% discount for 10+ nights
                    }
                    else if (nights >= 5)
                    {
                        nightDiscountRate = 0.05; // 5% discount for 5-9 nights
                    }

                    double nightDiscountAmount = baseCost * nightDiscountRate;
                    double costAfterNightDiscount = baseCost - nightDiscountAmount;

                    // Breakfast Cost ($10 per guest per night)
                    double breakfastCost = 0;
                    if (chkBreakfast.Checked)
                    {
                        breakfastCost = 10 * guests * nights;
                    }

                    // Service Surcharge for > 4 guests (5% surcharge)
                    double surcharge = 0;
                    if (guests > 4)
                    {
                        surcharge = costAfterNightDiscount * 0.05;
                    }

                    // Subtotal before Senior Discount
                    double subtotal = costAfterNightDiscount + breakfastCost + surcharge;

                    // Senior Discount (Aged 60 or above receive 5% discount)
                    double seniorDiscount = 0;
                    if (age >= 60)
                    {
                        seniorDiscount = subtotal * 0.05;
                    }

                    // Total Calculation
                    double totalCost = subtotal - seniorDiscount;

                    // Display Results
                    lstBookDetails.Items.Add("=== BOOKING DETAILS ===");
                    lstBookDetails.Items.Add($"Guest Name: {guestName}");
                    lstBookDetails.Items.Add($"Age: {age}");
                    lstBookDetails.Items.Add($"Nights: {nights}");
                    lstBookDetails.Items.Add($"Guests: {guests}");
                    lstBookDetails.Items.Add($"Room Type: {roomType} (${roomRate}/night)");
                    lstBookDetails.Items.Add("-------------------------------------");
                    lstBookDetails.Items.Add($"Base Room Cost: ${baseCost:F2}");
                    if (nightDiscountAmount > 0)
                        lstBookDetails.Items.Add($"Night Discount ({nightDiscountRate * 100}%): -${nightDiscountAmount:F2}");
                    if (breakfastCost > 0)
                        lstBookDetails.Items.Add($"Breakfast Option: +${breakfastCost:F2}");
                    if (surcharge > 0)
                        lstBookDetails.Items.Add($"Group Surcharge (5%): +${surcharge:F2}");
                    if (seniorDiscount > 0)
                        lstBookDetails.Items.Add($"Senior Discount (5%): -${seniorDiscount:F2}");
                    lstBookDetails.Items.Add("-------------------------------------");
                    lstBookDetails.Items.Add($"TOTAL PRICE: ${totalCost:F2}");
                }
            }
            catch (FormatException)
            {
                // Isbadalka xogta marka xarfo lagu qoro sanduuqa nambarka loogu talagalay (Format Exception)
                MessageBox.Show("Fadlan geli nambaro sax ah oo kaliya qeybaha Age, Nights, iyo Guests.", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                // Marka nambarka la geliyo uu aad u weyn yahay
                MessageBox.Show("Nambarka aad gelisay waa ka weyn yahay xadkiisa.", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Qabashada wixii error ah oo kale
                MessageBox.Show($"Cilad aan la filayn ayaa dhacday: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)

        {
            // Clear previous booking details
            lstBookDetails.Items.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtNights.Clear();
            txtnumber.Clear();

            rdostandred.Checked = false;
            rdonormal.Checked = false;
            rdoHigh.Checked = false;

            chkBreakfast.Checked = false;

            lstBookDetails.Items.Clear();
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
    

