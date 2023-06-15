using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PaintFigurasV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //se invoca al metodo que cambia el tamaño del pictureBox
            ResizePicture();
        }

        Bitmap bmp;
        //bool allowResize = false;
        bool dibujar = false;
        Point inicio, fin;
        Point yPosition, xPosition;
        Graphics g;
        int opcion = 0;
        int clicks = 0;
        int x1, y1, x2, y2, x3, y3;

        //para los puntos del triangulo
        int x1T, y1T, x2T, y2T, x3T, y3T;
        


        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 3;
        }

        private void rectánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 4;
        }


        //se crea un nuevo lienzo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = "¿Desea guardar los cambios?";
            String titleWindows = "Mensaje emergente";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titleWindows, buttons);
            if (result == DialogResult.Yes)
            {
                GuardarImagen();
                ResizePicture();
                g.Clear(Color.White);
            }
            else
            {
                ResizePicture();
                g.Clear(Color.White);
            }

        }


        //guarda el lienzo
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarImagen();
        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 5;
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 6;
        }

        private void trapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 7;
        }

        //el evento se activa cuando el cursor esta dentro del pictureBox y se pulsa sobre estes
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //cuando se pulsa sobre el lienzo, entonces es posible dibujar
            dibujar = true;
            //la variable tipo Point --yPosition, almacena las coordenadas de donde se hizo clic
            yPosition = e.Location;

            //obtiene la posicion de X y Y, y las guarda en variables separadas
            //son las coordenadas para definir la posicion de la elipse y el rectangulo
            x2 = e.X;
            y2 = e.Y;

            //si el boton izquierdo es pulsado, las variables de inicio y fin, obtienen la posicion del cursor
            if (e.Button == MouseButtons.Left)
                inicio = fin = e.Location;

        }


        //el evento se genera cuando existe movimiento sobre este
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujar)
            {
                //la variable de tipo Point --xPosition, almacena la posicion del cursor 
                xPosition = e.Location;
                //se invocan una serie de opciones
                Opciones();
                //la posicion de X y Y, sera igual para generar una "rayones" hechos por el mouse
                yPosition = xPosition;

                //se realiza el redibujo con Invalidate(), pero solo cuando el sistema puede
                if (e.Button == MouseButtons.Left)
                    Invalidate();
            }

            //despues de cada que se pulse la tecla, Refresh(), actualizara el pictureBox
            pic.Refresh();

            //almacenan posicion
            x1 = e.X;
            y1 = e.Y;

            //establecen el ancho y el alto, son ocupadas para el rectangulo y la elipse
            x3 = e.X - x2;
            y3 = e.Y - y2;

        }


        //el evento se genera cada que se da clic al pictureBox
        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            //se dibujan las lineas unicamente si se pulso el apartado de triangulo
            if (opcion == 5)
            {
                //si el residuo de la division entre 3 es igual a 0, se obtienen las coordenadas del primer clic
                if (clicks % 3 == 0)
                {
                    x1T = e.X;
                    y1T = e.Y;
                }
                //si el residuo de la division entre 3 es igual a 1, se obtienen las coordenadas del segundo clic
                else if (clicks % 3 == 1)
                {
                    x2T = e.X;
                    y2T = e.Y;

                    g.DrawLine(new Pen(Color.Black, 2), x1T, y1T, x2T, y2T);
                }
                //si el residuo de la division entre 3 es igual a 2, se obtienen las coordenadas del tercer clic
                else if (clicks % 3 == 2)
                {
                    x3T = e.X;
                    y3T = e.Y;

                    g.DrawLine(new Pen(Color.Black, 2), x1T, y1T, x3T, y3T);
                    g.DrawLine(new Pen(Color.Black, 2), x2T, y2T, x3T, y3T);
                }
                //se incrementa el contador, para localizar las coordenadas y la cantidad de triangulo que se realizan (3 puntos por triangulo)
                clicks++;
            }
            
            //Console.WriteLine(clicks);

        }

        private void lapizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 1;
        }

        private void borradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opcion = 2;
        }



        //el evento se genera cuando el cursor esta dentro del picture, se da clic y luego se suelta
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            dibujar = false;

            //se realiza el calculo para obtener el ancho y el alto del rectangulo y elipse
            //se toma la primera posicion del cursor y se resta con la segunda
            x3 = x1 - x2;
            y3 = y1 - y2;

            //coordenadas, ancho y alto
            if (opcion == 3)
                g.DrawEllipse(new Pen(Color.Black, 2), x2, y2, x3, y3);
            else if (opcion == 4)
                g.DrawRectangle(new Pen(Color.Black, 2), x2, y2, x3, y3);
            else if (opcion == 6)
                Rombo();
            else if (opcion == 7)
                Pentagono();

        }

        //---------------------------------------------------------------------------------------------------------------


        //metodo encargado de cambiar el tamaño del picturebox de acuerdo a medidas establecidas por el usuario
        public PictureBox ResizePicture()
        {
            int width = 0, height = 0;

            //se le pide al usuario que introduzca el ancho y el alto por medio de un mensaje en pantalla
            width = Convert.ToInt32(Interaction.InputBox("Width: "));
            height = Convert.ToInt32(Interaction.InputBox("Height: "));

            //el picturebox toma las medidas indicadas por el usuario
            pic.Size = new Size(width, height);
            //el mapa de bits tambien declara su tamaño a partir de las medidas del pictureBox
            bmp = new Bitmap(pic.Width, pic.Height);
            //panel1_Resize(this, null);

            //dibuja la imagen
            g = Graphics.FromImage(bmp);
            //borra la superficie de dibujo y la pone en color blanco
            g.Clear(Color.White);
            //se crea el mapa de bits en tiempo de ejecucion y se muestra en el pictureBox
            //se establece la imagen en el picture
            pic.Image = bmp;

            //retorna el pictureBox
            return pic;
        }


        //Guarda el lienzo en formato .jpg
        private void GuardarImagen()
        {
            //se crea y almacena un nuevo cuadro de dialogo de tipo SaveFile
            var saveImage = new SaveFileDialog();
            //se establece un filtro para la extension que tendra la imagen, en este caso, solo sera jpg
            //para png, solo modificar
            saveImage.Filter = "Image(*.jpg) | *.jpg | (*.*|*.*";
            //si el usuario da clic sobre el boton de confirmacion del cuadro de dialogo, entonces se realizan
            //las instrucciones dentro del if
            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                //se guarda el mapa de bits que contiene todos los pixeles de lo que se dibujo en el lienzo
                bmp.Save(saveImage.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Imagen guardada.");
            }
        }


        //son generadas cuando el clic derecho no se suelta
        //ocupados en el evento de mouseDown
        private void Opciones()
        {
            //la primera opcion corresponde a un lapiz que dibujara lineas a partir de la posiciones en la
            //que se encuentre el cursor, siempre y cuando no se suelve
            //la segunda opcion es un borrador, similar al lapiz, solo que de color blanco para simular el borrado
            if (opcion == 1)
                g.DrawLine(new Pen(Color.Black, 2), xPosition, yPosition);
            else if (opcion == 2)
                g.DrawLine(new Pen(Color.White, 4), xPosition, yPosition);
        }

        /*private void Triangulo() {

            fin = PointToClient(MousePosition);

            double xMid = (inicio.X + fin.X) / 2;


            Point first = new Point(inicio.X, fin.Y);
            Point mid = new Point((int)xMid, inicio.Y);

            g.DrawLine(new Pen(Color.Black, 2), first, mid);
            g.DrawLine(new Pen(Color.Black, 2), first, fin);
            g.DrawLine(new Pen(Color.Black, 2), fin, mid);
        }*/


        //metodo para crear un rombo
        private void Rombo()
        {
            //se define un punto de acuerdo a las coordenadas del cursor del usuario
            fin = PointToClient(MousePosition);
            

            //se crea un punto con la diferencias entre coordenas iniciales y finales repecto a X o Y
            Point difPuntos3 = new Point(inicio.X, (fin.Y - inicio.Y) + fin.Y);
            //nuevamente se obtiene la diferencia para obtener los picos del rombo
            Point difPuntos4 = new Point(inicio.X - (fin.X - inicio.X), fin.Y);


            g.DrawLine(new Pen(Color.Black, 2), inicio, fin);
            g.DrawLine(new Pen(Color.Black, 2), fin, difPuntos3);
            g.DrawLine(new Pen(Color.Black, 2), difPuntos3, difPuntos4);
            g.DrawLine(new Pen(Color.Black, 2), difPuntos4, inicio);
        }


        //metodo para crea un pentagono
        private void Pentagono()
        {
            fin = PointToClient(MousePosition);

            g.DrawLine(new Pen(Color.Black, 2), inicio, fin);

            Point difPuntos3 = new Point(((inicio.X - fin.X)/2) + inicio.X, (fin.Y - inicio.Y) + fin.Y);
            Point prueba = new Point(((inicio.X - fin.X)/2) + fin.X, (fin.Y - inicio.Y) + fin.Y);
            Point difPuntos4 = new Point(inicio.X - (fin.X - inicio.X), fin.Y);

            g.DrawLine(new Pen(Color.Black, 2), inicio, fin);
            g.DrawLine(new Pen(Color.Black, 2), fin, prueba);
            g.DrawLine(new Pen(Color.Black, 2), difPuntos3, prueba);
            g.DrawLine(new Pen(Color.Black, 2), difPuntos3, difPuntos4);
            g.DrawLine(new Pen(Color.Black, 2), difPuntos4, inicio);

        }
    }
}
