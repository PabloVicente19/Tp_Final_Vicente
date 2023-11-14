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

    }
}
