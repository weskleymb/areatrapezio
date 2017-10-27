using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AreaTrapezio.Views
{
    public partial class MainPage : ContentPage
    {

        public float Altura { get; set; }
        public float BaseMaior { get; set; }
        public float BaseMenor { get; set; }
        public float Area { get; set; }

        public void Calcular()
        {
            Area = (BaseMaior + BaseMenor) * Altura / 2;
            OnPropertyChanged(nameof(Area));
        }

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
