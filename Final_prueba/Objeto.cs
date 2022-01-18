using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_prueba
{
    class Objeto
    {
        public Objeto(string mensaje)
        {
            this.mensaje = mensaje;
        }
        public Objeto(string mensaje,string imagen)
        {
            this.mensaje = mensaje;                     //Creamos una clase que sea un objeto con una imagen y un mensaje
            this.imagen = imagen;
        }
        public string mensaje { get; private set; }
        public string imagen { get; private set; }
        public void Setimagen(string value)
        {
            imagen = value;
        } 
        public void SetMensaje(string value)
        {
            mensaje = value;
        }
    }
    class Meta : Objeto //Creamos una clase que sea la meta y que herede de Objeto
    {
        public Meta(int puntos_win,int puntos, string mensaje = "Meta") :base( mensaje)
        {
            SetMensaje(mensaje);
            this.puntos = puntos;
            this.puntos_win = puntos_win;
        }
        public int puntos { get; private set; }
        public int puntos_win { get; private set; }
        public void GetPuntos()
        {
            puntos = 0;         
        }
    }
}
