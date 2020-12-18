namespace DIGITAL_CLOCK_0548
{
    partial class digital_clock
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
            this.timer_tick = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.color_btn = new System.Windows.Forms.Button();
            this.alarmstart_btn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.startstp_btn = new System.Windows.Forms.Button();
            this.button_resetstpwatch = new System.Windows.Forms.Button();
            this.button_pausebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer_tick
            // 
            this.timer_tick.BackColor = System.Drawing.Color.Black;
            this.timer_tick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timer_tick.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_tick.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timer_tick.Location = new System.Drawing.Point(2, 55);
            this.timer_tick.Name = "timer_tick";
            this.timer_tick.Size = new System.Drawing.Size(177, 40);
            this.timer_tick.TabIndex = 0;
            this.timer_tick.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(2, 358);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(118, 23);
            this.color_btn.TabIndex = 1;
            this.color_btn.Text = "CHANGE COLOR";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // alarmstart_btn
            // 
            this.alarmstart_btn.Location = new System.Drawing.Point(326, 116);
            this.alarmstart_btn.Name = "alarmstart_btn";
            this.alarmstart_btn.Size = new System.Drawing.Size(75, 23);
            this.alarmstart_btn.TabIndex = 2;
            this.alarmstart_btn.Text = "start alarm";
            this.alarmstart_btn.UseVisualStyleBackColor = true;
            this.alarmstart_btn.Click += new System.EventHandler(this.alarm_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "stop alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_status
            // 
            this.label_status.BackColor = System.Drawing.Color.DimGray;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_status.Location = new System.Drawing.Point(342, 72);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(156, 23);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "status";
            // 
            // startstp_btn
            // 
            this.startstp_btn.Location = new System.Drawing.Point(2, 263);
            this.startstp_btn.Name = "startstp_btn";
            this.startstp_btn.Size = new System.Drawing.Size(97, 23);
            this.startstp_btn.TabIndex = 6;
            this.startstp_btn.Text = "start stpwatch";
            this.startstp_btn.UseVisualStyleBackColor = true;
            this.startstp_btn.Click += new System.EventHandler(this.startstp_btn_Click);
            // 
            // button_resetstpwatch
            // 
            this.button_resetstpwatch.Location = new System.Drawing.Point(265, 263);
            this.button_resetstpwatch.Name = "button_resetstpwatch";
            this.button_resetstpwatch.Size = new System.Drawing.Size(95, 23);
            this.button_resetstpwatch.TabIndex = 7;
            this.button_resetstpwatch.Text = "reset stpwatch";
            this.button_resetstpwatch.UseVisualStyleBackColor = true;
            this.button_resetstpwatch.Click += new System.EventHandler(this.button_resetstpwatch_Click);
            // 
            // button_pausebtn
            // 
            this.button_pausebtn.Location = new System.Drawing.Point(124, 263);
            this.button_pausebtn.Name = "button_pausebtn";
            this.button_pausebtn.Size = new System.Drawing.Size(95, 23);
            this.button_pausebtn.TabIndex = 8;
            this.button_pausebtn.Text = "pause stpwatch";
            this.button_pausebtn.UseVisualStyleBackColor = true;
            this.button_pausebtn.Click += new System.EventHandler(this.button_pausebtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(51, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "00:00:00.000";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "STOPWATCH";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "DIGITAL CLOCK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "ALARM";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // digital_clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(499, 383);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_pausebtn);
            this.Controls.Add(this.button_resetstpwatch);
            this.Controls.Add(this.startstp_btn);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.alarmstart_btn);
            this.Controls.Add(this.color_btn);
            this.Controls.Add(this.timer_tick);
            this.Name = "digital_clock";
            this.Text = "DIGITAL CLOCK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timer_tick;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button alarmstart_btn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button startstp_btn;
        private System.Windows.Forms.Button button_resetstpwatch;
        private System.Windows.Forms.Button button_pausebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

