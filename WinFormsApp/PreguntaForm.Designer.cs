
namespace WinFormsApp
{
    partial class PreguntaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.gbPregunta = new System.Windows.Forms.GroupBox();
            this.gbRespuestas = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvRespuestas = new System.Windows.Forms.ListView();
            this.chRespuesta = new System.Windows.Forms.ColumnHeader();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbPregunta.SuspendLayout();
            this.gbRespuestas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(6, 22);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPregunta.Size = new System.Drawing.Size(366, 72);
            this.txtPregunta.TabIndex = 1;
            // 
            // gbPregunta
            // 
            this.gbPregunta.Controls.Add(this.txtPregunta);
            this.gbPregunta.Location = new System.Drawing.Point(12, 12);
            this.gbPregunta.Name = "gbPregunta";
            this.gbPregunta.Size = new System.Drawing.Size(378, 100);
            this.gbPregunta.TabIndex = 2;
            this.gbPregunta.TabStop = false;
            this.gbPregunta.Text = "Pregunta";
            // 
            // gbRespuestas
            // 
            this.gbRespuestas.Controls.Add(this.btnEliminar);
            this.gbRespuestas.Controls.Add(this.btnAdd);
            this.gbRespuestas.Controls.Add(this.lvRespuestas);
            this.gbRespuestas.Location = new System.Drawing.Point(12, 118);
            this.gbRespuestas.Name = "gbRespuestas";
            this.gbRespuestas.Size = new System.Drawing.Size(378, 247);
            this.gbRespuestas.TabIndex = 3;
            this.gbRespuestas.TabStop = false;
            this.gbRespuestas.Text = "Respuestas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(216, 206);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(297, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvRespuestas
            // 
            this.lvRespuestas.AllowColumnReorder = true;
            this.lvRespuestas.CheckBoxes = true;
            this.lvRespuestas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRespuesta});
            this.lvRespuestas.FullRowSelect = true;
            this.lvRespuestas.GridLines = true;
            this.lvRespuestas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRespuestas.HideSelection = false;
            this.lvRespuestas.LabelEdit = true;
            this.lvRespuestas.Location = new System.Drawing.Point(6, 22);
            this.lvRespuestas.MultiSelect = false;
            this.lvRespuestas.Name = "lvRespuestas";
            this.lvRespuestas.Size = new System.Drawing.Size(366, 166);
            this.lvRespuestas.TabIndex = 0;
            this.lvRespuestas.UseCompatibleStateImageBehavior = false;
            this.lvRespuestas.View = System.Windows.Forms.View.Details;
            this.lvRespuestas.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvRespuestas_AfterLabelEdit);
            this.lvRespuestas.SelectedIndexChanged += new System.EventHandler(this.lvRespuestas_SelectedIndexChanged);
            // 
            // chRespuesta
            // 
            this.chRespuesta.Text = "Respuesta";
            this.chRespuesta.Width = 300;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(228, 371);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 35);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(309, 371);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 35);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PreguntaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 418);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.gbRespuestas);
            this.Controls.Add(this.gbPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PreguntaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregunta";
            this.gbPregunta.ResumeLayout(false);
            this.gbPregunta.PerformLayout();
            this.gbRespuestas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.GroupBox gbPregunta;
        private System.Windows.Forms.GroupBox gbRespuestas;
        private System.Windows.Forms.ListView lvRespuestas;
        private System.Windows.Forms.ColumnHeader chRespuesta;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
    }
}