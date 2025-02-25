using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eightpuzzle
{
    internal class Table : IComparable<Table>
    {


        public int[,] durum { get; set; }
        public Table ebeveyn;
        public int maliyet;
        public int GMaliyet;
        public Table(int[,] durum, Table ebeveyn, int GMaliyet, int maliyet)
        {
            this.durum = durum;
            this.ebeveyn = ebeveyn;
            this.maliyet = maliyet + GMaliyet;
            this.GMaliyet = GMaliyet;
        }

        public int CompareTo(Table other)
        {
            return maliyet.CompareTo(other.maliyet);
        }
    }

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public int Count => data.Count;

        public PriorityQueue()
        {
            data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            data.Sort();
        }

        public T Dequeue()
        {
            if (data.Count == 0)
                throw new InvalidOperationException("Priority queue is empty.");

            T frontItem = data[0];
            data.RemoveAt(0);
            return frontItem;
        }






    }
}
