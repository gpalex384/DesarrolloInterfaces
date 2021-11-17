using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primitive_Lottery
{
    public partial class Form1 : Form
    {
        private CheckBox[] listOfCheckboxes = new CheckBox[49];
        private int[] userCombination = new int[6];
        private int reintegroUser;
        private Random rnd = new Random();
        private bool reimbursement = false;

        public Form1()
        {
            InitializeComponent();
            /*Generate the check boxes */
            for (int i = 0; i < listOfCheckboxes.Length; i++)
            {
                
                listOfCheckboxes[i] = new CheckBox();
                string number = (i + 1).ToString();
                listOfCheckboxes[i].Text = ":" + number;
                listOfCheckboxes[i].RightToLeft = RightToLeft.Yes;
                listOfCheckboxes[i].SetBounds(0, 0, 55, 35);
                listOfCheckboxes[i].ForeColor = Color.DarkRed;
                listOfCheckboxes[i].Font = new Font("Arial", 10, FontStyle.Regular);
                listOfCheckboxes[i].Click += new EventHandler(numberCheckBox_Click); 
                flowLayoutPanel1.Controls.Add(listOfCheckboxes[i]);
            }
            /*Generate the reimbursement number and show it */
            reintegroText.Text = rnd.Next(10).ToString();
        }

        /*IF MANUAL BUTTON IS CLICKED */
        private void manualButton_Click(object sender, EventArgs e)
        {
            /*CHECK THE NUMBERS THAT THE USER HAS CHOSEN */
            /*Initialize required variables */
            string txtmsg = "";
            int contadorChecks = 0;
            int j = 0;
            for (int i = 0; i < listOfCheckboxes.Length; i++)
            {
                if (listOfCheckboxes[i].Checked)
                {
                    contadorChecks++;
                    
                    userCombination[j] = i+1;

                    // prevent exceeding the length of the userCombination array
                    j++;
                    
                }
            }

            /*Check if more or less than 6 numbers have been chosen and get a message */
            if (contadorChecks != 6)
            {
                txtmsg += "You must tick 6 numbers.\n";
            }
            //This could be if the user could choose the reimbursement. Now it is disabled.
            /*try
            {
                int reintegroElegido = int.Parse(reintegroText.Text);
                if (reintegroElegido < 0 || reintegroElegido > 9)
                {
                    txtmsg += "You must write a number between 0 and 9 as reimbursement.";
                }
                else
                {
                    reintegroUser = reintegroElegido;
                }
            }
            catch (Exception)
            {

                txtmsg += "The reimbursement must be a number";
            }
            */

            // If the bet is correct
            if (txtmsg.Equals(""))
            {
                // Ask for confirmation
                DialogResult dialogResult = MessageBox.Show("Do you want to submit this bet?", "SUBMITTING",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Let's play!
                    show_results_raffle();
                }
            }
            else
            {
                // Bet not correct, show the pertinent message.
                MessageBox.Show(txtmsg);
            }
            
        }
        /*IF AUTOMATIC BUTTON IS PRESSED*/
        private void automaticButton_Click(object sender, EventArgs e)
        {
            // First of all clear all the ticks (erase button)
            eraseButton_Click(sender, e);
            
            // Get the automatic user's combination by using random numbers
            int[] rndNumbers = new int[6];
            for (int i = 0; i < rndNumbers.Length; i++)
            {
                int randomNumber = rnd.Next(listOfCheckboxes.Length);

                // Using the 'repeated' function
                if (!Repeated(rndNumbers, randomNumber))
                {
                    rndNumbers[i] = randomNumber;
                    listOfCheckboxes[randomNumber].Checked = true;
                    listOfCheckboxes[randomNumber].Font = new Font(this.Font, FontStyle.Bold);
                    // Assign the random number to the user combination
                    userCombination[i] = randomNumber +1 ;
                }
                else
                {
                    // If the number is repeated, we try again
                    i--;
                }
                
            }

            // Assign a random reimbursement
            int reintegro = rnd.Next(10);
            reintegroText.Text = reintegro.ToString();
            reintegroUser = reintegro;

            // Ask if the combination is good enough for the user
            DialogResult dialogResult = MessageBox.Show("Do you want to submit this bet?", "SUBMITTING",
                    MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Let's play!
                show_results_raffle();
            }

        }

        /*CLEARS ALL THE NUMBERS CHOSEN*/
        private void eraseButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listOfCheckboxes.Length; i++)
            {
                // Set to false inmediately!
                listOfCheckboxes[i].Checked = false;
                listOfCheckboxes[i].Font = new Font(this.Font, FontStyle.Regular);
                // reinitiate the list
                listOfCheckboxes.Initialize();
                // reinitiate the reimbursement
                reintegroText.Text = rnd.Next(10).ToString();
            }
        }

        /*GIVE THE CHOSEN NUMBERS SOME STYLE!*/
        private void numberCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox clickedCheckBox = sender as CheckBox;
            if (clickedCheckBox != null)
            {
                if (clickedCheckBox.Checked)
                {
                    // bold if clicked
                    clickedCheckBox.Font = new Font(this.Font, FontStyle.Bold);
                }
                else
                {
                    // regular if not clicked
                    clickedCheckBox.Font = new Font(this.Font, FontStyle.Regular);
                }
            }
        }

        /*SHOW RESULTS!*/
        private void show_results_raffle()
        {
            // first, define the random winner combination
            int[] rndNumbersWin = new int[6];
            for (int i = 0; i < rndNumbersWin.Length; i++)
            {
                int randomNumberWin = rnd.Next(listOfCheckboxes.Length);
                // using repeated function, we prevent repeated numbers in the combination
                if (!Repeated(rndNumbersWin, randomNumberWin))
                {
                    rndNumbersWin[i] = randomNumberWin;
                }
                else
                {
                    i--;
                }
            }

            // get the winner reimbursement
            int reintegroWin = rnd.Next(10);
            // once the user's and winner combinations are given, we sort them using the handmade sort() function
            int[] sortedNumbersWin = Sort(rndNumbersWin);
            int[] sortedNumbersUser = Sort(userCombination);

            // count coincidences between user's and winner combination
            int coincidences = 0;
            for (int i = 0; i < sortedNumbersUser.Length; i++)
            {
                if (sortedNumbersWin.Contains(sortedNumbersUser[i]))
                {
                    coincidences++;
                }
            }

            // does reimbursement coincide?
            if (reintegroUser == reintegroWin)
            {
                reimbursement = true;
            }

            // Build the form 2 where the results are to be showed.
            // We pass the required parameters
            Form2 form2 = new Form2(sortedNumbersWin, sortedNumbersUser, coincidences, reintegroWin, reintegroUser);
            form2.Show();

            // If the reimbursement coincides, we show it as a separate message.
            if (reimbursement)
            {
                MessageBox.Show("The reimbursement is correct, so your money will be refunded!");
                reimbursement = false;
            }
        }

        /*THIS FUNCTION CHECKS IF A NUMBER IS CONTAINED IN AN ARRAY OF INT'S*/
        private bool Repeated(int[] list, int number)
        {
            if (list.Contains(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*THIS FUNCTION SORTS AN ARRAY OF INTS*/
        private int[] Sort(int[] listOfNumbers)
        {
            // continue sorting until the array is fully sorted
            bool iterate = true;
            while (iterate)
            {
                iterate = false;
                for (int i = 1; i < listOfNumbers.Length; i++)
                {
                    if (listOfNumbers[i] < listOfNumbers[i-1])
                    {
                        iterate = true;
                        int numeroMayor = listOfNumbers[i-1];
                        listOfNumbers[i - 1] = listOfNumbers[i];
                        listOfNumbers[i] = numeroMayor;
                    }
                }
            }
            return listOfNumbers;
            
        }
                

    }
}
