using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlIndexManager.Net461.Helpers
{
    public static class DataGridViewExtensions
    {
        public static DataGridViewColumn GetCol(this DataGridViewColumnCollection cols, string caption)
        {
            foreach (DataGridViewColumn item in cols)
                if (item.Name == caption)
                    return item;
            throw new KeyNotFoundException($"Column not found ({caption})");
        }

        public static void SetDefaultCellStyle(this DataGridViewColumnCollection cols,
            Color readOnlyColor)
        {
            foreach (DataGridViewColumn col in cols)
            {
                col.DefaultCellStyle.Font = new Font("Consolas", 8.25f);
                if (col.ReadOnly)
                    col.DefaultCellStyle.BackColor = readOnlyColor;


                if (col.ValueType.Name == "String")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                }

                if (col.ValueType.Name == "Int32")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    col.DefaultCellStyle.Format = "N0";
                }

                if (col.ValueType.Name == "Decimal")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    col.DefaultCellStyle.Format = "#,##";
                }
                if (col.ValueType.Name == "Double")
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                    col.DefaultCellStyle.Format = "#,##0.00";
                }
                Debug.Print(col.ValueType.Name);
            }
        }
        public static void DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, new Font("Lucida Console", 8.25f), SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
