namespace _18a_WinFormsApp_Entity_CodeFirst
{
    public partial class Form1 : Form
    {
        PacienteContext _contexto = new PacienteContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            textBox_nomePaciente.Text = String.Empty;
            textBox_email.Text = String.Empty;
        }


        public bool ValidaAcao()
        {
            if (string.IsNullOrWhiteSpace(textBox_nomePaciente.Text))
                return false;
            else
                return true;
        }


        private void carregarListView()
        {
            try
            {
                //listar contexto

                listView_pacientes.Items.Clear();
                int i = 0;
                //repeticao na lista de pacientes do contexto
                //while ()
                //{
                //    listView_pacientes.Items.Add(leitor["idPaciente"].ToString());
                //    listView_pacientes.Items[i].SubItems.Add(leitor["nome"].ToString());
                //    listView_pacientes.Items[i].SubItems.Add(leitor["email"].ToString());
                //    i++;
                //}               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de Conex�o com o Banco " + ex.Message, "Alerta");
            }
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            panel_campos.Enabled = true;




        }

        private void button_deletar_Click(object sender, EventArgs e)
        {

            try
            {                
                int idPaciente = int.Parse(listView_pacientes.SelectedItems[0].Text);

                //pesquisar no contexto
                
                this.limparCampos();
                //recarregar ListView
                this.carregarListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas de Conex�o com o Banco " + ex.Message, "Alerta");
            }



        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            panel_campos.Enabled = true;




        }

        private void button_salvar_Click(object sender, EventArgs e)
        {

            if (ValidaAcao())
            {

                Paciente paciente = new Paciente(textBox_nomePaciente.Text, textBox_email.Text);

                _contexto.Add(paciente);
                _contexto.SaveChanges();


            }

            //capturar valores das vari�veis

            string nome = textBox_nomePaciente.Text;
            string email = textBox_email.Text;





            this.limparCampos();
            panel_campos.Enabled = false;
        }
    }
}