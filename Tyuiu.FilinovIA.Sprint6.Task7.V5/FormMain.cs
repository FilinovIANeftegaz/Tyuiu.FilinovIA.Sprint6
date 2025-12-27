using System.IO;
using Tyuiu.FilinovIA.Sprint6.Task7.V5.Lib;
using static System.Windows.Forms.LinkLabel;
namespace Tyuiu.FilinovIA.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KRA.Filter = "��������, ���������� �������� (*.csv)|*.csv|��� ����� (*.*)|*.*";
            saveFileDialog_KRA.Filter = "��������, ���������� �������� (*.csv)|*.csv|��� ����� (*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string OpenFilePath;
        private void buttonComplete_KRA_Click(object sender, EventArgs e)
        {
            string fileData = File.ReadAllText(OpenFilePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(OpenFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView_OutPut_KRA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_KRA.Enabled = true;

        }

        private void button_INFO_KRA_Click(object sender, EventArgs e)
        {
            FormAbout_KRA formAbout = new FormAbout_KRA();
            formAbout.ShowDialog();
        }
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
        private void buttonOpen_KRA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRA.ShowDialog();
            OpenFilePath = openFileDialogTask_KRA.FileName;
            string fileData = File.ReadAllText(OpenFilePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            arrayValues = LoadFromFileData(OpenFilePath);
            dataGridView_Input_KRA.ColumnCount = cols;
            dataGridView_Input_KRA.RowCount = rows;
            dataGridView_OutPut_KRA.ColumnCount = cols;
            dataGridView_OutPut_KRA.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridView_Input_KRA.Columns[i].Width = 25;
                dataGridView_OutPut_KRA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView_Input_KRA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(OpenFilePath);
            buttonComplete_KRA.Enabled = true;
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
        }

        private void buttonSave_KRA_Click(object sender, EventArgs e)
        {
            saveFileDialog_KRA.FileName = "OutputFileTask7.csv";
            saveFileDialog_KRA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_KRA.ShowDialog();
            string path = saveFileDialog_KRA.FileName;
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridView_OutPut_KRA.RowCount;
            int columns = dataGridView_OutPut_KRA.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView_OutPut_KRA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView_OutPut_KRA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTask_KRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panel_TOP_KRA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_OutPut_KRA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelMiddle_KRA_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
