using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eightpuzzle
{
    public class solution
    {


        private int[,] finalDurum;
        private int[,] baslamaDurumu;
        private PriorityQueue<Table> acikListe;

        //HashSet Kullanılması daha uygundur.
        private HashSet<int[,]> karaListe;
        private int shape;
        public solution(int[,] baslamaDurumu, int[,] finalDurum, int shape)
        {
            this.baslamaDurumu = baslamaDurumu;
            this.finalDurum = finalDurum;
            acikListe = new PriorityQueue<Table>();
            karaListe = new HashSet<int[,]>();
            this.shape = shape;
        }
        public List<int[,]> Coz()
        {
            Table baslanlamaTahtasi = new Table(baslamaDurumu, null, 0, 0);
            acikListe.Enqueue(baslanlamaTahtasi);

            while (acikListe.Count < 5000)
            {
                Table mevcutTahta = acikListe.Dequeue();
                karaListe.Add(mevcutTahta.durum);

                if (IsOk(mevcutTahta.durum))
                {
                    return ReconstructPath(mevcutTahta);
                }
                Console.WriteLine(acikListe.Count);
                List<Table> successors = GenerateSuccessors(mevcutTahta);
                foreach (Table successor in successors)
                {
                    if (!karaListe.Contains(successor.durum))
                    {
                        acikListe.Enqueue(successor);
                    }
                }
            }

            return null;
        }
        private List<Table> GenerateSuccessors(Table tahta)
        {
            List<Table> successors = new List<Table>();

            int x0konumu = 0;
            int y0konumu = 0;

            for (int i = 0; i < tahta.durum.GetLength(0); i++)
            {
                for (int j = 0; j < tahta.durum.GetLength(1); j++)
                {
                    if (tahta.durum[i, j] == 0)
                    {
                        x0konumu = i;
                        y0konumu = j;
                        break;
                    }
                }
            }

            int[] moveX = { -1, 1, 0, 0 };
            int[] moveY = { 0, 0, -1, 1 };

            for (int i = 0; i < 4; i++)
            {
                int newX = x0konumu + moveX[i];
                int newY = y0konumu + moveY[i];

                if (newX >= 0 && newX < shape && newY >= 0 && newY < shape)
                {
                    int[,] newState = (int[,])tahta.durum.Clone();
                    newState[x0konumu, y0konumu] = newState[newX, newY];
                    newState[newX, newY] = 0;
                    Table successor = new Table(newState, tahta, tahta.GMaliyet + 1, SezgiselMaliyet(newState));
                    successors.Add(successor);
                }
            }

            return successors;
        }
        private bool IsOk(int[,] durum)
        {
            for (int i = 0; i < durum.GetLength(0); i++)
            {
                for (int j = 0; j < durum.GetLength(1); j++)
                {
                    if (durum[i, j] != finalDurum[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private List<int[,]> ReconstructPath(Table tahta)
        {
            List<int[,]> path = new List<int[,]>();
            while (tahta != null)
            {
                path.Add(tahta.durum);
                tahta = tahta.ebeveyn;
            }
            path.Reverse();
            return path;
        }

        private int SezgiselMaliyet(int[,] state)
        {
            int cost = 0;
            for (int i = 0; i < state.GetLength(0); i++)
            {
                for (int j = 0; j < state.GetLength(1); j++)
                {
                    if (state[i, j] != finalDurum[i, j] && state[i, j] != 0)
                    {
                        cost++;
                    }
                }
            }
            return cost;
        }






    }
}
