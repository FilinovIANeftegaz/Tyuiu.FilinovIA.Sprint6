namespace Tyuiu.FilinovIA.Sprint6.Task7.V5
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxTask_KRA = new TextBox();
            openFileDialogTask_KRA = new OpenFileDialog();
            toolTip_KRA = new ToolTip(components);
            buttonComplete_KRA = new Button();
            buttonOpen_KRA = new Button();
            button_INFO_KRA = new Button();
            buttonSave_KRA = new Button();
            saveFileDialog_KRA = new SaveFileDialog();
            dataGridView_OutPut_KRA = new DataGridView();
            panel_TOP_KRA = new Panel();
            textBox_Input_KRA = new TextBox();
            textBox_OutPut_KRA = new TextBox();
            panel_Left_KRA = new Panel();
            splitter_KRA = new Splitter();
            dataGridView_Input_KRA = new DataGridView();
            panelMiddle_KRA = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_OutPut_KRA).BeginInit();
            panel_TOP_KRA.SuspendLayout();
            panel_Left_KRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Input_KRA).BeginInit();
            panelMiddle_KRA.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTask_KRA
            // 
            textBoxTask_KRA.Dock = DockStyle.Top;
            textBoxTask_KRA.Location = new Point(0, 0);
            textBoxTask_KRA.Multiline = true;
            textBoxTask_KRA.Name = "textBoxTask_KRA";
            textBoxTask_KRA.ReadOnly = true;
            textBoxTask_KRA.Size = new Size(1902, 96);
            textBoxTask_KRA.TabIndex = 35;
            textBoxTask_KRA.Text = resources.GetString("textBoxTask_KRA.Text");
            textBoxTask_KRA.TextChanged += textBoxTask_KRA_TextChanged;
            // 
            // openFileDialogTask_KRA
            // 
            openFileDialogTask_KRA.FileName = "openFileDialog_KRA";
            // 
            // toolTip_KRA
            // 
            toolTip_KRA.IsBalloon = true;
            toolTip_KRA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_KRA.ToolTipTitle = "Подсказка";
            // 
            // buttonComplete_KRA
            // 
            buttonComplete_KRA.Anchor = AnchorStyles.Left;
            buttonComplete_KRA.BackColor = Color.White;
            buttonComplete_KRA.Cursor = Cursors.Hand;
            buttonComplete_KRA.Enabled = false;
            buttonComplete_KRA.Image = (Image)resources.GetObject("buttonComplete_KRA.Image");
            buttonComplete_KRA.Location = new Point(183, 20);
            buttonComplete_KRA.Name = "buttonComplete_KRA";
            buttonComplete_KRA.Size = new Size(102, 72);
            buttonComplete_KRA.TabIndex = 42;
            toolTip_KRA.SetToolTip(buttonComplete_KRA, "Вывод");
            buttonComplete_KRA.UseVisualStyleBackColor = false;
            buttonComplete_KRA.Click += buttonComplete_KRA_Click;
            // 
            // buttonOpen_KRA
            // 
            buttonOpen_KRA.Anchor = AnchorStyles.Left;
            buttonOpen_KRA.BackColor = Color.White;
            buttonOpen_KRA.Cursor = Cursors.Hand;
            buttonOpen_KRA.Image = (Image)resources.GetObject("buttonOpen_KRA.Image");
            buttonOpen_KRA.Location = new Point(14, 20);
            buttonOpen_KRA.Name = "buttonOpen_KRA";
            buttonOpen_KRA.Size = new Size(80, 96);
            buttonOpen_KRA.TabIndex = 41;
            toolTip_KRA.SetToolTip(buttonOpen_KRA, "Выбрать файлы\r\n");
            buttonOpen_KRA.UseVisualStyleBackColor = false;
            buttonOpen_KRA.Click += buttonOpen_KRA_Click;
            // 
            // button_INFO_KRA
            // 
            button_INFO_KRA.Anchor = AnchorStyles.Right;
            button_INFO_KRA.Image = Properties.Resources.Снимок_экрана_2025_11_24_194417;
            button_INFO_KRA.Location = new Point(1787, 20);
            button_INFO_KRA.Name = "button_INFO_KRA";
            button_INFO_KRA.Size = new Size(94, 88);
            button_INFO_KRA.TabIndex = 43;
            toolTip_KRA.SetToolTip(button_INFO_KRA, "Информация о приложение");
            button_INFO_KRA.UseVisualStyleBackColor = true;
            button_INFO_KRA.Click += button_INFO_KRA_Click;
            // 
            // buttonSave_KRA
            // 
            buttonSave_KRA.Anchor = AnchorStyles.Left;
            buttonSave_KRA.BackColor = Color.White;
            buttonSave_KRA.Cursor = Cursors.Hand;
            buttonSave_KRA.Enabled = false;
            buttonSave_KRA.Image = (Image)resources.GetObject("buttonSave_KRA.Image");
            buttonSave_KRA.Location = new Point(370, 20);
            buttonSave_KRA.Name = "buttonSave_KRA";
            buttonSave_KRA.Size = new Size(102, 72);
            buttonSave_KRA.TabIndex = 47;
            toolTip_KRA.SetToolTip(buttonSave_KRA, "Сохранить файл\r\n");
            buttonSave_KRA.UseVisualStyleBackColor = false;
            buttonSave_KRA.Click += buttonSave_KRA_Click;
            // 
            // dataGridView_OutPut_KRA
            // 
            dataGridView_OutPut_KRA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_OutPut_KRA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_OutPut_KRA.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView_OutPut_KRA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_OutPut_KRA.ColumnHeadersVisible = false;
            dataGridView_OutPut_KRA.Dock = DockStyle.Fill;
            dataGridView_OutPut_KRA.Location = new Point(876, 0);
            dataGridView_OutPut_KRA.Name = "dataGridView_OutPut_KRA";
            dataGridView_OutPut_KRA.ReadOnly = true;
            dataGridView_OutPut_KRA.RowHeadersVisible = false;
            dataGridView_OutPut_KRA.RowHeadersWidth = 51;
            dataGridView_OutPut_KRA.Size = new Size(1026, 723);
            dataGridView_OutPut_KRA.TabIndex = 45;
            dataGridView_OutPut_KRA.CellContentClick += dataGridView_OutPut_KRA_CellContentClick;
            // 
            // panel_TOP_KRA
            // 
            panel_TOP_KRA.Controls.Add(textBox_Input_KRA);
            panel_TOP_KRA.Controls.Add(textBox_OutPut_KRA);
            panel_TOP_KRA.Controls.Add(textBoxTask_KRA);
            panel_TOP_KRA.Dock = DockStyle.Top;
            panel_TOP_KRA.Location = new Point(0, 150);
            panel_TOP_KRA.Name = "panel_TOP_KRA";
            panel_TOP_KRA.Size = new Size(1902, 160);
            panel_TOP_KRA.TabIndex = 48;
            // 
            // textBox_Input_KRA
            // 
            textBox_Input_KRA.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_Input_KRA.Location = new Point(14, 112);
            textBox_Input_KRA.Name = "textBox_Input_KRA";
            textBox_Input_KRA.ReadOnly = true;
            textBox_Input_KRA.Size = new Size(876, 27);
            textBox_Input_KRA.TabIndex = 44;
            textBox_Input_KRA.Text = "Ввод:";
            // 
            // textBox_OutPut_KRA
            // 
            textBox_OutPut_KRA.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox_OutPut_KRA.Location = new Point(926, 112);
            textBox_OutPut_KRA.Name = "textBox_OutPut_KRA";
            textBox_OutPut_KRA.ReadOnly = true;
            textBox_OutPut_KRA.Size = new Size(955, 27);
            textBox_OutPut_KRA.TabIndex = 46;
            textBox_OutPut_KRA.Text = "Вывод:";
            // 
            // panel_Left_KRA
            // 
            panel_Left_KRA.Controls.Add(splitter_KRA);
            panel_Left_KRA.Controls.Add(dataGridView_OutPut_KRA);
            panel_Left_KRA.Controls.Add(dataGridView_Input_KRA);
            panel_Left_KRA.Dock = DockStyle.Fill;
            panel_Left_KRA.Location = new Point(0, 310);
            panel_Left_KRA.Name = "panel_Left_KRA";
            panel_Left_KRA.Size = new Size(1902, 723);
            panel_Left_KRA.TabIndex = 49;
            // 
            // splitter_KRA
            // 
            splitter_KRA.Location = new Point(876, 0);
            splitter_KRA.Name = "splitter_KRA";
            splitter_KRA.Size = new Size(4, 723);
            splitter_KRA.TabIndex = 46;
            splitter_KRA.TabStop = false;
            // 
            // dataGridView_Input_KRA
            // 
            dataGridView_Input_KRA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Input_KRA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Input_KRA.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView_Input_KRA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Input_KRA.ColumnHeadersVisible = false;
            dataGridView_Input_KRA.Dock = DockStyle.Left;
            dataGridView_Input_KRA.Location = new Point(0, 0);
            dataGridView_Input_KRA.Name = "dataGridView_Input_KRA";
            dataGridView_Input_KRA.ReadOnly = true;
            dataGridView_Input_KRA.RowHeadersVisible = false;
            dataGridView_Input_KRA.RowHeadersWidth = 51;
            dataGridView_Input_KRA.Size = new Size(876, 723);
            dataGridView_Input_KRA.TabIndex = 44;
            dataGridView_Input_KRA.Tag = "";
            // 
            // panelMiddle_KRA
            // 
            panelMiddle_KRA.BackColor = SystemColors.ButtonShadow;
            panelMiddle_KRA.Controls.Add(button_INFO_KRA);
            panelMiddle_KRA.Controls.Add(buttonOpen_KRA);
            panelMiddle_KRA.Controls.Add(buttonComplete_KRA);
            panelMiddle_KRA.Controls.Add(buttonSave_KRA);
            panelMiddle_KRA.Dock = DockStyle.Top;
            panelMiddle_KRA.Location = new Point(0, 0);
            panelMiddle_KRA.Name = "panelMiddle_KRA";
            panelMiddle_KRA.Size = new Size(1902, 150);
            panelMiddle_KRA.TabIndex = 51;
            panelMiddle_KRA.Paint += panelMiddle_KRA_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel_Left_KRA);
            Controls.Add(panel_TOP_KRA);
            Controls.Add(panelMiddle_KRA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 5 | Козырев Р.А";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_OutPut_KRA).EndInit();
            panel_TOP_KRA.ResumeLayout(false);
            panel_TOP_KRA.PerformLayout();
            panel_Left_KRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Input_KRA).EndInit();
            panelMiddle_KRA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxTask_KRA;
        private OpenFileDialog openFileDialogTask_KRA;
        private ToolTip toolTip_KRA;
        private Button buttonComplete_KRA;
        private Button buttonOpen_KRA;
        private Button button_INFO_KRA;
        private SaveFileDialog saveFileDialog_KRA;
        private DataGridView dataGridView_OutPut_KRA;
        private Button buttonSave_KRA;
        private Panel panel_TOP_KRA;
        private Panel panel_Left_KRA;
        private TextBox textBox_Input_KRA;
        private Panel panelMiddle_KRA;
        private TextBox textBox_OutPut_KRA;
        private DataGridView dataGridView_Input_KRA;
        private Splitter splitter_KRA;
    }
}
