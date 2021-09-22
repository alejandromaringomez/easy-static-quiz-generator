﻿using System;
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

        public void actualizarLista()
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

        private void tsmiExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JavaScript | *.js";
            saveFileDialog1.RestoreDirectory = true;
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (Stream myStream = saveFileDialog1.OpenFile())
                {
                    if (myStream != null)
                    {
                        try
                        {
                            StreamWriter myStreamWriter;
                            using (myStreamWriter = new StreamWriter(myStream, Encoding.UTF8))
                            {
                                string write = "var data = [";
                                for (int i = 0; i < this.preguntas.Count; i++)
                                {
                                    Pregunta item = this.preguntas[i];
                                    write += item.toJS();
                                    if((i + 1) != this.preguntas.Count)
                                    {
                                        write += ",";
                                    }
                                }
                                write += "];";
                                myStreamWriter.Write(write);
                            }
                        } catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error al guardar las preguntas");
                        }
                    }
                }
            }
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
                this.actualizarLista();
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            PreguntaCrear formulario = new PreguntaCrear(this);
            formulario.ShowDialog();
        }

        private void lvPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView item = (ListView)sender;
            bool enabled = item.SelectedItems.Count > 0;
            btnEliminar.Enabled = enabled;
            btnModificar.Enabled = enabled;
        }
    }
}