using System;
using System.Web;
using System.Web.UI;
using BLL.Model;
using DAL.Persistence;
using System.Threading;

namespace View.Pages
{
    public partial class PaiCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = "Iniciando o Cadastro";
        }
        protected void btnCadastrarPai(object sender, EventArgs e)
        {
            try
            {
                Pai pai = new Pai();
                pai.Nome = nome.Text;


                PaiDal paiDal = new PaiDal();
                paiDal.Salvar(pai);

                nome.Text = "";


                string msg = "Pai " + pai.Nome +
                             " - Cadastrado com Sucesso,";

                lblMensagem.Attributes.CssStyle.Add("color", "green");

                lblMensagem.Text = msg;

                //Thread.Sleep(5000);

                //Response.Redirect("/Pages/PaiCadastro.aspx");

            }
            catch (Exception erro)
            {
                lblMensagem.Text = erro.ToString();
            }
        }
    }
}
