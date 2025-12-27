using Tyuiu.FilinovIA.Sprint6.Task3.V21.Lib;

namespace Tyuiu.FilinovIA.Sprint6.Task3.V21
{
    public partial class FormMain_KRA : Form
    {
        public FormMain_KRA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
        {
            {26, -15,  7,   1, -4},
            { 14,  26, 22,  17, 27},
            { -8,  31, 22,  34,  4},
            {-18,  16, -2,  16, 27},
            {  5,   2, -4,  16, 15}
        };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewMatrix_KRA.ColumnCount = columns;
            dataGridViewMatrix_KRA.RowCount = rows;

        }


        private void buttonHelp_KRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 3 �������� ������� ������ ������-25-1 ������� ����� ��������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonComplete_KRA_Click(object sender, EventArgs e)
        {
            int[,] list = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewMatrix_KRA.ColumnCount = columns;
            dataGridViewMatrix_KRA.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KRA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KRA.Rows[i].Cells[j].Value = Convert.ToString(list[i, j]);
                }
            }
        }

        private void dataGridViewMatrix_KRA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
