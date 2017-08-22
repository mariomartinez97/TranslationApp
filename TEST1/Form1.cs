using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TEST1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Word> diccionario;
        public Form1()
        {
            InitializeComponent();

            diccionario = new Dictionary<string, Word>();


            StreamReader reader = new StreamReader("short_file2.txt");

            while (!reader.EndOfStream)
            {
                Word mWord = new Word();
                string wordInfo = reader.ReadLine();
                string[] split = wordInfo.Split('|');
                for (int i = 0; i < split.Length; i++)
                {
                    split[i] = split[i].Remove(0, 1);
                    split[i] = split[i].Remove(split[i].Length - 1, 1);
                }

                mWord.palabra = split[0];
                mWord.traduccion = split[1];

                diccionario.Add(mWord.palabra, mWord);                            
            }

            foreach (var kvp in diccionario)
            {                                
                dataGridView1.Rows.Add(diccionario[kvp.Key].palabra, diccionario[kvp.Key].traduccion);
            }

            //diccionario.ContainsValue()


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (diccionario.ContainsKey(textBox1.Text))
            {
                textBox2.Text = textBox1.Text;
            }
            else
            {
                textBox2.Text = "The word doesnt exist";
            }
            //textBox1.Text
        }
    }
}
