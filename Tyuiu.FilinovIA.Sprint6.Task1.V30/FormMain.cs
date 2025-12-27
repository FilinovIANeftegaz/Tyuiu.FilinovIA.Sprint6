using Tyuiu.FilinovIA.Sprint6.Task1.V30.Lib;
namespace Tyuiu.FilinovIA.Sprint6.Task1.V30
{
    public partial class FormMain_KRA : Form
    {
        public FormMain_KRA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 1 �������� ������� ������ ������-25-1 ������� ����� ��������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KRA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KRA.Text);
                string strLine;
                double[] valueArray;
                valueArray = new double[stopStep - startStep + 1];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                int len = valueArray.Length;
                textBoxResult_KRA.Text = "";
                textBoxResult_KRA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KRA.AppendText("|    X     |  f(X)    |" + Environment.NewLine);
                textBoxResult_KRA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,5:f2}  |", startStep, valueArray[i]);
                    textBoxResult_KRA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_KRA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxTask_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxInput_Enter(object sender, EventArgs e)
        {

        }
    }
}
