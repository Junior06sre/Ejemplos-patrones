namespace CalculadoraC
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        String operador;

        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClassSuma sum = new Clases.ClassSuma();
        Clases.ClassResta res = new Clases.ClassResta();
        Clases.ClassMult mult = new Clases.ClassMult();
        Clases.ClassDividir dividir = new Clases.ClassDividir();

        private void button18_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "9";
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtscreen.Text);
            txtscreen.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtscreen.Text);
            double Osum, Ores, Omult, Odividir;

            switch (operador)
            {
                case "+": Osum = sum.Sumar((primero), (segundo));
                    txtscreen.Text = Osum.ToString();
                    break;
                case "-":
                    Ores = res.Restar((primero), (segundo));
                    txtscreen.Text = Ores.ToString();
                    break;
                case "*":
                    Omult = mult.Multiplicar((primero), (segundo));
                    txtscreen.Text = Omult.ToString();
                    break;
                case "/":
                    Odividir = dividir.Dividir((primero), (segundo));
                    txtscreen.Text = Odividir.ToString();
                    break;
            }
        }

        private void btnblanquear_Click(object sender, EventArgs e)
        {
            txtscreen.Clear();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text.Length == 1)
                txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text.Substring(0, txtscreen.Text.Length - 1);
        }
    }
}