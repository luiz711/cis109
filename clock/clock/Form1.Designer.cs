namespace clock
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
            this.HourMinuteLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.WeekDayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HourMinuteLabel
            // 
            this.HourMinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourMinuteLabel.ForeColor = System.Drawing.Color.White;
            this.HourMinuteLabel.Location = new System.Drawing.Point(12, 32);
            this.HourMinuteLabel.Name = "HourMinuteLabel";
            this.HourMinuteLabel.Size = new System.Drawing.Size(256, 85);
            this.HourMinuteLabel.TabIndex = 0;
            this.HourMinuteLabel.Text = "19:25";
            // 
            // SecondLabel
            // 
            this.SecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondLabel.ForeColor = System.Drawing.Color.White;
            this.SecondLabel.Location = new System.Drawing.Point(222, 32);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(108, 85);
            this.SecondLabel.TabIndex = 1;
            this.SecondLabel.Text = "47";
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(12, 117);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(591, 85);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "jan 03 2017";
            // 
            // WeekDayLabel
            // 
            this.WeekDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekDayLabel.ForeColor = System.Drawing.Color.White;
            this.WeekDayLabel.Location = new System.Drawing.Point(12, 213);
            this.WeekDayLabel.Name = "WeekDayLabel";
            this.WeekDayLabel.Size = new System.Drawing.Size(415, 85);
            this.WeekDayLabel.TabIndex = 3;
            this.WeekDayLabel.Text = "Tuesday";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.WeekDayLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.HourMinuteLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HourMinuteLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label WeekDayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

