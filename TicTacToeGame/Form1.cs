using Microsoft.Win32;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        PlayerSign player = new PlayerSign();
       
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            

            Restart();

        }

        public void Restart()
        {
             buttons = new List<Button>() { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            foreach (Button item in buttons)
            {
                item.Enabled = true;
                item.Text = "";
                item.BackColor = DefaultBackColor;
            }
            tmrComputer.Stop();
        }

        private void ClickButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            player = PlayerSign.X;
            button.Text = player.ToString();
            button.Enabled = false;
            button.BackColor = Color.Blue;
            buttons.Remove(button);
            tmrComputer.Start();
            foreach (var item in buttons)
            {
                item.Enabled = false;
            }
            WinDetermination();
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void tmrComputer_Tick(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int selectedFromComp = rnd.Next(buttons.Count);
                player = PlayerSign.O;
                buttons[selectedFromComp].Enabled = false;
                buttons[selectedFromComp].Text = player.ToString();
                buttons[selectedFromComp].BackColor = Color.Red;
                buttons.RemoveAt(selectedFromComp);
                WinDetermination();
                tmrComputer.Stop();
                foreach (var item in buttons)
                {
                    item.Enabled = true;
                }
            }
        }

        private void WinDetermination()
        {
            if ((btn1.Text =="X" && btn2.Text =="X"&& btn3.Text =="X")|| (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")||(btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")||(btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")||(btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")||(btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") || (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") || (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X"))
            {
                tmrComputer.Stop();
                
                MessageBox.Show("Congratulations! You Win!!");
            }
            else if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O") || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O") || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") || (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") || (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O") || (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O"))
            {
                tmrComputer.Stop();
                
                MessageBox.Show("Computer WINS HAHAHAHA!!!");
            }
        }

       
    }
}