namespace Tyuiu.FilinovIA.Sprint6.Task7.V5
{
    partial class FormAbout_KRA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KRA));
            buttonOK_KRA = new Button();
            textBoxInfo_KRA = new TextBox();
            pictureBoxAvatar_KRA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KRA).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_KRA
            // 
            buttonOK_KRA.Location = new Point(683, 247);
            buttonOK_KRA.Name = "buttonOK_KRA";
            buttonOK_KRA.Size = new Size(94, 29);
            buttonOK_KRA.TabIndex = 5;
            buttonOK_KRA.Text = "Ок";
            buttonOK_KRA.UseVisualStyleBackColor = true;
            buttonOK_KRA.Click += buttonOK_KRA_Click;
            // 
            // textBoxInfo_KRA
            // 
            textBoxInfo_KRA.Location = new Point(241, 33);
            textBoxInfo_KRA.Multiline = true;
            textBoxInfo_KRA.Name = "textBoxInfo_KRA";
            textBoxInfo_KRA.ReadOnly = true;
            textBoxInfo_KRA.Size = new Size(536, 200);
            textBoxInfo_KRA.TabIndex = 4;
            textBoxInfo_KRA.Text = resources.GetString("textBoxInfo_KRA.Text");
            // 
            // pictureBoxAvatar_KRA
            // 
            pictureBoxAvatar_KRA.Image = Properties.Resources.Снимок_экрана_2025_11_24_195833;
            pictureBoxAvatar_KRA.Location = new Point(12, 33);
            pictureBoxAvatar_KRA.Name = "pictureBoxAvatar_KRA";
            pictureBoxAvatar_KRA.Size = new Size(184, 243);
            pictureBoxAvatar_KRA.TabIndex = 3;
            pictureBoxAvatar_KRA.TabStop = false;
            // 
            // FormAbout_KRA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 294);
            Controls.Add(buttonOK_KRA);
            Controls.Add(textBoxInfo_KRA);
            Controls.Add(pictureBoxAvatar_KRA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_KRA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KRA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_KRA;
        private TextBox textBoxInfo_KRA;
        private PictureBox pictureBoxAvatar_KRA;
    }
}