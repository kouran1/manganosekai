using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace manganosekai
{
    class classViaCep
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public static async void BuscarCep(string cep, TextBox endereco, TextBox bairro, TextBox cidade, ComboBox uf, TextBox numero, Form form)
        {
            cep = cep.Replace("-", "").Replace(" ", "").Trim();
            if (cep.Length != 8) return;

            try
            {
                form.Cursor = Cursors.WaitCursor;
                string resposta = await httpClient.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
                dynamic json = JObject.Parse(resposta);

                if (json.erro != null)
                {
                    MessageBox.Show("CEP não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                endereco.Text = json.logradouro;
                bairro.Text = json.bairro;
                cidade.Text = json.localidade;

                string estado = json.uf.ToString();
                if (!uf.Items.Contains(estado)) uf.Items.Add(estado);
                uf.SelectedItem = estado;

                numero.Focus();
            }
            catch
            {
                MessageBox.Show("Erro ao buscar CEP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                form.Cursor = Cursors.Default;
            }
        }
    }
}
