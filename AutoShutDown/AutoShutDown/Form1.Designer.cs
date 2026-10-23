namespace AutoShutDown
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
            components = new System.ComponentModel.Container();
            label_BigTittle = new Label();
            button_Start = new Button();
            button_Reset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox_action = new ComboBox();
            textBox_Time = new TextBox();
            comboBox_unit = new ComboBox();
            label_action = new Label();
            label_Time = new Label();
            label_unit = new Label();
            label_RT = new Label();
            label_Timer = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label_BigTittle
            // 
            label_BigTittle.AutoSize = true;
            label_BigTittle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_BigTittle.Location = new Point(172, 36);
            label_BigTittle.Name = "label_BigTittle";
            label_BigTittle.Size = new Size(470, 46);
            label_BigTittle.TabIndex = 0;
            label_BigTittle.Text = "Automatic Action Computer";
            // 
            // button_Start
            // 
            button_Start.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Start.Location = new Point(402, 322);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(195, 50);
            button_Start.TabIndex = 1;
            button_Start.Text = "START";
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += button_Start_Click;
            // 
            // button_Reset
            // 
            button_Reset.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Reset.Location = new Point(616, 322);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(122, 50);
            button_Reset.TabIndex = 2;
            button_Reset.Text = "RESET";
            button_Reset.UseVisualStyleBackColor = true;
            button_Reset.Click += button_Reset_Click;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // comboBox_action
            // 
            comboBox_action.FormattingEnabled = true;
            comboBox_action.Location = new Point(127, 153);
            comboBox_action.Name = "comboBox_action";
            comboBox_action.Size = new Size(161, 28);
            comboBox_action.TabIndex = 4;
            // 
            // textBox_Time
            // 
            textBox_Time.Location = new Point(127, 217);
            textBox_Time.Name = "textBox_Time";
            textBox_Time.Size = new Size(164, 27);
            textBox_Time.TabIndex = 5;
            textBox_Time.KeyPress += textBox_Time_KeyPress;
            // 
            // comboBox_unit
            // 
            comboBox_unit.FormattingEnabled = true;
            comboBox_unit.Location = new Point(127, 285);
            comboBox_unit.Name = "comboBox_unit";
            comboBox_unit.Size = new Size(113, 28);
            comboBox_unit.TabIndex = 6;
            // 
            // label_action
            // 
            label_action.AutoSize = true;
            label_action.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_action.Location = new Point(49, 153);
            label_action.Name = "label_action";
            label_action.Size = new Size(70, 28);
            label_action.TabIndex = 7;
            label_action.Text = "Action";
            // 
            // label_Time
            // 
            label_Time.AutoSize = true;
            label_Time.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Time.Location = new Point(49, 216);
            label_Time.Name = "label_Time";
            label_Time.Size = new Size(57, 28);
            label_Time.TabIndex = 8;
            label_Time.Text = "Time";
            // 
            // label_unit
            // 
            label_unit.AutoSize = true;
            label_unit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_unit.Location = new Point(49, 285);
            label_unit.Name = "label_unit";
            label_unit.Size = new Size(59, 28);
            label_unit.TabIndex = 10;
            label_unit.Text = "Units";
            // 
            // label_RT
            // 
            label_RT.AutoSize = true;
            label_RT.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_RT.Location = new Point(474, 134);
            label_RT.Name = "label_RT";
            label_RT.Size = new Size(186, 31);
            label_RT.TabIndex = 11;
            label_RT.Text = "Remaining Time:";
            // 
            // label_Timer
            // 
            label_Timer.AutoSize = true;
            label_Timer.Font = new Font("Microsoft Tai Le", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Timer.Location = new Point(402, 194);
            label_Timer.Name = "label_Timer";
            label_Timer.Size = new Size(336, 103);
            label_Timer.TabIndex = 12;
            label_Timer.Text = "00:00:00";
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Timer);
            Controls.Add(label_RT);
            Controls.Add(label_unit);
            Controls.Add(label_Time);
            Controls.Add(label_action);
            Controls.Add(comboBox_unit);
            Controls.Add(textBox_Time);
            Controls.Add(comboBox_action);
            Controls.Add(button_Reset);
            Controls.Add(button_Start);
            Controls.Add(label_BigTittle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "00:00:00";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_BigTittle;
        private Button button_Start;
        private Button button_Reset;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox_action;
        private TextBox textBox_Time;
        private ComboBox comboBox_unit;
        private Label label_action;
        private Label label_Time;
        private Label label_unit;
        private Label label_RT;
        private Label label_Timer;
        private System.Windows.Forms.Timer timer2;
    }
}
