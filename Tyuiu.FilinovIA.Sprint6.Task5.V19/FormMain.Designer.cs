namespace Tyuiu.FilinovIA.Sprint6.Task5.V19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxText_KRA = new GroupBox();
            dataGridViewNums_KRA = new DataGridView();
            buttonHelp_KRA = new Button();
            buttonDone_KRA = new Button();
            groupBoxTask_KRA = new GroupBox();
            splitter1 = new Splitter();
            buttonOpen_KRA = new Button();
            panelLeft_KRA = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUP_KRA = new Panel();
            chartFunction_KRA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxText_KRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KRA).BeginInit();
            panelLeft_KRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panelUP_KRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KRA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxText_KRA
            // 
            groupBoxText_KRA.Controls.Add(dataGridViewNums_KRA);
            groupBoxText_KRA.Location = new Point(15, 124);
            groupBoxText_KRA.Name = "groupBoxText_KRA";
            groupBoxText_KRA.Size = new Size(390, 502);
            groupBoxText_KRA.TabIndex = 29;
            groupBoxText_KRA.TabStop = false;
            groupBoxText_KRA.Text = "Вывод данных.  ";
            // 
            // dataGridViewNums_KRA
            // 
            dataGridViewNums_KRA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_KRA.Location = new Point(3, 23);
            dataGridViewNums_KRA.Name = "dataGridViewNums_KRA";
            dataGridViewNums_KRA.RowHeadersWidth = 51;
            dataGridViewNums_KRA.Size = new Size(397, 653);
            dataGridViewNums_KRA.TabIndex = 0;
            // 
            // buttonHelp_KRA
            // 
            buttonHelp_KRA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KRA.Cursor = Cursors.Hand;
            buttonHelp_KRA.Location = new Point(1442, 13);
            buttonHelp_KRA.Name = "buttonHelp_KRA";
            buttonHelp_KRA.Size = new Size(110, 84);
            buttonHelp_KRA.TabIndex = 27;
            buttonHelp_KRA.Text = "Справка";
            buttonHelp_KRA.UseVisualStyleBackColor = false;
            buttonHelp_KRA.Click += buttonHelp_KRA_Click;
            // 
            // buttonDone_KRA
            // 
            buttonDone_KRA.BackColor = Color.ForestGreen;
            buttonDone_KRA.Cursor = Cursors.Hand;
            buttonDone_KRA.Location = new Point(1158, 13);
            buttonDone_KRA.Name = "buttonDone_KRA";
            buttonDone_KRA.Size = new Size(116, 84);
            buttonDone_KRA.TabIndex = 30;
            buttonDone_KRA.Text = "Выполнить";
            buttonDone_KRA.UseVisualStyleBackColor = false;
            buttonDone_KRA.Click += buttonDone_KRA_Click;
            // 
            // groupBoxTask_KRA
            // 
            groupBoxTask_KRA.Location = new Point(15, 12);
            groupBoxTask_KRA.Name = "groupBoxTask_KRA";
            groupBoxTask_KRA.Size = new Size(1046, 106);
            groupBoxTask_KRA.TabIndex = 28;
            groupBoxTask_KRA.TabStop = false;
            groupBoxTask_KRA.Text = resources.GetString("groupBoxTask_KRA.Text");
            // 
            // splitter1
            // 
            splitter1.Location = new Point(440, 125);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 817);
            splitter1.TabIndex = 36;
            splitter1.TabStop = false;
            // 
            // buttonOpen_KRA
            // 
            buttonOpen_KRA.BackColor = Color.Blue;
            buttonOpen_KRA.Cursor = Cursors.Hand;
            buttonOpen_KRA.Location = new Point(1297, 13);
            buttonOpen_KRA.Name = "buttonOpen_KRA";
            buttonOpen_KRA.Size = new Size(125, 84);
            buttonOpen_KRA.TabIndex = 33;
            buttonOpen_KRA.Text = "Открыть файл";
            buttonOpen_KRA.UseVisualStyleBackColor = false;
            buttonOpen_KRA.Click += buttonOpen_KRA_Click;
            // 
            // panelLeft_KRA
            // 
            panelLeft_KRA.Controls.Add(chart1);
            panelLeft_KRA.Dock = DockStyle.Left;
            panelLeft_KRA.Location = new Point(0, 125);
            panelLeft_KRA.Name = "panelLeft_KRA";
            panelLeft_KRA.Size = new Size(440, 817);
            panelLeft_KRA.TabIndex = 35;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(375, 375);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // panelUP_KRA
            // 
            panelUP_KRA.Controls.Add(buttonHelp_KRA);
            panelUP_KRA.Controls.Add(buttonOpen_KRA);
            panelUP_KRA.Controls.Add(buttonDone_KRA);
            panelUP_KRA.Dock = DockStyle.Top;
            panelUP_KRA.Location = new Point(0, 0);
            panelUP_KRA.Name = "panelUP_KRA";
            panelUP_KRA.Size = new Size(1564, 125);
            panelUP_KRA.TabIndex = 34;
            // 
            // chartFunction_KRA
            // 
            chartArea4.Name = "ChartArea1";
            chartFunction_KRA.ChartAreas.Add(chartArea4);
            chartFunction_KRA.Dock = DockStyle.Fill;
            legend4.Name = "Legend1";
            chartFunction_KRA.Legends.Add(legend4);
            chartFunction_KRA.Location = new Point(444, 125);
            chartFunction_KRA.Name = "chartFunction_KRA";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartFunction_KRA.Series.Add(series4);
            chartFunction_KRA.Size = new Size(1120, 817);
            chartFunction_KRA.TabIndex = 37;
            title2.Name = "Title1";
            title2.Text = "График функции";
            chartFunction_KRA.Titles.Add(title2);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1564, 942);
            Controls.Add(chartFunction_KRA);
            Controls.Add(groupBoxText_KRA);
            Controls.Add(groupBoxTask_KRA);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_KRA);
            Controls.Add(panelUP_KRA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 19 | Козырев Р.А";
            groupBoxText_KRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KRA).EndInit();
            panelLeft_KRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panelUP_KRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_KRA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxStartStep_KRA;
        private GroupBox groupBoxText_KRA;
        private TextBox textBoxStopStep_KRA;
        private Button buttonHelp_KRA;
        private Button buttonDone_KRA;
        private GroupBox groupBoxTask_KRA;
        private GroupBox groupBoxInput_KRA;
        private GroupBox groupBoxStartStop_KRA;
        private Splitter splitter1;
        private Button buttonOpen_KRA;
        private Panel panelLeft_KRA;
        private Panel panelUP_KRA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRA;
        private DataGridView dataGridViewNums_KRA;
    }
}
