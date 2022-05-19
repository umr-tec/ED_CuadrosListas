using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ED_Ejemplo4_Cuadros
{
    public partial class DibujarPanel : Panel
    {
        //Guardamos los objetos en una lista
        private List<Dibujar> dibuja = new List<Dibujar>();        
        private Dibujar arrastrarDibujo = null;
        Point pPoint;

        //Propiedad para Quitar el parpadeo
        public new bool DoubleBuffered
        {
            get { return base.DoubleBuffered; }
            set { base.DoubleBuffered = value; }
        }

        //Metodo para pintar el findo del panel
        private void PintarFondoPanel(Graphics g)
        {
            using (Brush brush = new LinearGradientBrush(ClientRectangle, Color.Aqua, Color.YellowGreen, 245))
            {
                g.FillRectangle(brush, ClientRectangle);
            }
        }

        //Determinar las caractetisticas de lo que qeuiero dibujar
        private void DibujarFugura(Graphics g)
        {
            foreach (Dibujar dibujo in dibuja)
            {
                if (arrastrarDibujo != dibujo)
                {
                    dibujo.DibujaREctangulo(g);
                }
            }
        }

        //Sobreescribir un metodo para dibujar 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PintarFondoPanel(e.Graphics);
            DibujarFugura(e.Graphics);
        }

      

        //Mover los cuadros
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (arrastrarDibujo != null)
            {
                Point dif = new Point(e.Location.X - pPoint.X, e.Location.Y - pPoint.Y);
                Point locacion = arrastrarDibujo.Locacion;
                locacion.Offset(dif);
                arrastrarDibujo.Locacion = locacion;
                pPoint = e.Location;
                Refresh();

            }
        }

        //Dibujar cuadros al dar click sobre el componente, se manda llamar la clase
        //Dibujar, mediante el objeto miDibujo
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            for (int i = dibuja.Count -1; i  >= 0; i--) 
            {
                if (dibuja[i].ProbarPosicion(e.Location)) //== true
                {
                    pPoint = e.Location;
                   // arrastrarDibujo = dibuja[i];
                    return;
                }
            }
            //Dibujando el cuadrito y guardandolo en la lista
            Dibujar miDibujo = new Dibujar(e.Location);            
            dibuja.Add(miDibujo);
            Refresh();
        }

        //Eliminar los cuadros dibujados al dar un doble click sobre el componente
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            dibuja.Clear();
            Refresh();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            arrastrarDibujo = null;
            Refresh();
        }

    }
}
