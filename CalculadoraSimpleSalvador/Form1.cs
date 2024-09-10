namespace CalculadoraSimpleSalvador
{
    public partial class Form1 : Form
    {
        //Variables para guardar los valores y operaciones 
        //variales globales
        double valoractual = 0;
        double valoralmacenado = 0;
        char operacion = '\0';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn6.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn3.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn1.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtresultado.Text += btn0.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //valoralmacenado = double.Parse(txtresultado.Text);
            double.TryParse(txtresultado.Text, out valoralmacenado);
            txtresultado.Text = "0";
            operacion = btndiv.Text[0];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double.TryParse(txtresultado.Text, out valoralmacenado);
            txtresultado.Text = "0";
            operacion = btnsuma.Text[0];
            //MessageBox.Show(operacion.ToString(), "");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double.TryParse(txtresultado.Text, out valoralmacenado);
            txtresultado.Text = "0";
            operacion = btnresta.Text[0];
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "0";
            valoralmacenado = 0;
            valoractual = 0;
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            double.TryParse(txtresultado.Text, out valoractual);
            switch (operacion)
            {
                case '+':
                    txtresultado.Text = (valoralmacenado + valoractual).ToString();
                    break;
                case '-':
                    txtresultado.Text = (valoralmacenado - valoractual).ToString();
                    break;
                case '/':
                    txtresultado.Text = (valoralmacenado / valoractual).ToString();
                    break;
                case '*':
                    txtresultado.Text = (valoralmacenado * valoractual).ToString();
                    break;

            }

        }
    }
}
