
namespace WinFormsApp
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsddbExportar = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiExportarQuiz = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lvPreguntas = new System.Windows.Forms.ListView();
            this.chPregunta = new System.Windows.Forms.ColumnHeader();
            this.chRespuestas = new System.Windows.Forms.ColumnHeader();
            this.chRespuestasCorrectas = new System.Windows.Forms.ColumnHeader();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbExportar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsddbExportar
            // 
            this.tsddbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbExportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportarQuiz});
            this.tsddbExportar.Image = ((System.Drawing.Image)(resources.GetObject("tsddbExportar.Image")));
            this.tsddbExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbExportar.Name = "tsddbExportar";
            this.tsddbExportar.Size = new System.Drawing.Size(64, 22);
            this.tsddbExportar.Text = "Exportar";
            // 
            // tsmiExportarQuiz
            // 
            this.tsmiExportarQuiz.Name = "tsmiExportarQuiz";
            this.tsmiExportarQuiz.Size = new System.Drawing.Size(142, 22);
            this.tsmiExportarQuiz.Text = "... para \'Quiz\'";
            this.tsmiExportarQuiz.Click += new System.EventHandler(this.tsmiExportarQuiz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de preguntas";
            // 
            // lvPreguntas
            // 
            this.lvPreguntas.AllowColumnReorder = true;
            this.lvPreguntas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPregunta,
            this.chRespuestas,
            this.chRespuestasCorrectas});
            this.lvPreguntas.FullRowSelect = true;
            this.lvPreguntas.GridLines = true;
            this.lvPreguntas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPreguntas.HideSelection = false;
            this.lvPreguntas.Location = new System.Drawing.Point(12, 88);
            this.lvPreguntas.MultiSelect = false;
            this.lvPreguntas.Name = "lvPreguntas";
            this.lvPreguntas.Size = new System.Drawing.Size(776, 302);
            this.lvPreguntas.TabIndex = 1;
            this.lvPreguntas.UseCompatibleStateImageBehavior = false;
            this.lvPreguntas.View = System.Windows.Forms.View.Details;
            this.lvPreguntas.SelectedIndexChanged += new System.EventHandler(this.lvPreguntas_SelectedIndexChanged);
            // 
            // chPregunta
            // 
            this.chPregunta.Tag = "";
            this.chPregunta.Text = "Pregunta";
            this.chPregunta.Width = 300;
            // 
            // chRespuestas
            // 
            this.chRespuestas.Text = "Respuestas";
            this.chRespuestas.Width = 150;
            // 
            // chRespuestasCorrectas
            // 
            this.chRespuestasCorrectas.Text = "Respuestas correctas";
            this.chRespuestasCorrectas.Width = 150;
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(688, 396);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(100, 42);
            this.btnNueva.TabIndex = 4;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(582, 396);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 42);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(476, 396);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Para modificar o eliminar una pregunta debe seleccionarla.";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.lvPreguntas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Quiz Creator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbExportar;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportarQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPreguntas;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ColumnHeader chPregunta;
        private System.Windows.Forms.ColumnHeader chRespuestas;
        private System.Windows.Forms.ColumnHeader chRespuestasCorrectas;
        private System.Windows.Forms.Label label2;
    }
}

