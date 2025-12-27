namespace Tyuiu.FilinovIA.Sprint6.Task4.V12
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBoxStartStep_KRA = new TextBox();
            textBoxStopStep_KRA = new TextBox();
            buttonHelp_KRA = new Button();
            buttonDone_KRA = new Button();
            groupBoxText_KRA = new GroupBox();
            textBoxAnswer_KRA = new TextBox();
            groupBoxTask_KRA = new GroupBox();
            groupBoxInput_KRA = new GroupBox();
            groupBoxStartStop_KRA = new GroupBox();
            chartFunction_KRA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSave_KRA = new Button();
            panelUP_KRA = new Panel();
            panelLeft_KRA = new Panel();
            splitter1 = new Splitter();
            groupBoxText_KRA.SuspendLayout();
            groupBoxInput_KRA.SuspendLayout();
            groupBoxStartStop_KRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KRA).BeginInit();
            SuspendLayout();
            // 
            // textBoxStartStep_KRA
            // 
            textBoxStartStep_KRA.Location = new Point(8, 20);
            textBoxStartStep_KRA.Name = "textBoxStartStep_KRA";
            textBoxStartStep_KRA.Size = new Size(110, 27);
            textBoxStartStep_KRA.TabIndex = 20;
            // 
            // textBoxStopStep_KRA
            // 
            textBoxStopStep_KRA.Location = new Point(589, 69);
            textBoxStopStep_KRA.Name = "textBoxStopStep_KRA";
            textBoxStopStep_KRA.Size = new Size(109, 27);
            textBoxStopStep_KRA.TabIndex = 19;
            // 
            // buttonHelp_KRA
            // 
            buttonHelp_KRA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KRA.Cursor = Cursors.Hand;
            buttonHelp_KRA.Location = new Point(1025, 12);
            buttonHelp_KRA.Name = "buttonHelp_KRA";
            buttonHelp_KRA.Size = new Size(110, 84);
            buttonHelp_KRA.TabIndex = 15;
            buttonHelp_KRA.Text = "Справка";
            buttonHelp_KRA.UseVisualStyleBackColor = false;
            buttonHelp_KRA.Click += buttonHelp_KRA_Click;
            // 
            // buttonDone_KRA
            // 
            buttonDone_KRA.BackColor = Color.ForestGreen;
            buttonDone_KRA.Cursor = Cursors.Hand;
            buttonDone_KRA.Location = new Point(741, 12);
            buttonDone_KRA.Name = "buttonDone_KRA";
            buttonDone_KRA.Size = new Size(116, 84);
            buttonDone_KRA.TabIndex = 18;
            buttonDone_KRA.Text = "Выполнить";
            buttonDone_KRA.UseVisualStyleBackColor = false;
            buttonDone_KRA.Click += buttonDone_KRA_Click;
            // 
            // groupBoxText_KRA
            // 
            groupBoxText_KRA.Controls.Add(textBoxAnswer_KRA);
            groupBoxText_KRA.Location = new Point(15, 124);
            groupBoxText_KRA.Name = "groupBoxText_KRA";
            groupBoxText_KRA.Size = new Size(390, 502);
            groupBoxText_KRA.TabIndex = 17;
            groupBoxText_KRA.TabStop = false;
            groupBoxText_KRA.Text = "Вывод данных.  ";
            // 
            // textBoxAnswer_KRA
            // 
            textBoxAnswer_KRA.Dock = DockStyle.Fill;
            textBoxAnswer_KRA.Location = new Point(3, 23);
            textBoxAnswer_KRA.Multiline = true;
            textBoxAnswer_KRA.Name = "textBoxAnswer_KRA";
            textBoxAnswer_KRA.ReadOnly = true;
            textBoxAnswer_KRA.Size = new Size(384, 476);
            textBoxAnswer_KRA.TabIndex = 16;
            // 
            // groupBoxTask_KRA
            // 
            groupBoxTask_KRA.Location = new Point(15, 12);
            groupBoxTask_KRA.Name = "groupBoxTask_KRA";
            groupBoxTask_KRA.Size = new Size(390, 106);
            groupBoxTask_KRA.TabIndex = 16;
            groupBoxTask_KRA.TabStop = false;
            groupBoxTask_KRA.Text = "Условие:                                                                               Протабулировать функцию по формуле на диапазоне [-5;5].Результаты вывести в виде таблицы.";
            // 
            // groupBoxInput_KRA
            // 
            groupBoxInput_KRA.Controls.Add(groupBoxStartStop_KRA);
            groupBoxInput_KRA.Location = new Point(427, 12);
            groupBoxInput_KRA.Name = "groupBoxInput_KRA";
            groupBoxInput_KRA.Size = new Size(285, 113);
            groupBoxInput_KRA.TabIndex = 21;
            groupBoxInput_KRA.TabStop = false;
            groupBoxInput_KRA.Text = "Ввод данных";
            // 
            // groupBoxStartStop_KRA
            // 
            groupBoxStartStop_KRA.Controls.Add(textBoxStartStep_KRA);
            groupBoxStartStop_KRA.Location = new Point(-8, 38);
            groupBoxStartStop_KRA.Name = "groupBoxStartStop_KRA";
            groupBoxStartStop_KRA.Size = new Size(293, 72);
            groupBoxStartStop_KRA.TabIndex = 0;
            groupBoxStartStop_KRA.TabStop = false;
            groupBoxStartStop_KRA.Text = "Старт шага                     Конец шага";
            // 
            // chartFunction_KRA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KRA.ChartAreas.Add(chartArea1);
            chartFunction_KRA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_KRA.Legends.Add(legend1);
            chartFunction_KRA.Location = new Point(440, 125);
            chartFunction_KRA.Name = "chartFunction_KRA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KRA.Series.Add(series1);
            chartFunction_KRA.Size = new Size(762, 528);
            chartFunction_KRA.TabIndex = 22;
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_KRA.Titles.Add(title1);
            // 
            // buttonSave_KRA
            // 
            buttonSave_KRA.BackColor = Color.Blue;
            buttonSave_KRA.Cursor = Cursors.Hand;
            buttonSave_KRA.Location = new Point(880, 12);
            buttonSave_KRA.Name = "buttonSave_KRA";
            buttonSave_KRA.Size = new Size(125, 84);
            buttonSave_KRA.TabIndex = 23;
            buttonSave_KRA.Text = "Сохранить";
            buttonSave_KRA.UseVisualStyleBackColor = false;
            buttonSave_KRA.Click += buttonSave_KRA_Click;
            // 
            // panelUP_KRA
            // 
            panelUP_KRA.Dock = DockStyle.Top;
            panelUP_KRA.Location = new Point(0, 0);
            panelUP_KRA.Name = "panelUP_KRA";
            panelUP_KRA.Size = new Size(1202, 125);
            panelUP_KRA.TabIndex = 24;
            // 
            // panelLeft_KRA
            // 
            panelLeft_KRA.Dock = DockStyle.Left;
            panelLeft_KRA.Location = new Point(0, 125);
            panelLeft_KRA.Name = "panelLeft_KRA";
            panelLeft_KRA.Size = new Size(440, 528);
            panelLeft_KRA.TabIndex = 25;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(440, 125);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 528);
            splitter1.TabIndex = 26;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 653);
            Controls.Add(splitter1);
            Controls.Add(buttonSave_KRA);
            Controls.Add(groupBoxText_KRA);
            Controls.Add(chartFunction_KRA);
            Controls.Add(textBoxStopStep_KRA);
            Controls.Add(buttonHelp_KRA);
            Controls.Add(buttonDone_KRA);
            Controls.Add(groupBoxTask_KRA);
            Controls.Add(groupBoxInput_KRA);
            Controls.Add(panelLeft_KRA);
            Controls.Add(panelUP_KRA);
            MinimumSize = new Size(1220, 700);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 12 | Козырев Р.А";
            groupBoxText_KRA.ResumeLayout(false);
            groupBoxText_KRA.PerformLayout();
            groupBoxInput_KRA.ResumeLayout(false);
            groupBoxStartStop_KRA.ResumeLayout(false);
            groupBoxStartStop_KRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KRA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStartStep_KRA;
        private TextBox textBoxStopStep_KRA;
        private Button buttonHelp_KRA;
        private Button buttonDone_KRA;
        private GroupBox groupBoxText_KRA;
        private GroupBox groupBoxTask_KRA;
        private GroupBox groupBoxInput_KRA;
        private GroupBox groupBoxStartStop_KRA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRA;
        private Button buttonSave_KRA;
        private TextBox textBoxAnswer_KRA;
        private Panel panelUP_KRA;
        private Panel panelLeft_KRA;
        private Splitter splitter1;
    }
}
