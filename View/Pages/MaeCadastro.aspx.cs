using System;
using System.Web;
using System.Web.UI;
using BLL.Model;
using DAL.Persistence;
using System.Threading;

namespace View.Pages
{
    public partial class MaeCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = "Iniciando o Cadastro";
        }
        protected void btnCadastrarMae(object sender, EventArgs e)
        {
            try
            {
                Mae mae = new Mae();
                mae.Nome = nome.Text;


                MaeDal maeDal = new MaeDal();
                maeDal.Salvar(mae);

                nome.Text = "";


                string msg = "Mae " + mae.Nome +
                             " - Cadastrado com Sucesso,";

                lblMensagem.Attributes.CssStyle.Add("color", "green");

                lblMensagem.Text = msg;

                //Thread.Sleep(5000);

                //Response.Redirect("/Pages/MaeCadastro.aspx");

            }
            catch (Exception erro)
            {
                lblMensagem.Text = erro.ToString();
            }
        }
    }
}
