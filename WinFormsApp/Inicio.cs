using System;
using System.Windows.Forms;
using System.Collections.Generic;
using QuizLibrary;
using System.IO;
using System.Text;

namespace WinFormsApp
{
    public partial class Inicio : Form
    {
        public List<Pregunta> preguntas;

        public Inicio()
        {
            InitializeComponent();
            this.preguntas = new List<Pregunta>();
        }

        public void actualizarDatos()
        {
            lvPreguntas.Items.Clear();
            foreach(Pregunta pregunta in this.preguntas)
            {
                string[] data =
                {
                    Convert.ToString(pregunta.contarRespuestas()),
                    Convert.ToString(pregunta.contarRespuestasCorrectas())
                };
                ListViewItem item = new ListViewItem(pregunta.pregunta);
                item.SubItems.AddRange(data);
                lvPreguntas.Items.Add(item);
            }
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnNueva.Enabled = true;
        }

        public int buscarPregunta(string pregunta)
        {
            for(int i = 0; i < this.preguntas.Count; i++)
            {
                Pregunta item = this.preguntas[i];
                if(item.pregunta == pregunta)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro/a que desea eliminar las preguntas seleccionadas?", "Confirmación", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                foreach (ListViewItem item in lvPreguntas.SelectedItems)
                {
                    int preguntaIndex = this.buscarPregunta(item.Text);
                    if(preguntaIndex >= 0)
                    {
                        this.preguntas.RemoveAt(preguntaIndex);
                    }
                }
                this.actualizarDatos();
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            PreguntaForm formulario = new PreguntaForm(this);
            formulario.ShowDialog();
        }

        private void lvPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            bool enabled = lv.SelectedItems.Count > 0;
            btnEliminar.Visible = enabled;
            btnModificar.Visible = enabled;
            btnNueva.Enabled = !enabled;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPreguntas.SelectedItems)
            {
                int preguntaIndex = this.buscarPregunta(item.Text);
                if(preguntaIndex >= 0)
                {
                    PreguntaForm formulario = new PreguntaForm(this, this.preguntas[preguntaIndex]);
                    formulario.ShowDialog();
                }
            }
        }

        private string exportarQuizJavascript()
        {
            string cadena = "var data = [";
            for (int i = 0; i < this.preguntas.Count; i++)
            {
                Pregunta item = this.preguntas[i];
                cadena += item.toJS();
                if ((i + 1) != this.preguntas.Count)
                {
                    cadena += ",";
                }
            }
            return cadena + "];";
        }

        private void tsmiExportarQuiz_Click(object sender, EventArgs e)
        {
            if(lvPreguntas.Items.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JavaScript | *.js";
                saveFileDialog.RestoreDirectory = true;
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (Stream myStream = saveFileDialog.OpenFile())
                    {
                        if (myStream != null)
                        {
                            try
                            {
                                StreamWriter streamWriter;
                                using (streamWriter = new StreamWriter(myStream, Encoding.UTF8))
                                {
                                    string contenido = this.exportarQuizJavascript();
                                    streamWriter.Write(contenido);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error al guardar las preguntas");
                            }
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Para exportar el listado de preguntas es necesario que exista al menos una.", "Sin preguntas");
            }
        }
    }
}
