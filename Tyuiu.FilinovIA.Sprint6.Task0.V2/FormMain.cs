using Tyuiu.FilinovIA.Sprint6.Task0.V2.Lib;
namespace Tyuiu.FilinovIA.Sprint6.Task0.V2
{
    public partial class FormMain_KRA : Form
    {
        public FormMain_KRA()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCompleteDONE_KRA(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxAnswer_KRA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(groupBox_InputX_KRA.Text))); 
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer_KRA_TextChanged(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxAnswer_KRA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(groupBox_InputX_KRA.Text)));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox_InputX_X_KRA(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8)) 
            {
                e.Handled = true;
            }
        }
        private void groupBox_InputX_KRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonName_KRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ������-25-1 ������� ����� ��������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
