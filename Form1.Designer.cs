namespace tictactoeGame
{
    partial class TicTacToe
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AITimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 158);
            this.button1.TabIndex = 0;
            this.button1.Tag = "play";
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.buttonClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(368, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 158);
            this.button2.TabIndex = 1;
            this.button2.Tag = "play";
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.buttonClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(622, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 158);
            this.button3.TabIndex = 2;
            this.button3.Tag = "play";
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.buttonClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(109, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 158);
            this.button4.TabIndex = 3;
            this.button4.Tag = "play";
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.buttonClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(368, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 158);
            this.button5.TabIndex = 4;
            this.button5.Tag = "play";
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.buttonClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(622, 366);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 158);
            this.button6.TabIndex = 5;
            this.button6.Tag = "play";
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.buttonClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(109, 575);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 158);
            this.button7.TabIndex = 6;
            this.button7.Tag = "play";
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.UseWaitCursor = true;
            this.button7.Click += new System.EventHandler(this.buttonClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(368, 575);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(166, 158);
            this.button8.TabIndex = 7;
            this.button8.Tag = "play";
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.UseWaitCursor = true;
            this.button8.Click += new System.EventHandler(this.buttonClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(622, 575);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(166, 158);
            this.button9.TabIndex = 8;
            this.button9.Tag = "play";
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.UseWaitCursor = true;
            this.button9.Click += new System.EventHandler(this.buttonClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1057, 180);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(239, 95);
            this.button10.TabIndex = 9;
            this.button10.Text = "Reset";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.UseWaitCursor = true;
            this.button10.Click += new System.EventHandler(this.resetGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 840);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // AITimer
            // 
            this.AITimer.Interval = 1000;
            this.AITimer.Tick += new System.EventHandler(this.playAI);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 972);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer AITimer;
    }
}

