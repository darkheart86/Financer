using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_Test
{
    public class EstilosDGView : Control
    {
        
        public System.Windows.Forms.DataGridViewCellStyle LinhaFinal = new System.Windows.Forms.DataGridViewCellStyle();
        public EstilosDGView()
        {
            LinhaFinal.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            LinhaFinal.BackColor = System.Drawing.Color.Coral;
            LinhaFinal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LinhaFinal.ForeColor = System.Drawing.SystemColors.ControlText;
            LinhaFinal.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            LinhaFinal.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            LinhaFinal.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        }
       
    }
}
