using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
namespace PC_info.Customed_Elements
{
    internal class DataGridViewDiskSizeGBProgressColumn : DataGridViewImageColumn
    {
        public DataGridViewDiskSizeGBProgressColumn()
        {
            CellTemplate = new DataGridViewDiskSizeGBProgressCell();
        }

        class DataGridViewDiskSizeGBProgressCell : DataGridViewImageCell
        {

            static Image emptyImage;
            static DataGridViewDiskSizeGBProgressCell()
            {
                emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            }
            public DataGridViewDiskSizeGBProgressCell()
            {
                this.ValueType = typeof(int);
            }

            protected override object GetFormattedValue(object value,
                                int rowIndex, ref DataGridViewCellStyle cellStyle,
                                TypeConverter valueTypeConverter,
                                TypeConverter formattedValueTypeConverter,
                                DataGridViewDataErrorContexts context)
            {
                return emptyImage;
            }

            protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                SizeGB size = null;

                if (value != null)
                    size = value as SizeGB;


                double percentage = size != null ? ((size.Total - size.Free) / size.Total) : 0.00; 

                Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);
                // Draws the cell grid
                base.Paint(g, clipBounds, cellBounds,
                 rowIndex, cellState, value, formattedValue, errorText,
                 cellStyle, advancedBorderStyle, paintParts & ~DataGridViewPaintParts.ContentForeground);
                if (size == null)
                {
                    g.DrawString($"undefined", cellStyle.Font, foreColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
                    return;
                }
                if (percentage > 0.0)
                {
                    // Draw the progress bar and the text
                    g.FillRectangle(new SolidBrush(Color.FromArgb(0, 189, 230)), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToInt32((percentage * cellBounds.Width - 4)), cellBounds.Height - 4);
                    g.DrawString($"{size} ({percentage * 100:0.00}%)", cellStyle.Font, foreColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
                }
                else
                {
                    // draw the text
                    if (this.DataGridView.CurrentRow.Index == rowIndex)
                        g.DrawString($"{size} ({percentage * 100:0.00}%)", cellStyle.Font, new SolidBrush(cellStyle.SelectionForeColor), cellBounds.X + 6, cellBounds.Y + 2);
                    else
                        g.DrawString($"{size} ({percentage * 100:0.00}%)", cellStyle.Font, foreColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
                }
            }
        }
    }

}
