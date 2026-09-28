using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;
            string c = b;
            comboBox2.Text = a;
            comboBox1.Text = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string itemText = listBox1.Items[i].ToString();

                // Mətnin daxilindəki köhnə "N) " hissəsini tapıb yeni nömrə ilə əvəzləyirik
                int closingParenIndex = itemText.IndexOf(')');
                if (closingParenIndex != -1)
                {
                    string cleanText = itemText.Substring(closingParenIndex + 1); // Köhnə nömrəni kəsirik
                    listBox1.Items[i] = (i + 1).ToString() + ")" + cleanText;     // Yeni nömrəni təyin edirik
                }
            }
            n = listBox1.Items.Count;
        }
        int n = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Zəhmət olmasa gediş və gəliş şəhərlərini seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Eyni şəhərlərə gediş yoxdur", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!maskedTextBox4.Text.Contains("@") || !maskedTextBox4.Text.Contains("."))
            {
                MessageBox.Show("Düzgün e-mail ünvanı daxil edin", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                n++;
                listBox1.Items.Add(n.ToString() + ") " + comboBox1.Text + " " + comboBox2.Text + " ("
                    + maskedTextBox5.Text + ") " + maskedTextBox6.Text);


            }
        }
    }
}
