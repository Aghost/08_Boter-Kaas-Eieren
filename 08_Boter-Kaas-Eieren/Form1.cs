using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Boter_Kaas_Eieren
{
    public partial class Form1 : Form
    {
        int turn = 0;
        int[,] magic = new int[3, 3] { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } };
        int[,] boards = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0 ,0 } };

        public Form1()
        {
            InitializeComponent();
        }

        private void checkWin()
        {
            // if boards(horz, vert, diag).any == 15 p1 won
            // if boards(horz, vert, diag).any == 30 p2 won
        }

        // priv void position_Click
        //   button_clicked.Text = (playerTurn % 2) + 1 * magic[buttonposition]

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < magic.GetLength(0); i++)
            {
                for (int j = 0; j < magic.GetLength(1) ; j++)
                {
                    Console.WriteLine($"{i}{j} - {magic[i, j]} \t {i}{j} - {boards[i,j]}");
                }
            }
            
        }
    }
}
