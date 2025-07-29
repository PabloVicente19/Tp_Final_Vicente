using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Helpers
{
    public static class UIHelper
    {
        public static DataGridViewTextBoxColumn[] SetColumsInDataGrid(DataGridViewTextBoxColumn[] columns)
        {
            return columns;
        }
        public static void SetDataGridView<T>(DataGridView dgv, DataGridViewTextBoxColumn[] columns, IEnumerable<T> source)
        {
            dgv.AutoGenerateColumns = false;
            if (dgv.Columns.Count <= 0)
                dgv.Columns.AddRange(SetColumsInDataGrid(columns));
            dgv.DataSource = source.ToList();
            dgv.ClearSelection();
        }
        public static void SetComboBox<T>(ComboBox cmb, IEnumerable<T> source, string displayMember, string valueMember)
        {
            cmb.DataSource = source.ToList();
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }
        public static DialogResult ShowMessage(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(message, title, buttons, icon);
        }
        public static void LoadImage(PictureBox pb, string image)
        {
            string errorImage = "https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg";
            try
            {
                pb.Load(image);
            }
            catch (Exception ex)
            {
                pb.Load(errorImage);
            }
        }
    }
}
