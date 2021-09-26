using System;

namespace QuizLibrary
{
    public class Respuesta
    {
        private string _respuesta;
        private bool _correcta;

        public Respuesta(string respuesta, bool correcta = false)
        {
            this.respuesta = respuesta;
            this.correcta = correcta;
        }

        public string respuesta { set; get; }
        public bool correcta { set; get; }
    }
}
