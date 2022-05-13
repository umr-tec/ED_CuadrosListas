using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ED_Ejemplo4_Cuadros
{
    class Dibujar
    {
        //Determinar los miembros de tipo camcpo globales
        private Rectangle rectangulo;
        private Color fillColor = Color.White;
        static Random rnd = new Random();

        //Agregar un miembro de tipo constructor para inicializar el objeto
        public Dibujar(Point locacion)
        {
            rectangulo = new Rectangle(locacion, new Size(40, 40));
            //Un color
            fillColor = ColorAleatorio();
        }

        //Agregar un miembrop dr tipo prpiedad para estar cambiando mas una vez los puntos
        public Point Locacion
        {
            get { return rectangulo.Location; }
            set { rectangulo.Location = value; }
        }

        //Agregar un miembro de tio metodo para cargar el color aleatorio
        public static Color ColorAleatorio()
        {
            return Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }

        //Dibujar el rectangulo
        public void DibujaREctangulo(Graphics g)
        {
            using (Brush brush = new SolidBrush(fillColor))
            {
                g.FillRectangle(brush, rectangulo);
                g.DrawRectangle(Pens.Black, rectangulo);
            }
        }
    }
}
