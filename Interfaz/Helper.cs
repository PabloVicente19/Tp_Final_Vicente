﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public static class Helper
    {
        public static void CargarImagen(PictureBox pictureBox,string imagen)
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
        public static void OcultarCamposEnDgb(DataGridView unDataGrid,string columna)
        {
            unDataGrid.Columns[columna].Visible = false;
        }
        public static bool ValidarTextBox(TextBox textBox, string mensaje) 
        {
            bool valid = false;
            if (textBox.Text.Length > 2)
                 valid = true;
            else
            {
               MessageBox.Show("¡El "+ mensaje +" es Obligatorio");
            }
            return valid;
        }
        public static bool ValidarImagen(TextBox textBox)
        {
            bool valid = false;

            if(ValidarImagen(textBox) == true)
            {
                valid = true;
            }

            return valid;
        }
    }
}
