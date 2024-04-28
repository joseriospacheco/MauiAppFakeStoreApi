using MauiAppFakeStoreApi.Models;
using System.Text.Json;

namespace MauiAppFakeStoreApi.Pages;

public partial class AgregarProductoPage : ContentPage
{
	public AgregarProductoPage()
	{
		InitializeComponent();
	}

    private async void BntAgegarProductoClicked(object sender, EventArgs e)
    {

		var product = new Product();
		product.Title = EntryTitulo.Text;
        product.Price = Convert.ToDecimal(EntryPrecio.Text);
        product.Description = EntryDescripcion.Text;
        product.Category = EntryCategoria.Text;



        var json = JsonSerializer.Serialize(product);
		var content = new StringContent(json);

		using (var client = new HttpClient())
		{
		 	var resp = await client.PostAsync("https://fakestoreapi.com/products", content);

			if (resp.IsSuccessStatusCode) {

				var contentBody = await resp.Content.ReadAsStringAsync();
				var productResult = JsonSerializer.Deserialize<IdProduct>(contentBody);

				await DisplayAlert("Mensaje", $"El producto creado es {productResult.Id} ", "OK");
			}


        }


    }
}