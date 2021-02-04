namespace NicholasBrowningAssgt1
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPlayerVsPlayerSetup = new System.Windows.Forms.Button();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.BtnPlayerVsCPUSetup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSetPlayerNames = new System.Windows.Forms.Button();
            this.txtPlayerTwoName = new System.Windows.Forms.TextBox();
            this.txtPlayerOneName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtScoreGoal = new System.Windows.Forms.TextBox();
            this.BtnSetScore = new System.Windows.Forms.Button();
            this.lblSet = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblGoalScore = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnPass = new System.Windows.Forms.Button();
            this.BtnRoll = new System.Windows.Forms.Button();
            this.picboxDieTwo = new System.Windows.Forms.PictureBox();
            this.picboxDieOne = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPlayerTwoTotalWins = new System.Windows.Forms.TextBox();
            this.txtPlayerOneTotalWins = new System.Windows.Forms.TextBox();
            this.txtPlayerTwoCumulativeScore = new System.Windows.Forms.TextBox();
            this.txtPlayerOneCumulativeScore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listPlayerOneRunningScore = new System.Windows.Forms.ListBox();
            this.listPlayerTwoRunningScore = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDieTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDieOne)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(421, 414);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(326, 184);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLogo.TabIndex = 0;
            this.picboxLogo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExit);
            this.groupBox1.Controls.Add(this.BtnPlayerVsPlayerSetup);
            this.groupBox1.Controls.Add(this.BtnRestart);
            this.groupBox1.Controls.Add(this.BtnPlayerVsCPUSetup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Mode Setup";
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(148, 169);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(105, 61);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnPlayerVsPlayerSetup
            // 
            this.BtnPlayerVsPlayerSetup.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayerVsPlayerSetup.Location = new System.Drawing.Point(35, 102);
            this.BtnPlayerVsPlayerSetup.Name = "BtnPlayerVsPlayerSetup";
            this.BtnPlayerVsPlayerSetup.Size = new System.Drawing.Size(218, 61);
            this.BtnPlayerVsPlayerSetup.TabIndex = 1;
            this.BtnPlayerVsPlayerSetup.Text = "Player vs Player";
            this.BtnPlayerVsPlayerSetup.UseVisualStyleBackColor = true;
            this.BtnPlayerVsPlayerSetup.Click += new System.EventHandler(this.BtnPlayerVsPlayerSetup_Click);
            // 
            // BtnRestart
            // 
            this.BtnRestart.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestart.Location = new System.Drawing.Point(35, 169);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(105, 61);
            this.BtnRestart.TabIndex = 2;
            this.BtnRestart.Text = "Restart";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // BtnPlayerVsCPUSetup
            // 
            this.BtnPlayerVsCPUSetup.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlayerVsCPUSetup.Location = new System.Drawing.Point(35, 35);
            this.BtnPlayerVsCPUSetup.Name = "BtnPlayerVsCPUSetup";
            this.BtnPlayerVsCPUSetup.Size = new System.Drawing.Size(218, 61);
            this.BtnPlayerVsCPUSetup.TabIndex = 0;
            this.BtnPlayerVsCPUSetup.Text = "Player vs CPU";
            this.BtnPlayerVsCPUSetup.UseVisualStyleBackColor = true;
            this.BtnPlayerVsCPUSetup.Click += new System.EventHandler(this.BtnPlayerVsCPUSetup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSetPlayerNames);
            this.groupBox2.Controls.Add(this.txtPlayerTwoName);
            this.groupBox2.Controls.Add(this.txtPlayerOneName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Name Setup";
            // 
            // BtnSetPlayerNames
            // 
            this.BtnSetPlayerNames.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetPlayerNames.Location = new System.Drawing.Point(35, 122);
            this.BtnSetPlayerNames.Name = "BtnSetPlayerNames";
            this.BtnSetPlayerNames.Size = new System.Drawing.Size(218, 50);
            this.BtnSetPlayerNames.TabIndex = 7;
            this.BtnSetPlayerNames.Text = "Set Player Names";
            this.BtnSetPlayerNames.UseVisualStyleBackColor = true;
            this.BtnSetPlayerNames.Click += new System.EventHandler(this.BtnSetPlayerNames_Click);
            // 
            // txtPlayerTwoName
            // 
            this.txtPlayerTwoName.Location = new System.Drawing.Point(102, 78);
            this.txtPlayerTwoName.Name = "txtPlayerTwoName";
            this.txtPlayerTwoName.Size = new System.Drawing.Size(151, 22);
            this.txtPlayerTwoName.TabIndex = 6;
            // 
            // txtPlayerOneName
            // 
            this.txtPlayerOneName.Location = new System.Drawing.Point(102, 42);
            this.txtPlayerOneName.Name = "txtPlayerOneName";
            this.txtPlayerOneName.Size = new System.Drawing.Size(151, 22);
            this.txtPlayerOneName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtScoreGoal);
            this.groupBox3.Controls.Add(this.BtnSetScore);
            this.groupBox3.Controls.Add(this.lblSet);
            this.groupBox3.Location = new System.Drawing.Point(12, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 130);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Goal Setup";
            // 
            // txtScoreGoal
            // 
            this.txtScoreGoal.Location = new System.Drawing.Point(114, 33);
            this.txtScoreGoal.Margin = new System.Windows.Forms.Padding(4);
            this.txtScoreGoal.Name = "txtScoreGoal";
            this.txtScoreGoal.Size = new System.Drawing.Size(139, 22);
            this.txtScoreGoal.TabIndex = 6;
            // 
            // BtnSetScore
            // 
            this.BtnSetScore.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetScore.Location = new System.Drawing.Point(35, 63);
            this.BtnSetScore.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSetScore.Name = "BtnSetScore";
            this.BtnSetScore.Size = new System.Drawing.Size(218, 50);
            this.BtnSetScore.TabIndex = 5;
            this.BtnSetScore.Text = "Set";
            this.BtnSetScore.UseVisualStyleBackColor = true;
            this.BtnSetScore.Click += new System.EventHandler(this.BtnSetScore_Click);
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Location = new System.Drawing.Point(32, 36);
            this.lblSet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(74, 17);
            this.lblSet.TabIndex = 4;
            this.lblSet.Text = "Set Score:\r\n";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblGoalScore);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblPlayerTurn);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.BtnPass);
            this.groupBox4.Controls.Add(this.BtnRoll);
            this.groupBox4.Controls.Add(this.picboxDieTwo);
            this.groupBox4.Controls.Add(this.picboxDieOne);
            this.groupBox4.Location = new System.Drawing.Point(309, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(552, 396);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Game";
            // 
            // lblGoalScore
            // 
            this.lblGoalScore.AutoSize = true;
            this.lblGoalScore.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalScore.Location = new System.Drawing.Point(462, 362);
            this.lblGoalScore.Name = "lblGoalScore";
            this.lblGoalScore.Size = new System.Drawing.Size(65, 23);
            this.lblGoalScore.TabIndex = 7;
            this.lblGoalScore.Text = "label4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(339, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Goal Score:";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.Location = new System.Drawing.Point(141, 362);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(65, 23);
            this.lblPlayerTurn.TabIndex = 5;
            this.lblPlayerTurn.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player Turn:";
            // 
            // BtnPass
            // 
            this.BtnPass.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPass.Location = new System.Drawing.Point(279, 291);
            this.BtnPass.Name = "BtnPass";
            this.BtnPass.Size = new System.Drawing.Size(250, 53);
            this.BtnPass.TabIndex = 3;
            this.BtnPass.Text = "Pass";
            this.BtnPass.UseVisualStyleBackColor = true;
            this.BtnPass.Click += new System.EventHandler(this.BtnPass_Click);
            // 
            // BtnRoll
            // 
            this.BtnRoll.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoll.Location = new System.Drawing.Point(22, 291);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(250, 53);
            this.BtnRoll.TabIndex = 2;
            this.BtnRoll.Text = "Roll";
            this.BtnRoll.UseVisualStyleBackColor = true;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // picboxDieTwo
            // 
            this.picboxDieTwo.BackColor = System.Drawing.Color.White;
            this.picboxDieTwo.Location = new System.Drawing.Point(279, 35);
            this.picboxDieTwo.Name = "picboxDieTwo";
            this.picboxDieTwo.Size = new System.Drawing.Size(250, 250);
            this.picboxDieTwo.TabIndex = 1;
            this.picboxDieTwo.TabStop = false;
            // 
            // picboxDieOne
            // 
            this.picboxDieOne.BackColor = System.Drawing.Color.White;
            this.picboxDieOne.Location = new System.Drawing.Point(22, 35);
            this.picboxDieOne.Name = "picboxDieOne";
            this.picboxDieOne.Size = new System.Drawing.Size(250, 250);
            this.picboxDieOne.TabIndex = 0;
            this.picboxDieOne.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPlayerTwoTotalWins);
            this.groupBox5.Controls.Add(this.txtPlayerOneTotalWins);
            this.groupBox5.Controls.Add(this.txtPlayerTwoCumulativeScore);
            this.groupBox5.Controls.Add(this.txtPlayerOneCumulativeScore);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.listPlayerOneRunningScore);
            this.groupBox5.Controls.Add(this.listPlayerTwoRunningScore);
            this.groupBox5.Location = new System.Drawing.Point(867, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(254, 581);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Score Sheet";
            // 
            // txtPlayerTwoTotalWins
            // 
            this.txtPlayerTwoTotalWins.BackColor = System.Drawing.Color.White;
            this.txtPlayerTwoTotalWins.Location = new System.Drawing.Point(156, 535);
            this.txtPlayerTwoTotalWins.Name = "txtPlayerTwoTotalWins";
            this.txtPlayerTwoTotalWins.ReadOnly = true;
            this.txtPlayerTwoTotalWins.Size = new System.Drawing.Size(76, 22);
            this.txtPlayerTwoTotalWins.TabIndex = 22;
            // 
            // txtPlayerOneTotalWins
            // 
            this.txtPlayerOneTotalWins.BackColor = System.Drawing.Color.White;
            this.txtPlayerOneTotalWins.Location = new System.Drawing.Point(156, 489);
            this.txtPlayerOneTotalWins.Name = "txtPlayerOneTotalWins";
            this.txtPlayerOneTotalWins.ReadOnly = true;
            this.txtPlayerOneTotalWins.Size = new System.Drawing.Size(76, 22);
            this.txtPlayerOneTotalWins.TabIndex = 21;
            // 
            // txtPlayerTwoCumulativeScore
            // 
            this.txtPlayerTwoCumulativeScore.BackColor = System.Drawing.Color.White;
            this.txtPlayerTwoCumulativeScore.Location = new System.Drawing.Point(156, 445);
            this.txtPlayerTwoCumulativeScore.Name = "txtPlayerTwoCumulativeScore";
            this.txtPlayerTwoCumulativeScore.ReadOnly = true;
            this.txtPlayerTwoCumulativeScore.Size = new System.Drawing.Size(76, 22);
            this.txtPlayerTwoCumulativeScore.TabIndex = 20;
            // 
            // txtPlayerOneCumulativeScore
            // 
            this.txtPlayerOneCumulativeScore.BackColor = System.Drawing.Color.White;
            this.txtPlayerOneCumulativeScore.Location = new System.Drawing.Point(156, 406);
            this.txtPlayerOneCumulativeScore.Name = "txtPlayerOneCumulativeScore";
            this.txtPlayerOneCumulativeScore.ReadOnly = true;
            this.txtPlayerOneCumulativeScore.Size = new System.Drawing.Size(76, 22);
            this.txtPlayerOneCumulativeScore.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "Player Two\r\nTotal Wins:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 34);
            this.label8.TabIndex = 17;
            this.label8.Text = "Player One \r\nTotal Wins:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "Player Two\r\nCumulative Score:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Player One \r\nCumulative Score:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Player Two";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Player One";
            // 
            // listPlayerOneRunningScore
            // 
            this.listPlayerOneRunningScore.FormattingEnabled = true;
            this.listPlayerOneRunningScore.ItemHeight = 16;
            this.listPlayerOneRunningScore.Location = new System.Drawing.Point(21, 61);
            this.listPlayerOneRunningScore.Name = "listPlayerOneRunningScore";
            this.listPlayerOneRunningScore.Size = new System.Drawing.Size(58, 324);
            this.listPlayerOneRunningScore.TabIndex = 11;
            // 
            // listPlayerTwoRunningScore
            // 
            this.listPlayerTwoRunningScore.FormattingEnabled = true;
            this.listPlayerTwoRunningScore.ItemHeight = 16;
            this.listPlayerTwoRunningScore.Location = new System.Drawing.Point(158, 61);
            this.listPlayerTwoRunningScore.Name = "listPlayerTwoRunningScore";
            this.listPlayerTwoRunningScore.Size = new System.Drawing.Size(58, 324);
            this.listPlayerTwoRunningScore.TabIndex = 12;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 605);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picboxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameScreen";
            this.Text = "Sixes And Sevens";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDieTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDieOne)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnPlayerVsPlayerSetup;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Button BtnPlayerVsCPUSetup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSetPlayerNames;
        private System.Windows.Forms.TextBox txtPlayerTwoName;
        private System.Windows.Forms.TextBox txtPlayerOneName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtScoreGoal;
        private System.Windows.Forms.Button BtnSetScore;
        private System.Windows.Forms.Label lblSet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnPass;
        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.PictureBox picboxDieTwo;
        private System.Windows.Forms.PictureBox picboxDieOne;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listPlayerOneRunningScore;
        private System.Windows.Forms.ListBox listPlayerTwoRunningScore;
        private System.Windows.Forms.TextBox txtPlayerTwoTotalWins;
        private System.Windows.Forms.TextBox txtPlayerOneTotalWins;
        private System.Windows.Forms.TextBox txtPlayerTwoCumulativeScore;
        private System.Windows.Forms.TextBox txtPlayerOneCumulativeScore;
        private System.Windows.Forms.Label lblGoalScore;
        private System.Windows.Forms.Label label11;
    }
}

