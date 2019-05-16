using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L2
{
    public class Matrix <T>: IMatrix<T>
    {

        private int xCount;
        private int yCount;
        private T[,] body;
        
        public  Matrix(int xNum, int yNum)
        {
            xCount = xNum;
            yCount = yNum;
            body =  new T[xCount, yCount];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T i in body)
            {
                yield return i;
            }
        }

        public T GetItem(int x, int y)
        {
            return body[x,y];
        }

        public void Insert(int x, int y, T item)
        {
            //try
            //{
                body[x, y] = item;
            //}
            //catch(Exception e)
            //{
                
            //}
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
