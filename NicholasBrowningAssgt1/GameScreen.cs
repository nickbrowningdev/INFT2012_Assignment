using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicholasBrowningAssgt1
{
    public partial class GameScreen : Form
    {
        // graphics & solidbrush classes & objects
        private Graphics die1;
        private Graphics die2;
        private SolidBrush brushDieOne;
        private SolidBrush brushDieTwo;

        // dice random class & face index
        private Random dice = new Random();

        // player name variables
        private string PlayerOneName;
        private string PlayerTwoName;

        // player turn variable
        private int playerTurnIndex;
        private string playerTurn;

        // player wins variable
        private int playeroneWins;
        private int playertwoWins;

        // goal score variable
        private int goalscore;

        // running score and cumulative score variables
        private int playeroneRunningScore;
        private int playertwoRunningScore;
        private int playeroneCumulativeScore;
        private int playertwoCumulativeScore;
        
        // die total
        private int diceTotal;

        // ai
        private Random ai_decision = new Random();
        private int ai_decision_index;

        public GameScreen()
        {
            InitializeComponent();

            die1 = picboxDieOne.CreateGraphics();
            die2 = picboxDieTwo.CreateGraphics();

            brushDieOne = new SolidBrush(Color.Black);
            brushDieTwo = new SolidBrush(Color.Black);
        }

        private void BtnPlayerVsCPUSetup_Click(object sender, EventArgs e)
        {
            unlockPlayerVsCPUsettings();
        }

        private void unlockPlayerVsCPUsettings()
        {
            // gets rid of read only restriction
            txtPlayerOneName.ReadOnly = false;

            // enables button
            BtnSetPlayerNames.Enabled = true;

            // hides buttons & disables PvP button
            BtnPlayerVsCPUSetup.Visible = false;
            BtnPlayerVsPlayerSetup.Visible = false;
            BtnPlayerVsPlayerSetup.Enabled = false;
        }

        private void BtnPlayerVsPlayerSetup_Click(object sender, EventArgs e)
        {
            unlockPlayerVsPlayersettings();
        }

        private void unlockPlayerVsPlayersettings()
        {
            // gets rid of read only restriction
            txtPlayerOneName.ReadOnly = false;
            txtPlayerTwoName.ReadOnly = false;

            // enables button
            BtnSetPlayerNames.Enabled = true;

            // hides buttons & disables PvCPU button
            BtnPlayerVsCPUSetup.Visible = false;
            BtnPlayerVsPlayerSetup.Visible = false;
            BtnPlayerVsCPUSetup.Enabled = false;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            // player setup group
            // buttons are visible
            BtnPlayerVsCPUSetup.Visible = true;
            BtnPlayerVsPlayerSetup.Visible = true;
            // buttons are enabled 
            BtnPlayerVsCPUSetup.Enabled = true;
            BtnPlayerVsPlayerSetup.Enabled = true;
            
            // player name setup group
            // textboxes
            txtPlayerOneName.Text = "";
            txtPlayerOneName.ReadOnly = true;
            txtPlayerTwoName.Text = "";
            txtPlayerTwoName.ReadOnly = true;
            // buttons
            BtnSetPlayerNames.Enabled = false;

            // goal score group
            // textboxes
            txtScoreGoal.Text = "";
            txtScoreGoal.ReadOnly = true;
            // buttons
            BtnSetScore.Enabled = false;

            // pic boxes group
            die1.Clear(Color.White);
            die2.Clear(Color.White);
            BtnPass.Enabled = false;
            BtnRoll.Enabled = false;
            lblPlayerTurn.Text = "";

            // score sheet group
            listPlayerOneRunningScore.Items.Clear();
            listPlayerTwoRunningScore.Items.Clear();
            txtPlayerOneCumulativeScore.Text = "";
            txtPlayerTwoCumulativeScore.Text = "";
            txtPlayerOneTotalWins.Text = "";
            txtPlayerTwoTotalWins.Text = "";

            // game screen lables
            lblPlayerTurn.Text = "";
            lblGoalScore.Text = "";

            restartStats(ref playeroneRunningScore, ref playertwoRunningScore, ref playeroneCumulativeScore, ref playertwoCumulativeScore, ref playeroneWins, ref playertwoWins);
        }

        // closes game
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // application shuts down
            Application.Exit();
        }

        private void BtnSetPlayerNames_Click(object sender, EventArgs e)
        {
            // checks the game mode the user clicked
            if (BtnPlayerVsPlayerSetup.Enabled == false)
            {
                if (txtPlayerOneName.Text == "")
                {
                    MessageBox.Show("Enter a username for Player One");
                }
                else if (txtPlayerOneName.Text == "CPU")
                {
                    MessageBox.Show("The AI has requested to not use their name.");
                    MessageBox.Show("He will sue the developer. Trust me, it's being done before.");
                }
                else
                {
                    PlayerOneName = txtPlayerOneName.Text;
                    PlayerTwoName = "CPU";

                    // restricts username boxes to readonly with username displayed
                    txtPlayerOneName.Text = PlayerOneName.ToString();
                    txtPlayerTwoName.Text = PlayerTwoName.ToString();
                    txtPlayerOneName.ReadOnly = true;
                    txtPlayerTwoName.ReadOnly = true;
                    //disables button
                    BtnSetPlayerNames.Enabled = false;

                    // calls method
                    unlockGoalScoresettings();
                }
            }
            else if (BtnPlayerVsCPUSetup.Enabled == false)
            {
                if ((txtPlayerOneName.Text == "") && (txtPlayerTwoName.Text == ""))
                {
                    MessageBox.Show("Enter a username for both Player One and Player Two");
                }
                else if (txtPlayerOneName.Text == "")
                {
                    MessageBox.Show("Enter a username for Player One");
                }
                else if (txtPlayerTwoName.Text == "")
                {
                    MessageBox.Show("Enter a username for Player Two");
                }
                else if (txtPlayerOneName.Text == txtPlayerTwoName.Text)
                {
                    MessageBox.Show("Player One and Player Two cannot have the same name");
                }
                else if (txtPlayerOneName.Text == "CPU")
                {
                    MessageBox.Show("You cannot name Player One 'CPU', The AI hates sharing names");
                }
                else if (txtPlayerTwoName.Text == "CPU")
                {
                    MessageBox.Show("You cannot name Player Two 'CPU', The AI hates sharing names");
                }
                else
                {
                    PlayerOneName = txtPlayerOneName.Text;
                    PlayerTwoName = txtPlayerTwoName.Text;

                    // restricts username boxes to readonly with username displayed
                    txtPlayerOneName.Text = PlayerOneName.ToString();
                    txtPlayerTwoName.Text = PlayerTwoName.ToString();
                    txtPlayerOneName.ReadOnly = true;
                    txtPlayerTwoName.ReadOnly = true;
                    //disables button
                    BtnSetPlayerNames.Enabled = false;

                    // calls method
                    unlockGoalScoresettings();
                }
            }            
        }

        private void unlockGoalScoresettings()
        {
            txtScoreGoal.ReadOnly = false;
            BtnSetScore.Enabled = true;
        }

        private void BtnSetScore_Click(object sender, EventArgs e)
        {
            if (txtScoreGoal.Text == "")
            {
                MessageBox.Show("Enter A Goal Score!");
            }
            else
            {
                try
                {
                    goalscore = Convert.ToInt32(txtScoreGoal.Text);

                    if (goalscore < 1)
                    {
                        MessageBox.Show("Invalid Goal Score. Please Try Again!");
                    }
                    else
                    {
                        lblGoalScore.Text = goalscore.ToString();

                        BtnSetScore.Enabled = false;

                        txtScoreGoal.ReadOnly = true;

                        unlockGame();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }          
        }

        private void unlockGame()
        {
            // unlock buttons
            BtnPass.Enabled = true;
            BtnRoll.Enabled = true;

            randomizePlayerTurn();
        }

        private void randomizePlayerTurn()
        {
            Random rand_playerturn = new Random();
            int rand_playerturn_index;

            rand_playerturn_index = rand_playerturn.Next(2);



            if (rand_playerturn_index == 0)
            {
                lblPlayerTurn.Text = PlayerOneName;
            }
            else if (rand_playerturn_index == 1)
            {
                lblPlayerTurn.Text = PlayerTwoName;

                if (lblPlayerTurn.Text == "CPU")
                {
                    AIDecision();
                }
            }
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            int dieOneFace = 0;
            int dieTwoFace = 0;

            die1.Clear(Color.White);
            die2.Clear(Color.White);

            // roll dices for 15 times
            for (int i = 0; i < 15; i++)
            {
                dieOneFace = dice.Next(1, 7);
                dieTwoFace = dice.Next(1, 7);
               
                switch (dieOneFace)
                {
                    case 1:
                        DieOneFaceOne();
                        break;

                    case 2:
                        DieOneFaceTwo();
                        break;

                    case 3:
                        DieOneFaceThree();
                        break;

                    case 4:
                        DieOneFaceFour();
                        break;

                    case 5:
                        DieOneFaceFive();
                        break;

                    case 6:
                        DieOneFaceSix();
                        break;
                }

                
                switch (dieTwoFace)
                {
                    case 1:
                        DieTwoFaceOne();
                        break;

                    case 2:
                        DieTwoFaceTwo();
                        break;

                    case 3:
                        DieTwoFaceThree();
                        break;

                    case 4:
                        DieTwoFaceFour();
                        break;

                    case 5:
                        DieTwoFaceFive();
                        break;

                    case 6:
                        DieTwoFaceSix();
                        break;
                }

                // Timer to create effect of dice rolling
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            if (((dieOneFace == 6) && (dieTwoFace == 1)) || ((dieOneFace == 1) && (dieTwoFace == 6)))
            {
                MessageBox.Show("Die 1 is a Six & Die 2 is a One!");
                MessageBox.Show("Running Score and Cumulative Score is '0'!");
                resetRunningScoreCumulative();
            }
            else if (dieOneFace == 6)
            {
                MessageBox.Show("You rolled a six. You lose the dice!");
                MessageBox.Show("Running Score is '0'!");
                resetRunningScore();
            }
            else if (dieTwoFace == 6)
            {
                MessageBox.Show("You rolled a six. You lose the dice!");
                MessageBox.Show("Running Score is '0'!");
                resetRunningScore();
            }            
            else
            {
                diceTotal = dieOneFace + dieTwoFace;

                if (lblPlayerTurn.Text == PlayerOneName)
                {
                    playeroneRunningScore += diceTotal;

                    playeroneCumulativeScore += diceTotal;

                    listPlayerOneRunningScore.Items.Add(playeroneRunningScore.ToString());

                    if (playeroneCumulativeScore >= goalscore)
                    {
                        updatePlayerOneWins();
                    }
                }
                else if (lblPlayerTurn.Text == PlayerTwoName)
                {
                    playertwoRunningScore += diceTotal;

                    playertwoCumulativeScore += diceTotal;

                    listPlayerTwoRunningScore.Items.Add(playertwoRunningScore.ToString());

                    if (playertwoCumulativeScore >= goalscore)
                    {
                        updatePlayerTwoWins();
                    }
                }

                diceTotal = 0;
            }           
        }

        private void RollDice()
        {

        }

        private void resetRunningScore()
        {
            if (lblPlayerTurn.Text == PlayerOneName)
            {
                listPlayerOneRunningScore.Items.Clear();

                diceTotal = 0;
                playeroneRunningScore = 0;

                lblPlayerTurn.Text = PlayerTwoName;
            }
            else if (lblPlayerTurn.Text == PlayerTwoName)
            {
                listPlayerTwoRunningScore.Items.Clear();

                diceTotal = 0;
                playertwoRunningScore = 0;

                lblPlayerTurn.Text = PlayerOneName;
            }

            die1.Clear(Color.White);
            die2.Clear(Color.White);
        }

        private void resetRunningScoreCumulative()
        {
            if (lblPlayerTurn.Text == PlayerOneName)
            {
                listPlayerOneRunningScore.Items.Clear();

                diceTotal = 0;
                playeroneRunningScore = 0;

                playeroneRunningScore = 0;
                playeroneCumulativeScore = 0;

                txtPlayerOneCumulativeScore.Text = "";

                lblPlayerTurn.Text = PlayerTwoName;
            }
            else if (lblPlayerTurn.Text == PlayerTwoName)
            {
                listPlayerTwoRunningScore.Items.Clear();

                playertwoRunningScore = 0;
                playertwoCumulativeScore = 0;

                txtPlayerTwoCumulativeScore.Text = "";


                lblPlayerTurn.Text = PlayerOneName;
            }

            die1.Clear(Color.White);
            die2.Clear(Color.White);
        }

        private void updatePlayerOneWins()
        {
            playeroneWins++;
            txtPlayerOneTotalWins.Text = playeroneWins.ToString();
            MessageBox.Show("Player Two wins this game!");

            playeroneCumulativeScore = 0;
            playertwoCumulativeScore = 0;

            playeroneRunningScore = 0;
            playertwoRunningScore = 0;

            diceTotal = 0;

            txtPlayerOneCumulativeScore.Text = "";
            txtPlayerTwoCumulativeScore.Text = "";

            listPlayerOneRunningScore.Items.Clear();
            listPlayerTwoRunningScore.Items.Clear();

            die1.Clear(Color.White);
            die2.Clear(Color.White);

            randomizePlayerTurn();
        }

        private void updatePlayerTwoWins()
        {
            playertwoWins++;
            txtPlayerTwoTotalWins.Text = playertwoWins.ToString();
            MessageBox.Show("Player Two wins this game!");

            playeroneCumulativeScore = 0;
            playertwoCumulativeScore = 0;

            playeroneRunningScore = 0;
            playertwoRunningScore = 0;

            diceTotal = 0;

            txtPlayerOneCumulativeScore.Text = "";
            txtPlayerTwoCumulativeScore.Text = "";

            listPlayerOneRunningScore.Items.Clear();
            listPlayerTwoRunningScore.Items.Clear();

            die1.Clear(Color.White);
            die2.Clear(Color.White);

            randomizePlayerTurn();
        }

        private void resetCumulativeScore(ref int score1, ref int score2)
        {
            score1 = 0;
            score2 = 0;

            playeroneRunningScore = 0;
            playertwoRunningScore = 0;

            diceTotal = 0;

            txtPlayerOneCumulativeScore.Text = "";
            txtPlayerTwoCumulativeScore.Text = "";

            listPlayerOneRunningScore.Items.Clear();
            listPlayerTwoRunningScore.Items.Clear();

            die1.Clear(Color.White);
            die2.Clear(Color.White);
        }

        private void updateStatsPlayerOne()
        {
            txtPlayerOneCumulativeScore.Text = playeroneCumulativeScore.ToString();
        }

        private void updateStatsPlayerTwo()
        {
            txtPlayerTwoCumulativeScore.Text = playertwoCumulativeScore.ToString();
        }

        private void BtnPass_Click(object sender, EventArgs e)
        {
            if (lblPlayerTurn.Text == PlayerOneName)
            {
                listPlayerOneRunningScore.Items.Clear();

                

                updateStatsPlayerOne();

                diceTotal = 0;
                playeroneRunningScore = 0;

                

                lblPlayerTurn.Text = PlayerTwoName;
            }
            else if (lblPlayerTurn.Text == PlayerTwoName)
            {
                listPlayerTwoRunningScore.Items.Clear();

                

                updateStatsPlayerTwo();

                
                playertwoRunningScore = 0;

                

                lblPlayerTurn.Text = PlayerOneName;
            }

            die1.Clear(Color.White);
            die2.Clear(Color.White);
        }

        private void DieOneFaceOne()
        {
            die1.Clear(Color.White);
            die1.FillEllipse(brushDieOne, 75, 85, 40, 40);
        }

        private void DieOneFaceTwo()
        {
            die1.Clear(Color.White);
            die1.FillEllipse(brushDieOne, 130, 20, 40, 40);
            die1.FillEllipse(brushDieOne, 20, 145, 40, 40);
        }

        private void DieOneFaceThree()
        {
            die1.Clear(Color.White);
            die1.FillEllipse(brushDieOne, 130, 20, 40, 40);
            die1.FillEllipse(brushDieOne, 75, 85, 40, 40);
            die1.FillEllipse(brushDieOne, 20, 145, 40, 40);
        }

        private void DieOneFaceFour()
        {
            die1.Clear(Color.White);
            die1.FillEllipse(brushDieOne, 130, 20, 40, 40);
            die1.FillEllipse(brushDieOne, 20, 145, 40, 40);

            die1.FillEllipse(brushDieOne, 20, 20, 40, 40);
            die1.FillEllipse(brushDieOne, 130, 145, 40, 40);
        }

        private void DieOneFaceFive()
        {
            die1.Clear(Color.White);
            die1.FillEllipse(brushDieOne, 130, 20, 40, 40);
            die1.FillEllipse(brushDieOne, 20, 145, 40, 40);
            die1.FillEllipse(brushDieOne, 75, 85, 40, 40);
            die1.FillEllipse(brushDieOne, 20, 20, 40, 40);
            die1.FillEllipse(brushDieOne, 130, 145, 40, 40);
        }

        private void DieOneFaceSix()
        {
            die1.Clear(Color.White);
            die1.FillEllipse(brushDieOne, 130, 20, 40, 40);
            die1.FillEllipse(brushDieOne, 20, 145, 40, 40);

            die1.FillEllipse(brushDieOne, 130, 82, 40, 40);
            die1.FillEllipse(brushDieOne, 20, 82, 40, 40);

            die1.FillEllipse(brushDieOne, 20, 20, 40, 40);
            die1.FillEllipse(brushDieOne, 130, 145, 40, 40);
        }

        private void DieTwoFaceOne()
        {
            die2.Clear(Color.White);
            die2.FillEllipse(brushDieTwo, 75, 85, 40, 40);
        }

        private void DieTwoFaceTwo()
        {
            die2.Clear(Color.White);
            die2.FillEllipse(brushDieTwo, 130, 20, 40, 40);
            die2.FillEllipse(brushDieTwo, 20, 145, 40, 40);
        }

        private void DieTwoFaceThree()
        {
            die2.Clear(Color.White);
            die2.FillEllipse(brushDieTwo, 130, 20, 40, 40);
            die2.FillEllipse(brushDieTwo, 75, 85, 40, 40);
            die2.FillEllipse(brushDieTwo, 20, 145, 40, 40);
        }

        private void DieTwoFaceFour()
        {
            die2.Clear(Color.White);
            die2.FillEllipse(brushDieTwo, 130, 20, 40, 40);
            die2.FillEllipse(brushDieTwo, 20, 145, 40, 40);

            die2.FillEllipse(brushDieTwo, 20, 20, 40, 40);
            die2.FillEllipse(brushDieTwo, 130, 145, 40, 40);
        }

        private void DieTwoFaceFive()
        {
            die2.Clear(Color.White);
            die2.FillEllipse(brushDieTwo, 130, 20, 40, 40);
            die2.FillEllipse(brushDieTwo, 20, 145, 40, 40);
            die2.FillEllipse(brushDieTwo, 75, 85, 40, 40);
            die2.FillEllipse(brushDieTwo, 20, 20, 40, 40);
            die2.FillEllipse(brushDieTwo, 130, 145, 40, 40);
        }

        private void DieTwoFaceSix()
        {
            die2.Clear(Color.White);
            die2.FillEllipse(brushDieTwo, 130, 20, 40, 40);
            die2.FillEllipse(brushDieTwo, 20, 145, 40, 40);
            die2.FillEllipse(brushDieTwo, 130, 82, 40, 40);
            die2.FillEllipse(brushDieTwo, 20, 82, 40, 40);
            die2.FillEllipse(brushDieTwo, 20, 20, 40, 40);
            die2.FillEllipse(brushDieTwo, 130, 145, 40, 40);
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            // player name setup group
            // textboxes
            txtPlayerOneName.Text = "";
            txtPlayerOneName.ReadOnly = true;
            txtPlayerTwoName.Text = "";
            txtPlayerTwoName.ReadOnly = true;
            // buttons
            BtnSetPlayerNames.Enabled = false;

            // goal score group
            // textboxes
            txtScoreGoal.Text = "";
            txtScoreGoal.ReadOnly = true;
            // buttons
            BtnSetScore.Enabled = false;

            // pic boxes group
            die1.Clear(Color.White);
            die2.Clear(Color.White);
            BtnPass.Enabled = false;
            BtnRoll.Enabled = false;
            lblPlayerTurn.Text = "";

            // score sheet group
            listPlayerOneRunningScore.Items.Clear();
            listPlayerTwoRunningScore.Items.Clear();
            txtPlayerOneCumulativeScore.Text = "";
            txtPlayerTwoCumulativeScore.Text = "";
            txtPlayerOneTotalWins.Text = "";
            txtPlayerTwoTotalWins.Text = "";

            // game screen lables
            lblPlayerTurn.Text = "";
            lblGoalScore.Text = "";

            
        }

        private void restartStats (ref int p1run, ref int p2run, ref int p1cum, ref int p2cum, ref int p1wins, ref int p2wins)
        {
            playeroneRunningScore = 0;
            playertwoRunningScore = 0;
            playeroneCumulativeScore = 0;
            playertwoCumulativeScore = 0;
            playeroneWins = 0;
            playertwoWins = 0;
        }

        private void AiTimer(int iMillisecs)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(iMillisecs);
        }

        private void AIDecision ()
        {
            ai_decision_index = 0;

            MessageBox.Show("My name is Ai");
            MessageBox.Show("Ai will make decision");

            for (int j = 0; j < 10; j ++)
            {
                ai_decision_index = ai_decision.Next(5);

                // Timer to create effect of dice rolling
                AiTimer(200);
            }

            switch (ai_decision_index)
            {
                case 0:
                    AIRollDice();
                    break;

                case 1:
                    AIRollDice();
                    break;

                case 2:
                    AIRollDice();
                    break;

                case 3:
                    AIRollDice();
                    break;

                case 4:
                    AIPassDice();
                    break;               
            }
        }

        private void AIRollDice ()
        {
            MessageBox.Show("Ai will roll dice");
            //RollDice();
        }

        private void AIPassDice ()
        {
            MessageBox.Show("Ai will pass dice");
            //AIPassDice();
        }
    }
}
