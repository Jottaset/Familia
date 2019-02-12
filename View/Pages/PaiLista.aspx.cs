using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Model;
using DAL.Persistence;

namespace View.Pages
{

    public partial class PaiLista : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            //PaiDal paiDal = new PaiDal();
            //gridListaPai.DataSource = paiDal.Listar();
            //gridListaPai.DataBind();

        }



        public void btnPesquisarPai(object sender, EventArgs e)
        {
            string nomePai = nome.Text;
            PaiDal paiDal = new PaiDal();

            gridListaPai.DataSource = paiDal.PesquisarPorNome(nomePai);
            gridListaPai.DataBind();


        }




    }
}