using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace SumaAppMvvm.ViewModels
{
    public partial class FormulaSumaViewModel:ObservableObject
    {
        [ObservableProperty]private string numero1;
        [ObservableProperty] private string numero2;
        [ObservableProperty] private double resultadoSuma;


        private void Alerta(string titulo, string mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(titulo, mensaje, "Aceptar"));
        }

        [RelayCommand] private void CalcularSuma()
        {
            double n1 = 0, n2 = 0;
            if (Double.TryParse(Numero1,out n1)==false)
            {
                Alerta("Advertencia", "Ingresa un valor numérico en el ingreso del número 1");
            }
            else if (Double.TryParse(Numero2, out n2) == false)
            {
                Alerta("Advertencia", "Ingresa un valor numérico en el ingreso del número 2");
            }
            else
            {
                ResultadoSuma = n1 + n2;
            }
        }

        [RelayCommand] private void Limpiar()
        {
            Numero1 = "";
            Numero2 = "";
            ResultadoSuma = 0;
        }

    }

}
