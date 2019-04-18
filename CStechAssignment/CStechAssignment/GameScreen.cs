using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CStechAssignment
{
    public partial class GameScreen : Form
    {
        decimal positiveVal = 0;
        decimal negativeVal = 0;
        GuessGame userTry;
        GuessGamePc PcTry;

        public GameScreen()
        {//oyun yaratılıyor
            InitializeComponent();
            userTry = new GuessGame();
            PcTry = new GuessGamePc();
            PcTry.SetNumberSet();
            string result = PcTry.PcTriesToGuees();
            chatBox.Items.Add(result);
            userTry.SetGameNumber();
            chatBoxPc.Items.Add("Tahmininiz Nedir?");
        }

        private void userGuess_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void numberOfPlus_ValueChanged(object sender, EventArgs e)
        {// + ve - sayı limitleri giriliyor
            numberOfNegatives.Maximum = 4 - numberOfPlus.Value; 

        }

        private void numberOfNegatives_ValueChanged(object sender, EventArgs e)
        {// + ve - sayı limitleri giriliyor
            numberOfPlus.Maximum = 4 - numberOfNegatives.Value;

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void submit1_Click(object sender, EventArgs e)
        {
            PcTry.SetPlusAndNegatives((int)numberOfPlus.Value, (int)numberOfNegatives.Value);//kullanıcıdan + ve - sayıları alınıyor
            PcTry.PlayGame();
            
            if(PcTry.GetPlus() == 4)//+ sayısı 4 olunca oyunu bitiriyor
            {
                chatBox.Items.Add("Bilgisayar " + PcTry.GetRound() + " turda, " + PcTry.GetRandomGuess()+" sayısını bularak kazandı!");
                submit1.Enabled = false;
            }
            else
            {
                string result = PcTry.PcTriesToGuees();
                chatBox.Items.Add(result);
            }
        }

        private void submit2_Click(object sender, EventArgs e)
        {

            userTry.SetGuess(userGuess.Value.ToString());
            string result = userTry.UserTriesToGuess();
            chatBoxPc.Items.Add(result);
            if(userTry.GetPlus() == 4)//kullanıcı sayıyı bilince oyunu bitiriyor
            {
                chatBoxPc.Items.Add("Tebrikler, " + userTry.GetRound() + " tur sonunda tahmin ettiğiniz sayı (" + userTry.GetGuess() + ") ile kazandınız!");
                submit2.Enabled = false;
            }
            
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
