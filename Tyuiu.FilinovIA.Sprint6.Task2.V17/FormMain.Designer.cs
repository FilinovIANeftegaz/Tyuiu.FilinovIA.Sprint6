namespace Tyuiu.FilinovIA.Sprint6.Task2.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxStartStep_KRA = new TextBox();
            textBoxStopStep_KRA = new TextBox();
            buttonHelp_KRA = new Button();
            buttonDone_KRA = new Button();
            groupBoxText_KRA = new GroupBox();
            dataGridViewAnswer_KRA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxTask_KRA = new GroupBox();
            groupBoxInput_KRA = new GroupBox();
            groupBoxStartStop_KRA = new GroupBox();
            chartFunction_KRA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxText_KRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnswer_KRA).BeginInit();
            groupBoxInput_KRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KRA).BeginInit();
            SuspendLayout();
            // 
            // textBoxStartStep_KRA
            // 
            textBoxStartStep_KRA.Location = new Point(21, 397);
            textBoxStartStep_KRA.Name = "textBoxStartStep_KRA";
            textBoxStartStep_KRA.Size = new Size(110, 27);
            textBoxStartStep_KRA.TabIndex = 13;
            // 
            // textBoxStopStep_KRA
            // 
            textBoxStopStep_KRA.Location = new Point(153, 397);
            textBoxStopStep_KRA.Name = "textBoxStopStep_KRA";
            textBoxStopStep_KRA.Size = new Size(109, 27);
            textBoxStopStep_KRA.TabIndex = 12;
            // 
            // buttonHelp_KRA
            // 
            buttonHelp_KRA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KRA.Location = new Point(268, 340);
            buttonHelp_KRA.Name = "buttonHelp_KRA";
            buttonHelp_KRA.Size = new Size(110, 84);
            buttonHelp_KRA.TabIndex = 7;
            buttonHelp_KRA.Text = "Справка";
            buttonHelp_KRA.UseVisualStyleBackColor = false;
            buttonHelp_KRA.Click += buttonHelp_Click;
            // 
            // buttonDone_KRA
            // 
            buttonDone_KRA.BackColor = Color.ForestGreen;
            buttonDone_KRA.Location = new Point(384, 340);
            buttonDone_KRA.Name = "buttonDone_KRA";
            buttonDone_KRA.Size = new Size(116, 84);
            buttonDone_KRA.TabIndex = 11;
            buttonDone_KRA.Text = "Выполнить";
            buttonDone_KRA.UseVisualStyleBackColor = false;
            buttonDone_KRA.Click += buttonDone_Click;
            buttonDone_KRA.MouseDown += buttonDone_MouseDown;
            buttonDone_KRA.MouseEnter += buttonDone_MouseEnter;
            buttonDone_KRA.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBoxText_KRA
            // 
            groupBoxText_KRA.Controls.Add(dataGridViewAnswer_KRA);
            groupBoxText_KRA.Location = new Point(522, 8);
            groupBoxText_KRA.Name = "groupBoxText_KRA";
            groupBoxText_KRA.Size = new Size(169, 416);
            groupBoxText_KRA.TabIndex = 10;
            groupBoxText_KRA.TabStop = false;
            groupBoxText_KRA.Text = "Вывод данных.                    Результат.";
            // 
            // dataGridViewAnswer_KRA
            // 
            dataGridViewAnswer_KRA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnswer_KRA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewAnswer_KRA.Location = new Point(27, 41);
            dataGridViewAnswer_KRA.Name = "dataGridViewAnswer_KRA";
            dataGridViewAnswer_KRA.RowHeadersVisible = false;
            dataGridViewAnswer_KRA.RowHeadersWidth = 51;
            dataGridViewAnswer_KRA.Size = new Size(104, 375);
            dataGridViewAnswer_KRA.TabIndex = 15;
            dataGridViewAnswer_KRA.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // groupBoxTask_KRA
            // 
            groupBoxTask_KRA.Location = new Point(21, 8);
            groupBoxTask_KRA.Name = "groupBoxTask_KRA";
            groupBoxTask_KRA.Size = new Size(479, 313);
            groupBoxTask_KRA.TabIndex = 8;
            groupBoxTask_KRA.TabStop = false;
            groupBoxTask_KRA.Text = "Условие:                                                                               Протабулировать функцию по формуле на диапазоне [-5;5].Результаты вывести в виде таблицы.";
            // 
            // groupBoxInput_KRA
            // 
            groupBoxInput_KRA.Controls.Add(groupBoxStartStop_KRA);
            groupBoxInput_KRA.Location = new Point(21, 340);
            groupBoxInput_KRA.Name = "groupBoxInput_KRA";
            groupBoxInput_KRA.Size = new Size(241, 103);
            groupBoxInput_KRA.TabIndex = 14;
            groupBoxInput_KRA.TabStop = false;
            groupBoxInput_KRA.Text = "Ввод данных";
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
            // chartFunction_KRA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KRA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KRA.Legends.Add(legend1);
            chartFunction_KRA.Location = new Point(726, 43);
            chartFunction_KRA.Name = "chartFunction_KRA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KRA.Series.Add(series1);
            chartFunction_KRA.Size = new Size(573, 375);
            chartFunction_KRA.TabIndex = 15;
            chartFunction_KRA.Text = "chart1";
            chartFunction_KRA.Click += chart1_Click;
            // 
            // FormMain_KRA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 450);
            Controls.Add(chartFunction_KRA);
            Controls.Add(textBoxStartStep_KRA);
            Controls.Add(textBoxStopStep_KRA);
            Controls.Add(buttonHelp_KRA);
            Controls.Add(buttonDone_KRA);
            Controls.Add(groupBoxText_KRA);
            Controls.Add(groupBoxTask_KRA);
            Controls.Add(groupBoxInput_KRA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_KRA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Козырев Р.А";
            Load += FormMain_KRA_Load;
            groupBoxText_KRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnswer_KRA).EndInit();
            groupBoxInput_KRA.ResumeLayout(false);
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
        private DataGridView dataGridViewAnswer_KRA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRA;
    }
}
