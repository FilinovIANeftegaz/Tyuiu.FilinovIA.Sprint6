namespace Tyuiu.FilinovIA.Sprint6.Task0.V2
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
            groupBoxCondition_KRA = new GroupBox();
            groupBoxOutput_KRA = new GroupBox();
            groupBoxResult_KRA = new GroupBox();
            textBoxAnswer_KRA = new TextBox();
            buttonComplete_KRA = new Button();
            buttonHelp_KRA = new Button();
            groupBox_X_KRA = new GroupBox();
            groupBox_InputX_KRA = new TextBox();
            groupBoxInput_KRA = new GroupBox();
            pictureBoxFormula_KRA = new PictureBox();
            groupBoxText_KRA = new GroupBox();
            groupBoxOutput_KRA.SuspendLayout();
            groupBoxResult_KRA.SuspendLayout();
            groupBoxInput_KRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KRA).BeginInit();
            groupBoxText_KRA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_KRA
            // 
            groupBoxCondition_KRA.Location = new Point(0, 12);
            groupBoxCondition_KRA.Name = "groupBoxCondition_KRA";
            groupBoxCondition_KRA.Size = new Size(788, 62);
            groupBoxCondition_KRA.TabIndex = 0;
            groupBoxCondition_KRA.TabStop = false;
            groupBoxCondition_KRA.Text = "Условие";
            // 
            // groupBoxOutput_KRA
            // 
            groupBoxOutput_KRA.Controls.Add(groupBoxResult_KRA);
            groupBoxOutput_KRA.Location = new Point(462, 253);
            groupBoxOutput_KRA.Name = "groupBoxOutput_KRA";
            groupBoxOutput_KRA.Size = new Size(320, 142);
            groupBoxOutput_KRA.TabIndex = 9;
            groupBoxOutput_KRA.TabStop = false;
            groupBoxOutput_KRA.Text = "Вывод данных";
            // 
            // groupBoxResult_KRA
            // 
            groupBoxResult_KRA.Controls.Add(textBoxAnswer_KRA);
            groupBoxResult_KRA.Location = new Point(6, 62);
            groupBoxResult_KRA.Name = "groupBoxResult_KRA";
            groupBoxResult_KRA.Size = new Size(308, 74);
            groupBoxResult_KRA.TabIndex = 8;
            groupBoxResult_KRA.TabStop = false;
            groupBoxResult_KRA.Text = "Результат";
            groupBoxResult_KRA.Enter += groupBox8_Enter;
            // 
            // textBoxAnswer_KRA
            // 
            textBoxAnswer_KRA.Location = new Point(6, 36);
            textBoxAnswer_KRA.Name = "textBoxAnswer_KRA";
            textBoxAnswer_KRA.ReadOnly = true;
            textBoxAnswer_KRA.Size = new Size(194, 27);
            textBoxAnswer_KRA.TabIndex = 0;
            textBoxAnswer_KRA.TextChanged += buttonCompleteDONE_KRA;
            // 
            // buttonComplete_KRA
            // 
            buttonComplete_KRA.Location = new Point(536, 395);
            buttonComplete_KRA.Name = "buttonComplete_KRA";
            buttonComplete_KRA.Size = new Size(246, 45);
            buttonComplete_KRA.TabIndex = 10;
            buttonComplete_KRA.Text = "Выполнить";
            buttonComplete_KRA.UseVisualStyleBackColor = true;
            buttonComplete_KRA.Click += buttonCompleteDONE_KRA;
            // 
            // buttonHelp_KRA
            // 
            buttonHelp_KRA.Location = new Point(468, 395);
            buttonHelp_KRA.Name = "buttonHelp_KRA";
            buttonHelp_KRA.Size = new Size(62, 45);
            buttonHelp_KRA.TabIndex = 11;
            buttonHelp_KRA.Text = "?";
            buttonHelp_KRA.UseVisualStyleBackColor = true;
            buttonHelp_KRA.Click += buttonName_KRA_Click;
            // 
            // groupBox_X_KRA
            // 
            groupBox_X_KRA.Location = new Point(16, 78);
            groupBox_X_KRA.Name = "groupBox_X_KRA";
            groupBox_X_KRA.Size = new Size(125, 47);
            groupBox_X_KRA.TabIndex = 6;
            groupBox_X_KRA.TabStop = false;
            groupBox_X_KRA.Text = "Переменная X";
            // 
            // groupBox_InputX_KRA
            // 
            groupBox_InputX_KRA.Location = new Point(16, 98);
            groupBox_InputX_KRA.Name = "groupBox_InputX_KRA";
            groupBox_InputX_KRA.Size = new Size(125, 27);
            groupBox_InputX_KRA.TabIndex = 0;
            groupBox_InputX_KRA.KeyPress += groupBox_InputX_X_KRA;
            // 
            // groupBoxInput_KRA
            // 
            groupBoxInput_KRA.Controls.Add(groupBox_InputX_KRA);
            groupBoxInput_KRA.Controls.Add(groupBox_X_KRA);
            groupBoxInput_KRA.Location = new Point(12, 253);
            groupBoxInput_KRA.Name = "groupBoxInput_KRA";
            groupBoxInput_KRA.Size = new Size(426, 142);
            groupBoxInput_KRA.TabIndex = 5;
            groupBoxInput_KRA.TabStop = false;
            groupBoxInput_KRA.Text = "Ввод данных";
            // 
            // pictureBoxFormula_KRA
            // 
            pictureBoxFormula_KRA.Image = (Image)resources.GetObject("pictureBoxFormula_KRA.Image");
            pictureBoxFormula_KRA.Location = new Point(579, 26);
            pictureBoxFormula_KRA.Name = "pictureBoxFormula_KRA";
            pictureBoxFormula_KRA.Size = new Size(197, 105);
            pictureBoxFormula_KRA.TabIndex = 1;
            pictureBoxFormula_KRA.TabStop = false;
            pictureBoxFormula_KRA.Click += pictureBox1_Click;
            // 
            // groupBoxText_KRA
            // 
            groupBoxText_KRA.Controls.Add(pictureBoxFormula_KRA);
            groupBoxText_KRA.Location = new Point(12, 80);
            groupBoxText_KRA.Name = "groupBoxText_KRA";
            groupBoxText_KRA.Size = new Size(776, 167);
            groupBoxText_KRA.TabIndex = 2;
            groupBoxText_KRA.TabStop = false;
            groupBoxText_KRA.Text = "Вычислить выражение по формуле";
            groupBoxText_KRA.Enter += groupBox2_Enter;
            // 
            // FormMain_KRA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_KRA);
            Controls.Add(buttonComplete_KRA);
            Controls.Add(groupBoxOutput_KRA);
            Controls.Add(groupBoxText_KRA);
            Controls.Add(groupBoxCondition_KRA);
            Controls.Add(groupBoxInput_KRA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_KRA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 2 | Козырев Р.А ";
            Load += FormMain_Load;
            KeyPress += buttonCompleteDONE_KRA;
            groupBoxOutput_KRA.ResumeLayout(false);
            groupBoxResult_KRA.ResumeLayout(false);
            groupBoxResult_KRA.PerformLayout();
            groupBoxInput_KRA.ResumeLayout(false);
            groupBoxInput_KRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KRA).EndInit();
            groupBoxText_KRA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_KRA;
        private GroupBox groupBoxOutput_KRA;
        private GroupBox groupBoxResult_KRA;
        private Button buttonComplete_KRA;
        private Button buttonHelp_KRA;
        private TextBox textBoxAnswer_KRA;
        private GroupBox groupBox_X_KRA;
        private TextBox groupBox_InputX_KRA;
        private GroupBox groupBoxInput_KRA;
        private PictureBox pictureBoxFormula_KRA;
        private GroupBox groupBoxText_KRA;
    }
}
