using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Methods
        private Button createButton(string name, string roll)
        {
            Button b = new Button();
            b.Text = name;
            b.Tag = roll;
            b.AutoSize = true;
            b.MouseUp += B_MouseClick;
            return b;
        }
        private List<string> ButtonsToString(List<Button> b)
        {
            List<string> s = new List<string>();
            foreach(Button but in b)
            {
                string button = but.Text + "||" + but.Tag.ToString();
                s.Add(button);
            }
            return s;
        }
        private List<Button> StringsToButtons(List<string> s)
        {
            List<Button> b = new List<Button>();
            foreach(string but in s)
            {
                Button button = new Button();
                button.Text = but.Substring(0, but.IndexOf("||"));
                button.Tag = but.Substring(but.IndexOf("||") + 2, but.Length - (but.IndexOf("||") + 2));
                button.MouseDown += B_MouseClick;
                b.Add(button);
            }
            return b;
        }
        #endregion
        #region EventHandlers
        private void B_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                string roll = ((Button)sender).Tag.ToString();
                string name = ((Button)sender).Text.ToString();
                int result = Util.RollDice(roll);
                txt_Results.AppendText(name + " (" + roll + "): " + result.ToString());
                txt_Results.AppendText(Environment.NewLine);
            }
            if(e.Button == MouseButtons.Right)
            {
                pnl_ButtonCollector.Controls.Remove((Button)sender);
            }
        }
        private void btn_CreateRoll_Click(object sender, EventArgs e)
        {
            if(txt_RollName.Text == "" || txt_RollName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a name for the roll.");
                return;
            }
            if (txt_RollValue.Text == "" || txt_RollValue.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value for the roll.");
                return;
            }
            pnl_ButtonCollector.Controls.Add(createButton(txt_RollName.Text, txt_RollValue.Text));
            txt_RollName.Clear();
            txt_RollValue.Clear();
            txt_RollName.Focus();
        }

        private void saveRollSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pnl_ButtonCollector.Controls.Count < 1)
            {
                MessageBox.Show("There are no rolls to save!");
                return;
            }
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Rolls (*.xml) | *.xml";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                List<Button> buttons = pnl_ButtonCollector.Controls.OfType<Button>().ToList();
                List<string> buttonData = ButtonsToString(buttons);
                Util.SerializeRolls(buttonData, sf.FileName);
            }
        }
        private void loadRollSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Rolls (*.xml) | *.xml";
            List<Button> buttons = new List<Button>();
            if(of.ShowDialog() == DialogResult.OK)
            {
                buttons = StringsToButtons(Util.DeserializeRolls(of.FileName));
                foreach(Button b in buttons)
                {
                    pnl_ButtonCollector.Controls.Add(b);
                }
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the results?", "Clear Results" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txt_Results.Clear();
            }
        }
        private void clearButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove all buttons?", "Remove Buttons", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pnl_ButtonCollector.Controls.Clear();
            }
        }
        #endregion

    }
}
