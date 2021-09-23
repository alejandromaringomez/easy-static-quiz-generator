using System;
using System.Windows.Forms;
using QuizLibrary;

namespace WinFormsApp
{
    public partial class PreguntaForm : Form
    {
        private Inicio formulario;
        private bool esNueva;
        private Pregunta pregunta;

        private void actualizarDatos() {
            lvRespuestas.Items.Clear();
            foreach (Respuesta respuesta in this.pregunta.respuestas)
            {
                ListViewItem item = new ListViewItem(respuesta.respuesta);
                item.Checked = respuesta.correcta;
                lvRespuestas.Items.Add(item);
            }
        }

        public PreguntaForm(Inicio formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
            this.esNueva = true;
            this.pregunta = new Pregunta();
        }

        public PreguntaForm(Inicio formulario, Pregunta pregunta)
        {
            InitializeComponent();
            this.formulario = formulario;
            this.esNueva = false;
            this.pregunta = pregunta;
            txtPregunta.Text = pregunta.pregunta;
            txtPregunta.Enabled = false;
            this.actualizarDatos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("Nueva respuesta");
            lvRespuestas.Items.Add(item);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPregunta.Clear();
            lvRespuestas.Items.Clear();
            txtPregunta.Focus();
        }

        private int contarCorrectas()
        {
            int correctas = 0;
            foreach(ListViewItem item in lvRespuestas.Items)
            {
                if(item.Checked)
                {
                    correctas++;
                }
            }
            return correctas;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPregunta.Text))
            {
                MessageBox.Show("La pregunta es obligatoria.", "Campo requerido");
                txtPregunta.Focus();
            } else
            {
                if(esNueva && this.formulario.buscarPregunta(txtPregunta.Text) >= 0)
                {
                    MessageBox.Show("No es posible repetir la misma pregunta.", "Repetición");
                    txtPregunta.Focus();
                } else
                {
                    if (lvRespuestas.Items.Count < 2)
                    {
                        MessageBox.Show("El mínimo son 2 respuestas.", "Mínimo requerido");
                        btnAdd.Focus();
                    } else
                    {
                        if(this.hayRespuestaRepetida())
                        {
                            MessageBox.Show("Las respuestas no pueden repetirse.", "Requisito");
                        } else
                        {
                            if (this.contarCorrectas() < 1)
                            {
                                MessageBox.Show("Al menos 1 respuesta debe ser correcta.", "Mínimo requerido");
                            } else
                            {
                                this.pregunta.pregunta = txtPregunta.Text;
                                foreach (ListViewItem item in lvRespuestas.Items)
                                {
                                    Respuesta respuesta = new Respuesta(item.Text, item.Checked);
                                    this.pregunta.respuestas.Add(respuesta);
                                }
                                if(esNueva)
                                {
                                    this.formulario.preguntas.Add(this.pregunta);
                                }
                                this.formulario.actualizarDatos();
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void lvRespuestas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            btnEliminar.Enabled = lv.SelectedItems.Count > 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvRespuestas.SelectedItems)
            {
                item.Remove();
            }
        }

        public int buscarRespuesta(string respuesta)
        {
            for (int i = 0; i < lvRespuestas.Items.Count; i++)
            {
                ListViewItem item = lvRespuestas.Items[i];
                if (item.Text == respuesta)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool hayRespuestaRepetida()
        {
            ListViewItem item1, item2;
            for(int i = 0; i < lvRespuestas.Items.Count; i++)
            {
                item1 = lvRespuestas.Items[i];
                for(int x = i + 1; x < lvRespuestas.Items.Count; x++)
                {
                    item2 = lvRespuestas.Items[x];
                    if(item1.Text == item2.Text)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void lvRespuestas_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(e.Label))
            {
                e.CancelEdit = true;
                MessageBox.Show("Por favor, introduzca una respuesta.", "Campo requerido");
                return;
            }
        }
    }
}
