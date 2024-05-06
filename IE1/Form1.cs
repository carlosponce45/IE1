namespace IE1
{
    public partial class Form1 : Form
    {
        int cont = 0;

        Cola guardia = new Cola();
        Cola pediatra = new Cola();
        Cola clinica = new Cola();
        frmClinica f2 = new frmClinica();
        frmGuardia f3 = new frmGuardia();
        frmPediatría f4 = new frmPediatría();
        public Form1()
            {
            InitializeComponent();
            f2.Show();
            f3.Show();
            f4.Show();
            guardia.Listar(lstGuardia);
            pediatra.Listar(lstPediatria);
            clinica.Listar(lstClinica);
            }

        private void cmdLlamar_Click(object sender, EventArgs e)
        {
            NodoArchivo nuevo = new NodoArchivo(txtArchivo.Text);
            switch (comboBox1.Text)
            {
                case "CLINICA":
                    clinica.Insertar(nuevo);
                    clinica.Listar(lstClinica);
                    break;
                case "GUARDIA":
                    guardia.Insertar(nuevo);
                    guardia.Listar(lstGuardia);
                    break;
                case "PEDIATRIA":
                    pediatra.Insertar(nuevo);
                    pediatra.Listar(lstPediatria);
                    break;
            }
        }
        }
    }
