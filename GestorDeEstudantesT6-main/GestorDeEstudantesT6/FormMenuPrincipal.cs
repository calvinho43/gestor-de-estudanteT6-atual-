﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT6
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInseirEstudante inserirEstudante = new FormInseirEstudante();
            inserirEstudante.Show();
        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaDeEstudantes listaDeEstudantes = new FormListaDeEstudantes();
            listaDeEstudantes.Show();
        }
    }
}
