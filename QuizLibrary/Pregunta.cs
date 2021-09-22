using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary
{
    public class Pregunta
    {
        private string _pregunta;
        private List<Respuesta> _respuestas;

        public Pregunta(string pregunta)
        {
            this.pregunta = pregunta;
            this.respuestas = new List<Respuesta>();
        }

        public Pregunta(string pregunta, List<Respuesta> respuestas)
        {
            this.pregunta = pregunta;
            this.respuestas = respuestas;
        }

        public string pregunta { set; get; }
        public List<Respuesta> respuestas { set; get; }

        public int buscarRespuesta(string respuesta)
        {
            for (int i = 0; i < this.respuestas.Count; i++)
            {
                Respuesta item = this.respuestas[i];
                if (item.respuesta == respuesta)
                {
                    return i;
                }
            }
            return -1;
        }

        public int contarRespuestasCorrectas()
        {
            int correctas = 0;
            foreach(Respuesta item in this.respuestas)
            {
                if(item.correcta)
                {
                    correctas++;
                }
            }
            return correctas;
        }

        public int contarRespuestas()
        {
            return this.respuestas.Count;
        }

        public string toJS()
        {
            string cadena = "{\"pregunta\": \"" + this.pregunta + "\", \"respuestas\":[";
            for (int i = 0; i < this.respuestas.Count; i++)
            {
                Respuesta respuesta = this.respuestas[i];
                cadena += respuesta.toJS();
                if((i + 1) != this.respuestas.Count)
                {
                    cadena += ",";
                }
            }
            return cadena + "]}";
        }
    }
}
