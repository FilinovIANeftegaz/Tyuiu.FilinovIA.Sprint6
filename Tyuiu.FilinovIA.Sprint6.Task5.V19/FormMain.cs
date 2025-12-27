using Tyuiu.FilinovIA.Sprint6.Task5.V19.Lib;

namespace Tyuiu.FilinovIA.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\GIGABYTE\Desktop\DataSprint5\InPutDataFileTask5V19.txt";

        private void buttonDone_KRA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KRA.ColumnCount = 2;
            dataGridViewNums_KRA.Columns[0].Width = 20;
            dataGridViewNums_KRA.Columns[1].Width = 50;
            this.chartFunction_KRA.ChartAreas[0].AxisX.Title = "��� X";
            this.chartFunction_KRA.ChartAreas[0].AxisY.Title = "��� Y";
            chartFunction_KRA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_KRA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_KRA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonHelp_KRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 5 �������� ������� ������ ������-25-1 ������� ����� ��������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_KRA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
