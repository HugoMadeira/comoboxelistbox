using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comoboxelistbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador;

            //limpar a combobox
            comboBox1.Items.Clear();

            //preencher
            for (contador = 0; contador <= 10; contador++)
            {
                comboBox1.Items.Add(contador.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //saber qual a posição do item selecionado
            int posicao = comboBox1.SelectedIndex;

            if (posicao < 0)
            {
                MessageBox.Show("Primeiro tem de escolher um elemento!");
                return;
            }

            //remover
            comboBox1.Items.RemoveAt(posicao);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //adicionar valor digitado
            listBox1.Items.Add(textBox1.Text);

            //conta e exibe total de elementos
            label3.Text = listBox1.Items.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //limpar a listbox
            listBox1.Items.Clear();

            //adicionar
            listBox1.Items.Add("Aveiro");
            listBox1.Items.Add("Beja");
            listBox1.Items.Add("Coimbra");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //limpar a listBox
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //saber qual a posição do item selecionado
            int posicao = listBox1.SelectedIndex;
            if (posicao < 0)
            {
                MessageBox.Show("Primeiro deve selecionar um elemento da lsita.");
                return;
            }
            listBox1.Items.RemoveAt(posicao);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int indice;
            string temp = "";
            for (indice = 0; indice < listBox1.SelectedItems.Count;  indice++)
            {
                temp = temp + "\n" + listBox1.SelectedItems[indice].ToString();
            }
            MessageBox.Show(temp);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedIndices.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //adicionar três itens em modo de execução
            comboBox2.Items.Insert(0, "Janeiro");
            comboBox2.Items.Insert(1, "Fevereiro");
            comboBox2.Items.Insert(2, "Março");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //limpar um elemento numa posição válida
            comboBox2.Items.RemoveAt(2);

            //limpar toda a combobox em modo de execução
            comboBox2.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //adicionar itens em modo de execução
            comboBox2.Items.Insert(0, "José");
            comboBox2.Items.Insert(1, "Carlos");
            comboBox2.Items.Insert(2, "Maria");
            comboBox2.Items.Insert(3, "Ana");

            //ordenar alfabeticamente
            comboBox2.Sorted = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //declarar um vetor de string com dimensão 3
            string[] cores = new string[3];
            cores[0] = "Red";
            cores[1] = "Blue";
            cores[2] = "Green";

            foreach (string s in cores)
            {
                comboBox3.Items.Add(s);
            }
            {
                //declarar um vetor de numeros com dimensao 5
                int[] numeros = new int[5];
                numeros[0] = 10;
                numeros[1] = 20;
                numeros[2] = 30;
                numeros[3] = 40;
                numeros[4] = 50;

                for (int i = 0; i < 5; i++)
                {
                    comboBox3.Items.Add(numeros[i]);
                }
            }
        }
    }
}
