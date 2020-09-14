using System;
using System.Windows.Forms;

namespace _08_Boter_Kaas_Eieren
{
    public partial class Form1 : Form
    {
        int turn_count = 0;

        int[][] magic = new int[][]
        {
            new int[] { 4, 9, 2 },
            new int[] { 3, 5, 7 },
            new int[] { 8, 1, 6 } 
        };

        int[][] boards = new int[][]
        {
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        // priv void position_Click
        //   button_clicked.Text = (playerTurn % 2) + 1 * magic[buttonposition]

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < magic[0].GetLength(0); i++)
            {
                for (int j = 0; j < magic[1].GetLength(0); j++)
                {
                    Console.WriteLine($"{i}{j} - {magic[i][j]} \t {i}{j} - {boards[i][j]}");
                }
            }
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int row = b.Name[0] - 65;
            int column = b.Name[1] - 48;

            if (turn_count % 2 == 0)
            {
                boards[row][column] = magic[row][column];
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            CheckWin();
            //Check_Row(b.Name);

            Console.WriteLine($"{row} {column}");
            Print_Board();

            turn_count++;
        }

        private void Print_Board()
        {
            for (int i = 0; i < magic[0].GetLength(0); i++)
            {
                for (int j = 0; j < magic[1].GetLength(0); j++)
                {
                    Console.WriteLine($"{i}{j} - {magic[i][j]} \t {i}{j} - {boards[i][j]}");
                }
            }
        }

        private void Check_Row(string direction)
        {
            foreach (char chr in direction)
            {
                switch (chr)
                {
                    case 'A': Console.WriteLine("bottom"); break;
                    case 'B': Console.WriteLine("middle"); break;
                    case 'C': Console.WriteLine("top"); break;
                    case '0': Console.WriteLine("first"); break;
                    case '1': Console.WriteLine("middle"); break;
                    case '2': Console.WriteLine("last"); break;
                    default: Console.WriteLine("default"); break;
                }
            }
        }

        private void CheckWin()
        {
            if (A0.Text == A1.Text && A1.Text == A2.Text)       // horizontal
            {
                Console.WriteLine($"A WONNER! + {A0.Text} + {A1.Text} + {A2.Text}");
            }
            // if boards(horz, vert, diag).any == 15 p1 won
            // if boards(horz, vert, diag).any == 30 p2 won
        }
    }
}
