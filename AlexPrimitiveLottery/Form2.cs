using System;
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
    public partial class Form2 : Form
    {
        /*FORM TO SHOW THE RESULTS!*/
        public Form2(int[] sortedWinningCombination, int[] sortedUserCombination, int coincidences, 
             int reintegroWin, int reintegroUser)
        {
            InitializeComponent();

            // We show into the tablelayouts both user's and winner combinations
            for (int i = 0; i < winnerTableLayout.ColumnCount-1; i++)
            {
                winnerTableLayout.Controls[i].Text = sortedWinningCombination[i].ToString();
                userTableLayout.Controls[i].Text = sortedUserCombination[i].ToString();
            }

            // Also we show the reimbursement in the last place of each tablelayout
            winnerTableLayout.Controls[winnerTableLayout.Controls.Count - 1].Text = "R: " + reintegroWin.ToString();
            userTableLayout.Controls[userTableLayout.Controls.Count - 1].Text = "R: " + reintegroUser.ToString();

            // Message showing the number of coincidences
            descriptionLabel.Text = "You have matched: " + coincidences + " numbers!!";

            // The heading of this form will depend on the number of coincidences...
            switch (coincidences)
            {
                case 0:
                    messageLabel.Text = "TRY AGAIN!";
                    break;
                case 6:
                    messageLabel.Text = "YOU WON! YOU ARE RICH NOW!";
                    break;
                default:
                    messageLabel.Text = "YOU ALMOST GOT IT!";
                    break;
            }


        }

    }
}
