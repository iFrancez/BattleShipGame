﻿namespace BattleShipGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.txtEnemy = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.enemyMove = new System.Windows.Forms.Label();
            this.txtHelp = new System.Windows.Forms.Label();
            this.EnemyLocationListBox = new System.Windows.Forms.ComboBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.EnemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPlayer.ForeColor = System.Drawing.Color.White;
            this.txtPlayer.Location = new System.Drawing.Point(235, 84);
            this.txtPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(38, 26);
            this.txtPlayer.TabIndex = 0;
            this.txtPlayer.Text = "00";
            // 
            // txtEnemy
            // 
            this.txtEnemy.AutoSize = true;
            this.txtEnemy.BackColor = System.Drawing.Color.Transparent;
            this.txtEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEnemy.ForeColor = System.Drawing.Color.White;
            this.txtEnemy.Location = new System.Drawing.Point(610, 84);
            this.txtEnemy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEnemy.Name = "txtEnemy";
            this.txtEnemy.Size = new System.Drawing.Size(38, 26);
            this.txtEnemy.TabIndex = 0;
            this.txtEnemy.Text = "00";
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.BackColor = System.Drawing.Color.Transparent;
            this.txtRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRounds.ForeColor = System.Drawing.Color.White;
            this.txtRounds.Location = new System.Drawing.Point(303, 84);
            this.txtRounds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(121, 26);
            this.txtRounds.TabIndex = 0;
            this.txtRounds.Text = "Round: 10";
            this.txtRounds.Click += new System.EventHandler(this.txtRounds_Click);
            // 
            // enemyMove
            // 
            this.enemyMove.AutoSize = true;
            this.enemyMove.BackColor = System.Drawing.Color.Transparent;
            this.enemyMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.enemyMove.ForeColor = System.Drawing.Color.White;
            this.enemyMove.Location = new System.Drawing.Point(616, 28);
            this.enemyMove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemyMove.Name = "enemyMove";
            this.enemyMove.Size = new System.Drawing.Size(41, 26);
            this.enemyMove.TabIndex = 0;
            this.enemyMove.Text = "A1";
            // 
            // txtHelp
            // 
            this.txtHelp.AutoSize = true;
            this.txtHelp.BackColor = System.Drawing.Color.Transparent;
            this.txtHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtHelp.Location = new System.Drawing.Point(11, 455);
            this.txtHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(445, 20);
            this.txtHelp.TabIndex = 0;
            this.txtHelp.Text = "1) Nhấp vào ba vị trí con thuyền khác nhau để bắt đầu!";
            // 
            // EnemyLocationListBox
            // 
            this.EnemyLocationListBox.BackColor = System.Drawing.Color.PaleGreen;
            this.EnemyLocationListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnemyLocationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.EnemyLocationListBox.FormattingEnabled = true;
            this.EnemyLocationListBox.Location = new System.Drawing.Point(124, 21);
            this.EnemyLocationListBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnemyLocationListBox.Name = "EnemyLocationListBox";
            this.EnemyLocationListBox.Size = new System.Drawing.Size(68, 30);
            this.EnemyLocationListBox.TabIndex = 1;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAttack.Location = new System.Drawing.Point(203, 19);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(74, 35);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.AttackButtonEvent);
            // 
            // w1
            // 
            this.w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.w1.Location = new System.Drawing.Point(70, 185);
            this.w1.Margin = new System.Windows.Forms.Padding(2);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(58, 58);
            this.w1.TabIndex = 2;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            this.w1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // w2
            // 
            this.w2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.w2.Location = new System.Drawing.Point(133, 185);
            this.w2.Margin = new System.Windows.Forms.Padding(2);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(58, 58);
            this.w2.TabIndex = 2;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            this.w2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // w3
            // 
            this.w3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.w3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.w3.Location = new System.Drawing.Point(197, 185);
            this.w3.Margin = new System.Windows.Forms.Padding(2);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(58, 58);
            this.w3.TabIndex = 2;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            this.w3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // w4
            // 
            this.w4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.w4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.w4.Location = new System.Drawing.Point(261, 185);
            this.w4.Margin = new System.Windows.Forms.Padding(2);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(58, 58);
            this.w4.TabIndex = 2;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            this.w4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x1
            // 
            this.x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.x1.Location = new System.Drawing.Point(70, 249);
            this.x1.Margin = new System.Windows.Forms.Padding(2);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(58, 58);
            this.x1.TabIndex = 2;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x2
            // 
            this.x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.x2.Location = new System.Drawing.Point(133, 249);
            this.x2.Margin = new System.Windows.Forms.Padding(2);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(58, 58);
            this.x2.TabIndex = 2;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x3
            // 
            this.x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.x3.Location = new System.Drawing.Point(197, 249);
            this.x3.Margin = new System.Windows.Forms.Padding(2);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(58, 58);
            this.x3.TabIndex = 2;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // x4
            // 
            this.x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.x4.Location = new System.Drawing.Point(261, 249);
            this.x4.Margin = new System.Windows.Forms.Padding(2);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(58, 58);
            this.x4.TabIndex = 2;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y1
            // 
            this.y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.y1.Location = new System.Drawing.Point(70, 313);
            this.y1.Margin = new System.Windows.Forms.Padding(2);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(58, 58);
            this.y1.TabIndex = 2;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y2
            // 
            this.y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.y2.Location = new System.Drawing.Point(133, 313);
            this.y2.Margin = new System.Windows.Forms.Padding(2);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(58, 58);
            this.y2.TabIndex = 2;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y3
            // 
            this.y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.y3.Location = new System.Drawing.Point(197, 313);
            this.y3.Margin = new System.Windows.Forms.Padding(2);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(58, 58);
            this.y3.TabIndex = 2;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // y4
            // 
            this.y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.y4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.y4.Location = new System.Drawing.Point(261, 313);
            this.y4.Margin = new System.Windows.Forms.Padding(2);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(58, 58);
            this.y4.TabIndex = 2;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z1
            // 
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.z1.Location = new System.Drawing.Point(70, 377);
            this.z1.Margin = new System.Windows.Forms.Padding(2);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(58, 58);
            this.z1.TabIndex = 2;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            this.z1.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z2
            // 
            this.z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.z2.Location = new System.Drawing.Point(133, 377);
            this.z2.Margin = new System.Windows.Forms.Padding(2);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(58, 58);
            this.z2.TabIndex = 2;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z3
            // 
            this.z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.z3.Location = new System.Drawing.Point(197, 377);
            this.z3.Margin = new System.Windows.Forms.Padding(2);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(58, 58);
            this.z3.TabIndex = 2;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // z4
            // 
            this.z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.z4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.z4.Location = new System.Drawing.Point(261, 377);
            this.z4.Margin = new System.Windows.Forms.Padding(2);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(58, 58);
            this.z4.TabIndex = 2;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            this.z4.Click += new System.EventHandler(this.PlayerPositionButtonsEvent);
            // 
            // a1
            // 
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.a1.Location = new System.Drawing.Point(414, 186);
            this.a1.Margin = new System.Windows.Forms.Padding(2);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(58, 58);
            this.a1.TabIndex = 2;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.a2.Location = new System.Drawing.Point(478, 186);
            this.a2.Margin = new System.Windows.Forms.Padding(2);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(58, 58);
            this.a2.TabIndex = 2;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b1.Location = new System.Drawing.Point(414, 250);
            this.b1.Margin = new System.Windows.Forms.Padding(2);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(58, 58);
            this.b1.TabIndex = 2;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.a3.Location = new System.Drawing.Point(541, 186);
            this.a3.Margin = new System.Windows.Forms.Padding(2);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(58, 58);
            this.a3.TabIndex = 2;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.c1.Location = new System.Drawing.Point(414, 314);
            this.c1.Margin = new System.Windows.Forms.Padding(2);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(58, 58);
            this.c1.TabIndex = 2;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b2.Location = new System.Drawing.Point(478, 250);
            this.b2.Margin = new System.Windows.Forms.Padding(2);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(58, 58);
            this.b2.TabIndex = 2;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.d1.Location = new System.Drawing.Point(414, 378);
            this.d1.Margin = new System.Windows.Forms.Padding(2);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(58, 58);
            this.d1.TabIndex = 2;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.a4.Location = new System.Drawing.Point(605, 186);
            this.a4.Margin = new System.Windows.Forms.Padding(2);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(58, 58);
            this.a4.TabIndex = 2;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.c2.Location = new System.Drawing.Point(478, 314);
            this.c2.Margin = new System.Windows.Forms.Padding(2);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(58, 58);
            this.c2.TabIndex = 2;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b3.Location = new System.Drawing.Point(541, 250);
            this.b3.Margin = new System.Windows.Forms.Padding(2);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(58, 58);
            this.b3.TabIndex = 2;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.d2.Location = new System.Drawing.Point(478, 378);
            this.d2.Margin = new System.Windows.Forms.Padding(2);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(58, 58);
            this.d2.TabIndex = 2;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b4.Location = new System.Drawing.Point(605, 250);
            this.b4.Margin = new System.Windows.Forms.Padding(2);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(58, 58);
            this.b4.TabIndex = 2;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.c3.Location = new System.Drawing.Point(541, 314);
            this.c3.Margin = new System.Windows.Forms.Padding(2);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(58, 58);
            this.c3.TabIndex = 2;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.c4.Location = new System.Drawing.Point(605, 314);
            this.c4.Margin = new System.Windows.Forms.Padding(2);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(58, 58);
            this.c4.TabIndex = 2;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.d3.Location = new System.Drawing.Point(541, 378);
            this.d3.Margin = new System.Windows.Forms.Padding(2);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(58, 58);
            this.d3.TabIndex = 2;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.d4.Location = new System.Drawing.Point(605, 378);
            this.d4.Margin = new System.Windows.Forms.Padding(2);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(58, 58);
            this.d4.TabIndex = 2;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // EnemyPlayTimer
            // 
            this.EnemyPlayTimer.Interval = 1000;
            this.EnemyPlayTimer.Tick += new System.EventHandler(this.EnemyPlayTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleShipGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 486);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.EnemyLocationListBox);
            this.Controls.Add(this.txtHelp);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.enemyMove);
            this.Controls.Add(this.txtEnemy);
            this.Controls.Add(this.txtPlayer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "BattleShip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label txtEnemy;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Label enemyMove;
        private System.Windows.Forms.Label txtHelp;
        private System.Windows.Forms.ComboBox EnemyLocationListBox;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Timer EnemyPlayTimer;
    }
}

