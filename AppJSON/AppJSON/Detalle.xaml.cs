using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppJSON
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalle : ContentPage
    {
        public Detalle( Productos itemData)
        {
            InitializeComponent();
            lblName.Text = itemData.pro_nombre;
            lblDesc.Text = itemData.pro_descripcion;
            lblPrecio.Text = "Q" + itemData.pro_preciou;
            lblCantidad.Text = itemData.pro_cantidad;
            if (itemData.pro_estado == "1")
            {
                lblEstado.Text = "Existencia";
            }
            else
            {
                lblEstado.Text = "No disponible";
            }
            
        }
    }
}