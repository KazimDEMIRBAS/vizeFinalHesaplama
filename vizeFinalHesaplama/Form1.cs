namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ort;
            try
            {
                vize = Convert.ToDouble(numericUpDown1.Text);
                final = Convert.ToDouble(numericUpDown2.Text);
                ort = vize * 0.4 + final * 0.6;
                label3.Text = ort.ToString();
                if (ort < 50)
                {
                    label6.Text="FF KALDINIZ";
                    label6.ForeColor = Color.Red;   
                }
                if(ort >=50 && ort < 65)
                {
                    label6.Text = "DD";
                    label6.ForeColor = Color.Green;
                }
                if (ort >= 65 && ort < 75)
                {
                    label6.Text = "CC";
                    label6.ForeColor = Color.Green;
                }
                if (ort >= 75 && ort < 85)
                {
                    label6.Text = "BB";
                    label6.ForeColor = Color.Green;
                }
                if (ort >= 85 && ort <= 100)
                {
                    label6.Text ="AA";
                    label6.ForeColor = Color.Green;
                }

            }
            catch (Exception)

            {
                
               // if (numericUpDown1.Value < 0 && numericUpDown2.Value > 100 )
                {
                 //   MessageBox.Show("Girilen sayýlar hatalý");
                }
              //  else
                {
                 //   MessageBox.Show("hatalý");
                }

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100;
            numericUpDown1.ForeColor= Color.Red;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 100;
            numericUpDown2.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}