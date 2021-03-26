
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_Arboles_Binarios_de_Busqueda
{
    public partial class Form1 : Form 
    {
        ArbolBinarioBusqueda miArbol = new ArbolBinarioBusqueda();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tareas miTareaAux;
            miTareaAux = new Tareas();
            miTareaAux.IdTarea = int.Parse(textBox1.Text);
            miTareaAux.NombreTarea = textBox2.Text;
            miTareaAux.Duracion = textBox3.Text;
            miTareaAux.Porcentaje = textBox4.Text + "%";
            miTareaAux.NombreProgramador = textBox5.Text;

            miArbol.insertar(miTareaAux);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox6.Text = ArbolBinarioBusqueda.inorden(miArbol.raizArbol());
            //listBox1.Items.Add = ArbolBinarioBusqueda.inorden(miArbol.raizArbol());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Tareas miTareaAux2;
            miTareaAux2 = new Tareas();
            miTareaAux2.NombreTarea = (textBox7.Text);

            //MessageBox.Show(miArbol.buscarIterativo(miTareaAux2).visitar() + "");
            MessageBox.Show(miArbol.buscar2(miTareaAux2).visitar() + "");


            
            DialogResult result = MessageBox.Show("DESEA ELIMINAR EL DATO BUSCADO", "SALIR", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                miArbol.eliminar2(miTareaAux2);
            }
            else if (result == DialogResult.No)
            {
            }
            else if (result == DialogResult.Cancel)
            {
            }


            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
