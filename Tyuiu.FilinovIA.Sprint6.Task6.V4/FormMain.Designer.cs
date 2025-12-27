namespace Tyuiu.FilinovIA.Sprint6.Task6.V4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KRA));
            textBoxOutPut_KRA = new TextBox();
            textBoxTask_KRA = new TextBox();
            textBoxInput_KRA = new TextBox();
            splitter1 = new Splitter();
            openFileDialogTask_KRA = new OpenFileDialog();
            toolTip_KRA = new ToolTip(components);
            buttonLoad_KRA = new Button();
            buttonAbout_KRA = new Button();
            buttonDone_KRA = new Button();
            SuspendLayout();
            // 
            // textBoxOutPut_KRA
            // 
            textBoxOutPut_KRA.Dock = DockStyle.Fill;
            textBoxOutPut_KRA.Location = new Point(592, 180);
            textBoxOutPut_KRA.Multiline = true;
            textBoxOutPut_KRA.Name = "textBoxOutPut_KRA";
            textBoxOutPut_KRA.ReadOnly = true;
            textBoxOutPut_KRA.Size = new Size(567, 375);
            textBoxOutPut_KRA.TabIndex = 0;
            textBoxOutPut_KRA.TextChanged += textBoxTask_KRA_TextChanged;
            // 
            // textBoxTask_KRA
            // 
            textBoxTask_KRA.Dock = DockStyle.Top;
            textBoxTask_KRA.Location = new Point(0, 0);
            textBoxTask_KRA.Multiline = true;
            textBoxTask_KRA.Name = "textBoxTask_KRA";
            textBoxTask_KRA.ReadOnly = true;
            textBoxTask_KRA.Size = new Size(1159, 180);
            textBoxTask_KRA.TabIndex = 1;
            textBoxTask_KRA.Text = resources.GetString("textBoxTask_KRA.Text");
            textBoxTask_KRA.TextChanged += textBoxOutPut_KRA_TextChanged;
            // 
            // textBoxInput_KRA
            // 
            textBoxInput_KRA.Dock = DockStyle.Left;
            textBoxInput_KRA.Location = new Point(0, 180);
            textBoxInput_KRA.Multiline = true;
            textBoxInput_KRA.Name = "textBoxInput_KRA";
            textBoxInput_KRA.ReadOnly = true;
            textBoxInput_KRA.Size = new Size(592, 375);
            textBoxInput_KRA.TabIndex = 2;
            textBoxInput_KRA.TextChanged += textBoxInput_KRA_TextChanged_1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(592, 180);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 375);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_KRA
            // 
            openFileDialogTask_KRA.FileName = "openFileDialog_KRA";
            // 
            // toolTip_KRA
            // 
            toolTip_KRA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_KRA.ToolTipTitle = "Подсказка";
            // 
            // buttonLoad_KRA
            // 
            buttonLoad_KRA.BackColor = Color.White;
            buttonLoad_KRA.Cursor = Cursors.Hand;
            buttonLoad_KRA.Enabled = false;
            buttonLoad_KRA.Image = (Image)resources.GetObject("buttonLoad_KRA.Image");
            buttonLoad_KRA.Location = new Point(136, 12);
            buttonLoad_KRA.Name = "buttonLoad_KRA";
            buttonLoad_KRA.Size = new Size(102, 72);
            buttonLoad_KRA.TabIndex = 32;
            toolTip_KRA.SetToolTip(buttonLoad_KRA, "Вывод");
            buttonLoad_KRA.UseVisualStyleBackColor = false;
            buttonLoad_KRA.Click += buttonLoad_KRA_Click;
            // 
            // buttonAbout_KRA
            // 
            buttonAbout_KRA.Image = Properties.Resources.Снимок_экрана_2025_11_24_194417;
            buttonAbout_KRA.Location = new Point(1053, 12);
            buttonAbout_KRA.Name = "buttonAbout_KRA";
            buttonAbout_KRA.Size = new Size(94, 88);
            buttonAbout_KRA.TabIndex = 33;
            toolTip_KRA.SetToolTip(buttonAbout_KRA, "Информация о приложение");
            buttonAbout_KRA.UseVisualStyleBackColor = true;
            buttonAbout_KRA.Click += buttonAbout_KRA_Click;
            // 
            // buttonDone_KRA
            // 
            buttonDone_KRA.BackColor = Color.White;
            buttonDone_KRA.Cursor = Cursors.Hand;
            buttonDone_KRA.Image = (Image)resources.GetObject("buttonDone_KRA.Image");
            buttonDone_KRA.Location = new Point(12, 4);
            buttonDone_KRA.Name = "buttonDone_KRA";
            buttonDone_KRA.Size = new Size(80, 96);
            buttonDone_KRA.TabIndex = 31;
            toolTip_KRA.SetToolTip(buttonDone_KRA, "Выбрать файлы\r\n");
            buttonDone_KRA.UseVisualStyleBackColor = false;
            buttonDone_KRA.Click += buttonDone_KRA_Click;
            // 
            // FormMain_KRA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 555);
            Controls.Add(buttonAbout_KRA);
            Controls.Add(buttonLoad_KRA);
            Controls.Add(buttonDone_KRA);
            Controls.Add(splitter1);
            Controls.Add(textBoxOutPut_KRA);
            Controls.Add(textBoxInput_KRA);
            Controls.Add(textBoxTask_KRA);
            Name = "FormMain_KRA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 4 | Козырев Р.А";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOutPut_KRA;
        private TextBox textBoxTask_KRA;
        private TextBox textBoxInput_KRA;
        private Splitter splitter1;
        private OpenFileDialog openFileDialogTask_KRA;
        private ToolTip toolTip_KRA;
        private Button buttonLoad_KRA;
        private Button buttonAbout_KRA;
        private Button buttonDone_KRA;
    }
}
