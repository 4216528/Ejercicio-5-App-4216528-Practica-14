namespace Ejercicio5;

public partial class MainPage : ContentPage

{

	public MainPage()

	{

		InitializeComponent();

	}

    ///<Summary>
    ///<Createddate>06-07-2023</Createddate>
    ///<company>SandBox</company>
    ///<lastmodificationdate>06-07-2023</lastmodificationdate>
    ///<lastmodificationdescription>Ninguna</lastmodificationdescription>
    ///<lastmodifierautor>Nery</lastmodifierautor>
    ///</Summary>

    private void OnCounterClicked(object sender, EventArgs e)

	{

        // Creamos una nueva funcion, declaramos las bariables A, B, P Y BR y procedemos a hacer las operaciones necesarias //

        double A = double.Parse(AlturaEntry.Text);

        double B = double.Parse(BaseEntry.Text);

        double P = 2 * (B + A); ResultadoPerimetro.Text = P.ToString(); 

        double BR = B * A; ResultadoSuperficie.Text = BR.ToString();

    }

}


