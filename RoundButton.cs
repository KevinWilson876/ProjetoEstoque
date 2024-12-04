using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstoque
{
    internal class RoundButton : Button
    {
        public int BorderRadius { get; set; } = 50; // Valor padrão para o raio das bordas
        
        protected override void OnPaint(PaintEventArgs pevent) 
        { 
            base.OnPaint(pevent); 
            
            int diameter = BorderRadius * 2; 
            GraphicsPath graphicsPath = new GraphicsPath();

            // Desenhar as bordas arredondadas
            graphicsPath.AddArc(0, 0, diameter, diameter, 180, 90); // Superior esquerdo
            graphicsPath.AddArc(this.Width - diameter, 0, diameter, diameter, 270, 90); // Superior direito
            graphicsPath.AddArc(this.Width - diameter, this.Height - diameter, diameter, diameter, 0, 90); // Inferior direito
            graphicsPath.AddArc(0, this.Height - diameter, diameter, diameter, 90, 90); // Inferior esquerdo
            graphicsPath.CloseAllFigures(); 
            
            this.Region = new Region(graphicsPath);
            
            Pen pen = new Pen(Color.Transparent, 0); 
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias; 
            pevent.Graphics.DrawPath(pen, graphicsPath);
                     
        }
    }
}
