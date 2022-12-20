namespace TicTacToeGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.tmrComputer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(18, 18);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(123, 105);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(175, 18);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(123, 105);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(342, 18);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(123, 105);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(18, 146);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(123, 105);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(175, 146);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(123, 105);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(342, 146);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(123, 105);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(18, 276);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(123, 105);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(175, 276);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(123, 105);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.ClickButton);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(342, 276);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(123, 105);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.ClickButton);
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.Location = new System.Drawing.Point(134, 412);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(180, 63);
            this.btnRestartGame.TabIndex = 9;
            this.btnRestartGame.Text = "Restart";
            this.btnRestartGame.UseVisualStyleBackColor = true;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // tmrComputer
            // 
            this.tmrComputer.Interval = 1000;
            this.tmrComputer.Tick += new System.EventHandler(this.tmrComputer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 499);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnRestartGame;
        private System.Windows.Forms.Timer tmrComputer;
    }
}