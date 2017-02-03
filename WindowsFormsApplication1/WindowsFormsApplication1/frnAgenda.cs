using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;


namespace WindowsFormsApplication1
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            //pesquisa de CEP
            DataSet ds = new DataSet();

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", mskcep.Text);
            ds.ReadXml(xml);
            if (ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep completo" || ds.Tables[0].Rows[0]["resultado_txt"].ToString() == "sucesso - cep único")
            {
                txtendereco.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                cboestado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                txtnumero.Focus();
            }
            else
            {
                MessageBox.Show("CEP não Encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {

        }

        private void frmAgenda_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //envia TAB quando for pressionado enter
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void tstSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tstSalvar_Click(object sender, EventArgs e)
        {

        }
    }
  
}
