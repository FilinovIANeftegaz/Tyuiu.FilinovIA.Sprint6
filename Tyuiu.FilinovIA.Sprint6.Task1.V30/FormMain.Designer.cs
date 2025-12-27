namespace Tyuiu.FilinovIA.Sprint6.Task1.V30
{
    partial class FormMain_KRA
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
            groupBoxTask_KRA = new GroupBox();
            textBoxResult_KRA = new TextBox();
            groupBoxText_KRA = new GroupBox();
            buttonDone_KRA = new Button();
            buttonHelp_KRA = new Button();
            textBoxStopStep_KRA = new TextBox();
            textBoxStartStep_KRA = new TextBox();
            groupBoxInput_KRA = new GroupBox();
            groupBoxStartStop_KRA = new GroupBox();
            groupBoxInput_KRA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KRA
            // 
            groupBoxTask_KRA.Location = new Point(12, 12);
            groupBoxTask_KRA.Name = "groupBoxTask_KRA";
            groupBoxTask_KRA.Size = new Size(479, 313);
            groupBoxTask_KRA.TabIndex = 0;
            groupBoxTask_KRA.TabStop = false;
            groupBoxTask_KRA.Text = "Условие:                                                                               Протабулировать функцию по формуле на диапазоне [-5;5].Результаты вывести в виде таблицы.";
            groupBoxTask_KRA.Enter += groupBoxTask_Enter;
            // 
            // textBoxResult_KRA
            // 
            textBoxResult_KRA.Font = new Font("Consolas", 10F);
            textBoxResult_KRA.Location = new Point(513, 66);
            textBoxResult_KRA.Multiline = true;
            textBoxResult_KRA.Name = "textBoxResult_KRA";
            textBoxResult_KRA.ReadOnly = true;
            textBoxResult_KRA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KRA.Size = new Size(257, 362);
            textBoxResult_KRA.TabIndex = 1;
            textBoxResult_KRA.TextChanged += textBoxResult_TextChanged;
            // 
            // groupBoxText_KRA
            // 
            groupBoxText_KRA.Location = new Point(513, 12);
            groupBoxText_KRA.Name = "groupBoxText_KRA";
            groupBoxText_KRA.Size = new Size(257, 416);
            groupBoxText_KRA.TabIndex = 2;
            groupBoxText_KRA.TabStop = false;
            groupBoxText_KRA.Text = "Вывод данных.                    Результат.";
            // 
            // buttonDone_KRA
            // 
            buttonDone_KRA.BackColor = Color.ForestGreen;
            buttonDone_KRA.Location = new Point(375, 344);
            buttonDone_KRA.Name = "buttonDone_KRA";
            buttonDone_KRA.Size = new Size(116, 84);
            buttonDone_KRA.TabIndex = 3;
            buttonDone_KRA.Text = "Выполнить";
            buttonDone_KRA.UseVisualStyleBackColor = false;
            buttonDone_KRA.Click += buttonDone_Click;
            // 
            // buttonHelp_KRA
            // 
            buttonHelp_KRA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KRA.Location = new Point(259, 344);
            buttonHelp_KRA.Name = "buttonHelp_KRA";
            buttonHelp_KRA.Size = new Size(110, 84);
            buttonHelp_KRA.TabIndex = 0;
            buttonHelp_KRA.Text = "Справка";
            buttonHelp_KRA.UseVisualStyleBackColor = false;
            buttonHelp_KRA.Click += buttonHelp_Click;
            // 
            // textBoxStopStep_KRA
            // 
            textBoxStopStep_KRA.Location = new Point(144, 401);
            textBoxStopStep_KRA.Name = "textBoxStopStep_KRA";
            textBoxStopStep_KRA.Size = new Size(109, 27);
            textBoxStopStep_KRA.TabIndex = 4;
            // 
            // textBoxStartStep_KRA
            // 
            textBoxStartStep_KRA.Location = new Point(12, 401);
            textBoxStartStep_KRA.Name = "textBoxStartStep_KRA";
            textBoxStartStep_KRA.Size = new Size(110, 27);
            textBoxStartStep_KRA.TabIndex = 5;
            // 
            // groupBoxInput_KRA
            // 
            groupBoxInput_KRA.Controls.Add(groupBoxStartStop_KRA);
            groupBoxInput_KRA.Location = new Point(12, 344);
            groupBoxInput_KRA.Name = "groupBoxInput_KRA";
            groupBoxInput_KRA.Size = new Size(241, 103);
            groupBoxInput_KRA.TabIndex = 6;
            groupBoxInput_KRA.TabStop = false;
            groupBoxInput_KRA.Text = "Ввод данных";
            groupBoxInput_KRA.Enter += groupBoxInput_Enter;
            // 
            // groupBoxStartStop_KRA
            // 
            groupBoxStartStop_KRA.Location = new Point(-8, 37);
            groupBoxStartStop_KRA.Name = "groupBoxStartStop_KRA";
            groupBoxStartStop_KRA.Size = new Size(249, 66);
            groupBoxStartStop_KRA.TabIndex = 0;
            groupBoxStartStop_KRA.TabStop = false;
            groupBoxStartStop_KRA.Text = "Старт шага              Конец шага";
            // 
            // FormMain_KRA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxStartStep_KRA);
            Controls.Add(textBoxStopStep_KRA);
            Controls.Add(buttonHelp_KRA);
            Controls.Add(buttonDone_KRA);
            Controls.Add(textBoxResult_KRA);
            Controls.Add(groupBoxText_KRA);
            Controls.Add(groupBoxTask_KRA);
            Controls.Add(groupBoxInput_KRA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_KRA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 30 | Козырев Р.А";
            Load += Form1_Load;
            groupBoxInput_KRA.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask_KRA;
        private TextBox textBoxResult_KRA;
        private GroupBox groupBoxText_KRA;
        private Button buttonDone_KRA;
        private Button buttonHelp_KRA;
        private TextBox textBoxStopStep_KRA;
        private TextBox textBoxStartStep_KRA;
        private GroupBox groupBoxInput_KRA;
        private GroupBox groupBoxStartStop_KRA;
    }
}
