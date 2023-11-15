using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public class Helper
    {
        // CARGA IMAGENES EN UN PICTUREBOX
      public void CargarImagen(PictureBox pictureBox,string imagen)
      {
        string error = "https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg";
        try
        {
          pictureBox.Load(imagen);
        }
        catch (Exception ex)
        {
          pictureBox.Load(error);
        }
      }
        // OCULTA CAMPOS EN UN DATAGRID
        public void OcultarCamposEnDgb(DataGridView unDataGrid,string columna)
        {
            unDataGrid.Columns[columna].Visible = false;
        }

        // 
        public bool ValidarNombre(TextBox textBox) 
        {
            bool valid = false;
            if (textBox.Text.Length > 2)
                 valid = true;
            else
            {
               MessageBox.Show("¡El Nombre es Obligatorio");
            }
            return valid;
        }
        public bool ValidarPrecio(TextBox textBox)
        {
            bool valid = false;
            if(textBox.Text.Length > 0)
            {
                valid = true;
            }
            else
            {
                MessageBox.Show("¡El precio es obligatorio!");
            }
            return valid;
        }
    }
}
