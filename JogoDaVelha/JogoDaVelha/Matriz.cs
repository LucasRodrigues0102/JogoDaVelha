using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    internal class Matriz
    {
        public int[,] matriz = new int[3,3];
        public Matriz() 
        { 
            for(int i = 0; i<3; i++) 
            { 
                for (int j = 0; j < 3; j++)
                {
                    matriz[i,j] = 0;
                }
            }
        }

        public void atualizarMatriz(int ContTurno, int posi, int posj)
        {
            if (ContTurno % 2 != 0)
            {
                matriz[posi, posj] = 2;
            }

            else
            {
                matriz[posi, posj] = 1;
            }
        }

        public int verificarMatriz(int ContTurno)
        {
            int Caso = 0;

            if (ContTurno >= 5)
            {
                if (matriz[0, 0] == 1 && matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0])
                {
                    Caso = 1;
                    return Caso;
                }

                else if (matriz[0, 1] == 1 && matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1])
                {
                    Caso = 2;
                    return Caso;
                }

                else if (matriz[0, 2] == 1 && matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2])
                {
                    Caso = 3;
                    return Caso;
                }

                else if (matriz[0, 0] == 1 && matriz[0, 0] == matriz[0, 1] && matriz[0, 0] == matriz[0, 2])
                {
                    Caso = 4;
                    return Caso;
                }

                else if (matriz[1, 0] == 1 && matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2])
                {
                    Caso = 5;
                    return Caso;
                }

                else if (matriz[2, 0] == 1 && matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2])
                {
                    Caso = 6;
                    return Caso;
                }

                else if (matriz[0, 0] == 1 && matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2])
                {
                    Caso = 7;
                    return Caso;
                }

                else if (matriz[0, 2] == 1 && matriz[0, 2] == matriz[1, 1] && matriz[0, 2] == matriz[2, 0])
                {
                    Caso = 8;
                    return Caso;
                }

                else if (matriz[0, 0] == 2 && matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0])
                {
                    Caso = 9;
                    return Caso;
                }

                else if (matriz[0, 1] == 2 && matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1])
                {
                    Caso = 10;
                    return Caso;
                }

                else if (matriz[0, 2] == 2 && matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2])
                {
                    Caso = 11;
                    return Caso;
                }

                else if (matriz[0, 0] == 2 && matriz[0, 0] == matriz[0, 1] && matriz[0, 0] == matriz[0, 2])
                {
                    Caso = 12;
                    return Caso;
                }

                else if (matriz[1, 0] == 2 && matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2])
                {
                    Caso = 13;
                    return Caso;
                }

                else if (matriz[2, 0] == 2 && matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2])
                {
                    Caso = 14;
                    return Caso;
                }

                else if (matriz[0, 0] == 2 && matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2])
                {
                    Caso = 15;
                    return Caso;
                }

                else if (matriz[0, 2] == 2 && matriz[0, 2] == matriz[1, 1] && matriz[0, 2] == matriz[2, 0])
                {
                    Caso = 16;
                    return Caso;
                }

                else if (ContTurno == 9)
                {
                    Caso = 17;
                    return Caso;
                }

                else
                {
                    Caso = 0;
                    return Caso;
                }
            }
            
            else
            {
                Caso = 0;
                return Caso;
            }
        }

        public void reiniciarMatriz()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = 0;
                }
            }
        }
    }
}