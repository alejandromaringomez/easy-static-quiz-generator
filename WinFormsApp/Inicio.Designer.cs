
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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lvPreguntas = new System.Windows.Forms.ListView();
            this.chPregunta = new System.Windows.Forms.ColumnHeader();
            this.chRespuestas = new System.Windows.Forms.ColumnHeader();
            this.chRespuestasCorrectas = new System.Windows.Forms.ColumnHeader();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExportar});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 22);
            this.toolStripDropDownButton1.Text = "Opciones";
            this.toolStripDropDownButton1.ToolTipText = "tsddbOpciones";
            // 
            // tsmiExportar
            // 
            this.tsmiExportar.Name = "tsmiExportar";
            this.tsmiExportar.Size = new System.Drawing.Size(180, 22);
            this.tsmiExportar.Text = "Exportar para quiz";
            this.tsmiExportar.Click += new System.EventHandler(this.tsmiExportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 33);
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
            this.lvPreguntas.Location = new System.Drawing.Point(12, 64);
            this.lvPreguntas.MultiSelect = false;
            this.lvPreguntas.Name = "lvPreguntas";
            this.lvPreguntas.Size = new System.Drawing.Size(776, 326);
            this.lvPreguntas.TabIndex = 2;
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
            this.btnNueva.Location = new System.Drawing.Point(476, 396);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(100, 42);
            this.btnNueva.TabIndex = 3;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(582, 396);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 42);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(688, 396);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 42);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPreguntas;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ColumnHeader chPregunta;
        private System.Windows.Forms.ColumnHeader chRespuestas;
        private System.Windows.Forms.ColumnHeader chRespuestasCorrectas;
    }
}

