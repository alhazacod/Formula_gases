using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula_gases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ley_boyle : ContentPage
    {
        public Ley_boyle()
        {

            InitializeComponent();

            buttonResolver.Clicked += ButtonResolver_Clicked;
        }

        private void ButtonResolver_Clicked(object sender, EventArgs e)
        {
            double v1;
            double v2;
            double p1;
            double p2;
            try
            {
                if (string.IsNullOrEmpty(entryV1.Text))//deseamos obtener el valor de v1
                {

                    if (!string.IsNullOrEmpty(entryV2.Text) &&
                       !string.IsNullOrEmpty(entryP1.Text) &&
                       !string.IsNullOrEmpty(entryP2.Text))
                    {
                        try
                        {
                            v2 = Convert.ToDouble(entryV2.Text);
                            p1 = Convert.ToDouble(entryP1.Text);
                            p2 = Convert.ToDouble(entryP2.Text);
                            v1 = (v2 * p2) / p1;
                            entryV1.Text = v1.ToString();
                        }
                        catch
                        {
                            DisplayAlert("Ha ocurrido un error", "Por favor verifica que todos los campos esten escritos correctamente", "Aceptar");
                        }
                    }
                    else
                    {
                        DisplayAlert("Ha ocurrido un error", "Solo puedes dejar un espacio en blanco", "Aceptar");
                    }
                }//deseamos obtener el valor de v1
                else if (string.IsNullOrEmpty(entryV2.Text))//deseamos obtener el valor de v2
                {
                    v1 = Convert.ToDouble(entryV1.Text);
                    p1 = Convert.ToDouble(entryP1.Text);
                    p2 = Convert.ToDouble(entryP2.Text);
                    if (!string.IsNullOrEmpty(entryV1.Text) &&
                       !string.IsNullOrEmpty(entryP1.Text) &&
                       !string.IsNullOrEmpty(entryP2.Text))
                    {
                        try
                        {
                            v2 = (v1 * p1) / p2;
                            entryV2.Text = v2.ToString();
                        }
                        catch
                        {
                            DisplayAlert("Ha ocurrido un error", "Por favor verifica que todos los campos esten escritos correctamente", "Aceptar");
                        }
                    }
                    else
                    {
                        DisplayAlert("Ha ocurrido un error", "Solo puedes dejar un espacio en blanco", "Aceptar");
                    }
                }//deseamos obtener el valor de v2
                else if (string.IsNullOrEmpty(entryP1.Text))//deseamos obtener el valor de p1
                {
                    v1 = Convert.ToDouble(entryV1.Text);
                    v2 = Convert.ToDouble(entryV2.Text);
                    p2 = Convert.ToDouble(entryP2.Text);
                    if (!string.IsNullOrEmpty(entryV1.Text) &&
                       !string.IsNullOrEmpty(entryV2.Text) &&
                       !string.IsNullOrEmpty(entryP2.Text))
                    {
                        try
                        {
                            p1 = (v2 * p2) / v1;
                            entryP1.Text = p1.ToString();
                        }
                        catch
                        {
                            DisplayAlert("Ha ocurrido un error", "Por favor verifica que todos los campos esten escritos correctamente :V", "Aceptar");
                        }
                    }
                    else
                    {
                        DisplayAlert("Ha ocurrido un error", "Solo puedes dejar un espacio en blanco", "Aceptar");
                    }
                }//deseamos obtener el valor de p1
                else if (string.IsNullOrEmpty(entryP2.Text))//deseamos obtener el valor de p2
                {
                    v1 = Convert.ToDouble(entryV1.Text);
                    v2 = Convert.ToDouble(entryV2.Text);
                    p1 = Convert.ToDouble(entryP1.Text);
                    if (!string.IsNullOrEmpty(entryV1.Text) &&
                       !string.IsNullOrEmpty(entryV2.Text) &&
                       !string.IsNullOrEmpty(entryP1.Text))
                    {
                        try
                        {
                            p2 = (v1 * p1) / v2;
                            entryP2.Text = p2.ToString();
                        }
                        catch
                        {
                            DisplayAlert("Ha ocurrido un error", "Por favor verifica que todos los campos esten escritos correctamente", "Aceptar");
                        }
                    }
                    else
                    {
                        DisplayAlert("Ha ocurrido un error", "Solo puedes dejar un espacio en blanco", "Aceptar");
                    }
                }//deseamos obtener el valor de p2
                else
                {
                    DisplayAlert("Ha ocurrido un error", "Por favor verifica que todos los campos esten escritos correctamente", "Aceptar");
                }
            }
            catch
            {
                DisplayAlert("Error","Por favor revisa que los valores sean solo numeros","Ok");
            }
        }
    }
}
