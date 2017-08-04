using Fiap.PlataformaNet.ConceitosCSharp.Classes.Dados;
using Fiap.PlataformaNet.ConceitosCSharp.Dados;
using System;
using System.Windows.Forms;

namespace Fiap.PlataformaNet.ConceitosCSharp.WindowsApp
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void incluirEventoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var data = DateTime.Parse(dataMaskedTextBox.Text);
                var descricao = descricaoTextBox.Text;
                var responsavel = responsavelTextBox.Text;

                var evento = new Evento()
                {
                    Data = data,
                    Descricao = descricao,
                    Responsavel = responsavel
                };

                var dao = new DaoEventos();
                dao.Incluir(evento);

                AtualizarListaEventos();

                MessageBox.Show("Evento incluido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListaEventos()
        {
            eventoComboBox.Items.Clear();

            var dao = new DaoEventos();
            var eventos = dao.Listar();

            foreach (var item in eventos)
            {
                eventoComboBox.Items.Add(item);
            }
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            AtualizarListaEventos();
            AtualizarListaConvidados();
        }

        private void incluirConvidadoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (eventoComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Informe o evento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                var nome = nomeTextBox.Text;
                var email = emailTextBox.Text.ValidarEmail();
                var eventoId = ((Evento)eventoComboBox.SelectedItem).Id;

                var convidado = new Convidado()
                {
                    Nome = nome,
                    Email = email,
                    InfoEvento = new Evento()
                    {
                        Id = eventoId
                    }
                };

                var dao = new DaoConvidado();
                dao.Incluir(convidado);

                nomeTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;

                AtualizarListaConvidados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void responsavelTextBox_Leave(object sender, EventArgs e)
        {
            responsavelTextBox.Text = responsavelTextBox.Text.RetirarAcentos();
        }

        private void nomeTextBox_Leave(object sender, EventArgs e)
        {
            nomeTextBox.Text = nomeTextBox.Text.RetirarAcentos();
        }

        private void AtualizarListaConvidados()
        {
            var dao = new DaoConvidado();
            var convidados = dao.Listar();

            convidadosListBox.Items.Clear();

            foreach (var item in convidados)
            {
                convidadosListBox.Items.Add(item);
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listarPorEventoButton_Click(object sender, EventArgs e)
        {
            if (eventoComboBox.SelectedItem == null)
            {
                MessageBox.Show("Informe o evento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            var eventoId = ((Evento)eventoComboBox.SelectedItem).Id;

            var dao = new DaoConvidado();
            var convidados = dao.Listar(eventoId);

            convidadosListBox.Items.Clear();

            foreach (var item in convidados)
            {
                convidadosListBox.Items.Add(item);
            }
        }
    }
}
