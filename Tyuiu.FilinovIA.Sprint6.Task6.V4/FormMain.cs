using Tyuiu.FilinovIA.Sprint6.Task6.V4.Lib;
namespace Tyuiu.FilinovIA.Sprint6.Task6.V4
{
    public partial class FormMain_KRA : Form
    {
        public FormMain_KRA()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInput_KRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_KRA_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxTask_KRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_KRA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRA.ShowDialog();
            openFilePath = openFileDialogTask_KRA.FileName;
            textBoxInput_KRA.Text = File.ReadAllText(openFilePath);
            textBoxTask_KRA.Text = textBoxTask_KRA.Text + " " + openFileDialogTask_KRA.FileName;
            buttonLoad_KRA.Enabled = true;
        }

        private void textBoxOutPut_KRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAbout_KRA_Click(object sender, EventArgs e)
        {
            FormAbout_KRA FormAbout = new FormAbout_KRA();
            FormAbout.ShowDialog();
        }

        private void buttonLoad_KRA_Click(object sender, EventArgs e)
        {
            string str = textBoxInput_KRA.Text;
            textBoxOutPut_KRA.Text = ds.CollectTextFromFile(str);
        }
    }
}
