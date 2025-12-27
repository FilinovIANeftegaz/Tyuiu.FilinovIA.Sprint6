namespace Tyuiu.FilinovIA.Sprint6.Task3.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KRA));
            groupBoxOutput_KRA = new GroupBox();
            groupBoxResult_KRA = new GroupBox();
            groupBoxCondition_KRA = new GroupBox();
            groupMatrix_KRA = new GroupBox();
            groupBoxText_KRA = new GroupBox();
            dataGridViewMatrix_KRA = new DataGridView();
            buttonHelp_KRA = new Button();
            buttonComplete_KRA = new Button();
            groupBoxOutput_KRA.SuspendLayout();
            groupBoxCondition_KRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KRA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOutput_KRA
            // 
            groupBoxOutput_KRA.Controls.Add(groupBoxResult_KRA);
            groupBoxOutput_KRA.Location = new Point(489, 12);
            groupBoxOutput_KRA.Name = "groupBoxOutput_KRA";
            groupBoxOutput_KRA.Size = new Size(299, 110);
            groupBoxOutput_KRA.TabIndex = 15;
            groupBoxOutput_KRA.TabStop = false;
            groupBoxOutput_KRA.Text = "Вывод данных";
            // 
            // groupBoxResult_KRA
            // 
            groupBoxResult_KRA.Location = new Point(0, 36);
            groupBoxResult_KRA.Name = "groupBoxResult_KRA";
            groupBoxResult_KRA.Size = new Size(299, 74);
            groupBoxResult_KRA.TabIndex = 8;
            groupBoxResult_KRA.TabStop = false;
            groupBoxResult_KRA.Text = "Результат";
            // 
            // groupBoxCondition_KRA
            // 
            groupBoxCondition_KRA.Controls.Add(groupMatrix_KRA);
            groupBoxCondition_KRA.Controls.Add(groupBoxText_KRA);
            groupBoxCondition_KRA.Location = new Point(6, 12);
            groupBoxCondition_KRA.Name = "groupBoxCondition_KRA";
            groupBoxCondition_KRA.Size = new Size(464, 426);
            groupBoxCondition_KRA.TabIndex = 12;
            groupBoxCondition_KRA.TabStop = false;
            groupBoxCondition_KRA.Text = "Условие";
            // 
            // groupMatrix_KRA
            // 
            groupMatrix_KRA.Location = new Point(6, 189);
            groupMatrix_KRA.Name = "groupMatrix_KRA";
            groupMatrix_KRA.Size = new Size(146, 105);
            groupMatrix_KRA.TabIndex = 0;
            groupMatrix_KRA.TabStop = false;
            groupMatrix_KRA.Text = " 26 -15   7   1  -4   14  26  22  17  27   -8  31  22  34   4  -18  16  -2  16  27   5   2  -4  16  15";
            // 
            // groupBoxText_KRA
            // 
            groupBoxText_KRA.Location = new Point(6, 44);
            groupBoxText_KRA.Name = "groupBoxText_KRA";
            groupBoxText_KRA.Size = new Size(284, 167);
            groupBoxText_KRA.TabIndex = 13;
            groupBoxText_KRA.TabStop = false;
            groupBoxText_KRA.Text = resources.GetString("groupBoxText_KRA.Text");
            // 
            // dataGridViewMatrix_KRA
            // 
            dataGridViewMatrix_KRA.AllowDrop = true;
            dataGridViewMatrix_KRA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KRA.ColumnHeadersVisible = false;
            dataGridViewMatrix_KRA.Location = new Point(489, 86);
            dataGridViewMatrix_KRA.Name = "dataGridViewMatrix_KRA";
            dataGridViewMatrix_KRA.RowHeadersVisible = false;
            dataGridViewMatrix_KRA.RowHeadersWidth = 51;
            dataGridViewMatrix_KRA.Size = new Size(298, 302);
            dataGridViewMatrix_KRA.TabIndex = 18;
            dataGridViewMatrix_KRA.CellContentClick += dataGridViewMatrix_KRA_CellContentClick;
            // 
            // buttonHelp_KRA
            // 
            buttonHelp_KRA.Location = new Point(600, 395);
            buttonHelp_KRA.Name = "buttonHelp_KRA";
            buttonHelp_KRA.Size = new Size(46, 44);
            buttonHelp_KRA.TabIndex = 17;
            buttonHelp_KRA.Text = "?";
            buttonHelp_KRA.UseVisualStyleBackColor = true;
            buttonHelp_KRA.Click += buttonHelp_KRA_Click;
            // 
            // buttonComplete_KRA
            // 
            buttonComplete_KRA.Location = new Point(652, 394);
            buttonComplete_KRA.Name = "buttonComplete_KRA";
            buttonComplete_KRA.Size = new Size(136, 45);
            buttonComplete_KRA.TabIndex = 16;
            buttonComplete_KRA.Text = "Выполнить";
            buttonComplete_KRA.UseVisualStyleBackColor = true;
            buttonComplete_KRA.Click += buttonComplete_KRA_Click;
            // 
            // FormMain_KRA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMatrix_KRA);
            Controls.Add(groupBoxOutput_KRA);
            Controls.Add(buttonHelp_KRA);
            Controls.Add(buttonComplete_KRA);
            Controls.Add(groupBoxCondition_KRA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_KRA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 21 | Козырев Р.А ";
            Load += FormMain_Load;
            groupBoxOutput_KRA.ResumeLayout(false);
            groupBoxCondition_KRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KRA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOutput_KRA;
        private GroupBox groupBoxResult_KRA;
        private GroupBox groupBoxCondition_KRA;
        private Button buttonHelp_KRA;
        private Button buttonComplete_KRA;
        private GroupBox groupBoxText_KRA;
        private GroupBox groupMatrix_KRA;
        private DataGridView dataGridViewMatrix_KRA;
    }
}
