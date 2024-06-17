namespace GestorDeEstudantesT6
{
    partial class FormListaDeEstudantes
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
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.dataGridViewListaDeEstudantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeEstudantes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(12, 377);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(776, 61);
            this.buttonAtualizar.TabIndex = 0;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewListaDeEstudantes
            // 
            this.dataGridViewListaDeEstudantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeEstudantes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewListaDeEstudantes.Name = "dataGridViewListaDeEstudantes";
            this.dataGridViewListaDeEstudantes.Size = new System.Drawing.Size(776, 359);
            this.dataGridViewListaDeEstudantes.TabIndex = 1;
            this.dataGridViewListaDeEstudantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaDeEstudantes_CellContentClick);
            // 
            // FormListaDeEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewListaDeEstudantes);
            this.Controls.Add(this.buttonAtualizar);
            this.Name = "FormListaDeEstudantes";
            this.Text = "FormListaDeEstudantes";
            this.Load += new System.EventHandler(this.FormListaDeEstudantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeEstudantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.DataGridView dataGridViewListaDeEstudantes;
    }
}