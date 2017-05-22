using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Controller
{
    public class EstilosDGView
    {
        
        public  DataGridViewCellStyle LinhaFinal = new DataGridViewCellStyle();
        public EstilosDGView()
        {
            LinhaFinal.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            LinhaFinal.BackColor = System.Drawing.Color.DarkSlateBlue;
            LinhaFinal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LinhaFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            LinhaFinal.SelectionBackColor = System.Drawing.Color.LightCoral;

            LinhaFinal.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            LinhaFinal.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        }
       
    }
}
