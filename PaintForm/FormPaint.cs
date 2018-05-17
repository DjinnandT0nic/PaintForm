using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PaintForm
{

    public partial class FormPaint : Form
    {
        public FormPaint()
        {
            InitializeComponent();
        }

     
       
        //This method is called when a text box loses focus to make sure the input is a positive decimal
        public void TextBox_Validating(object sender, CancelEventArgs e)
        {
            //Casts the sender object to type TextBox so that its properties can be changed
            var textBox = sender as TextBox;

            //calls CheckNum to test whether the string entered into text box can be converted into a positive double. 
            bool isPosDouble = Functions.CheckNum(textBox.Text);

            //If the string entered into the text box cannot be converted to a positive decimal, the text box is cleared and the focus is put back onto the text box.
            if (!isPosDouble)
            {
                textBox.Text = String.Empty;
                e.Cancel = true;
            }
        }
        //This method is called when an input to the text boxes has been validated, or an inputed value has otherwise changed.
        //It will update the outputs of the form if the requisite fields contain values.
        public void Object_Validated(object sender, EventArgs e)
        {
            //surfaceArea is used to store the wall surface area, so that it can be used in the paint calculations.
            double surfaceArea = 0;

            //Checks if the txtLength and txtWidth boxes are empty.
            //if both have values, lblFloorArea's text is set to the calculated floor area (Area = length * width).
            //if either is empty, lblFloorArea's text (which shows the floor area of the room) is cleared.            
            if (!String.IsNullOrEmpty(txtLength.Text) && !String.IsNullOrEmpty(txtWidth.Text))
            {
                //the two text box entries are converted to double for the calculation, the result of which is then converted back into a string, so it can be passed to the label.
                lblFloorArea.Text = Convert.ToString(Convert.ToDouble(txtLength.Text) * Convert.ToDouble(txtWidth.Text)) + " m^2";
            }
            else
            {
                lblFloorArea.Text = String.Empty;                
            }

            //Checks if the txtHeight, txtLength and txtWidth boxes are empty.
            //if all three have values, lblWallArea's text is set to the calculated surface area of the walls (Surface area = (2 * height * (width + length))).
            //if any are empty, lblWallArea's text is cleared.            
            if (!String.IsNullOrEmpty(txtHeight.Text) && !String.IsNullOrEmpty(txtLength.Text) && !String.IsNullOrEmpty(txtWidth.Text))
            {
                //the three text box entries are converted to double for the calculation, the result of which is then converted back into a string, so it can be passed to the label.
                surfaceArea = 2 * Convert.ToDouble(txtHeight.Text) * (Convert.ToDouble(txtLength.Text) + Convert.ToDouble(txtWidth.Text));
                lblWallArea.Text = Convert.ToString(surfaceArea) + " m^2";
            }
            else
            {
                lblWallArea.Text = String.Empty;
            }

            //Checks if the txtHeight, txtLength and txtWidth boxes are empty.
            //if all three have values, lblVolume's text is set to the calculated volume of the room (Volume = height * length * width).
            //if any are empty, lblVolume's text is cleared.            
            if (!String.IsNullOrEmpty(txtHeight.Text) && !String.IsNullOrEmpty(txtLength.Text) && !String.IsNullOrEmpty(txtWidth.Text))
            {
                //the three text box entries are converted to double for the calculation, the result of which is then converted back into a string, so it can be passed to the label.
                lblVolume.Text = (Convert.ToDouble(txtHeight.Text) * Convert.ToDouble(txtLength.Text) * Convert.ToDouble(txtWidth.Text)) + " m^3";
            }
            else
            {
                lblVolume.Text = String.Empty;
            }

            //Checks if the txtHeight, txtLength, txtWidth and txtPaintCover boxes are empty.
            //if all four have values, lblPaint's text is set to the calculated quantity of paint needed to cover the walls (Paint Needed = Surface Area / (Paint Coatings * Surface Area per Litre).
            //if any are empty, lblPaint's text is cleared.            
            if (!String.IsNullOrEmpty(txtHeight.Text) && !String.IsNullOrEmpty(txtLength.Text) && !String.IsNullOrEmpty(txtWidth.Text) && !String.IsNullOrEmpty(txtPaintCover.Text))
            {
                //The value of txtPaintCover is converted to double for the calculation, the result of which is then converted back into a string, so it can be passed to the label.
                double paint = (surfaceArea / (Convert.ToDouble(tBarPaint.Value) * Convert.ToDouble(txtPaintCover.Text)));
                lblPaint.Text = Convert.ToString( Math.Round(paint, 2)  + " litres");
            }
            else
            {
                lblPaint.Text = String.Empty;
            }
        }
         //Whenever TBarPaint's value changes, it updates the value of lblCoatings so that the value can be easily read.
        public void TBarPaint_Scroll(object sender, EventArgs e)
        {
            lblCoatings.Text = Convert.ToString(tBarPaint.Value);

            //Object_Validated is then called to update the calculations.
            Object_Validated(sender, e);
        }

        //Whenever chkBoxCover is checked, it disbales txtPaintCover and sets its value to 12.
        //Whenever chkBocCover is unchecked, txtPaintCover is enabled and its value is cleared.
        //According to the British Coatings Federation's website (http://www.coatings.org.uk/faq/How_much_paint_to_use-7.aspx), 1 litre of emulsion paint will cover 12 m^2.
        public void chkBoxCover_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCover.Checked)
            {
                txtPaintCover.Text = "12";
                txtPaintCover.Enabled = false;
            }
            else
            {
                txtPaintCover.Enabled = true;
                txtPaintCover.Text = String.Empty;               
            }

            //Object_Validated is then called to update the calcuated values.
            Object_Validated(sender, e);
        }
    }

    public class Functions
    {
        //A method which will check if the string passed to it can be converted to the decimal data type without exception, and then checks if the number is positive.
        //The method will return true if the number is indeed a positive number, or will print an error message to the console if an exception is thrown, or the number is not positive.
        public static bool CheckNum(string toCheck)
        {
            //isPosDouble is returned to show whether the string passed into CheckNum could be converted successfully or not.
            bool isPosDouble = true;

            //The string is checked to see if it is empty - if it is empty, then nothing happens. If it isn't empty, then the string is then checked further.
            if (!string.IsNullOrEmpty(toCheck))
            {
                //Initialises the test variable toDouble, and the maximum value that toDouble can be.
                //The Maximum value is the diameter of the observeable universe - it is assumed that no room would be larger than this.
                double toDouble = 0;
                double maxValue = 5.5 * Math.Pow(10, 23);
                try
                {
                    //Tries to convert toCheck into double, with the exceptions being caught below.
                    toDouble = Convert.ToDouble(toCheck);
                }
                catch (FormatException)
                {
                    //If toCheck is not formatted as a number, the below error message is displayed.
                    MessageBox.Show("This is not a number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isPosDouble = false;
                }
                catch (OverflowException)
                {
                    //If, converting to a double would cause an overflow exception, the below error message is displayed.
                    MessageBox.Show("The magnitude of the number you have entered is too large. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isPosDouble = false;
                }

                if ((toDouble <= 0) && (isPosDouble))
                //Checks if the value of isPosDouble is greater than zero, then displays the below error message if not.                    
                //The value of isPosDouble is also checked to make sure an exception hasn't already been thrown, as there will be no valid value to assess in toDouble if one has been thrown.
                {
                    MessageBox.Show("This is not a positive number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isPosDouble = false;
                }

                if ((isPosDouble) && (Math.Abs(toDouble) > maxValue))
                //Checks if the magnitude of toDouble is below the cube root of 2^128, then displays an error message if not.
                //This is done so there isn't an overflow exception when the calculations are done later.
                //The value of isPosDouble is also checked to make sure an exception hasn't already been thrown, as there will be no valid value to assess in toDouble if one has been thrown.
                {
                    MessageBox.Show("The magnitude of the number you have entered is too large. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isPosDouble = false;
                }
            }
            // True is returned if isPosDouble can be coverted to a positive Decimal or is an empty string, False is returned if an exception was thrown, or the decimal was not positive.
            return isPosDouble;
        }
    }
}
