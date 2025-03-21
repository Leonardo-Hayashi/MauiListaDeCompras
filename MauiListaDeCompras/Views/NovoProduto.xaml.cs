using MauiListaDeCompras.Models;

namespace MauiListaDeCompras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao  = txt_Descricao.Text,
				Quantidade  = Convert.ToDouble(txt_Quantidade.Text),
				Preco = Convert.ToDouble(txt_Preco.Text)
			};
			
			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Registro Inserido", "OK"); 

		} catch(Exception ex)
		{
            await DisplayAlert("Oops", ex.Message, "OK");
        }
    }
}