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
    }
}
