using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genereic
{
    public class Deck<T> where T : ICard
    {
        private HashSet<T> deck = new HashSet<T>();

        public void AddCard(T card)
        {
            //try
            //{
            //    deck.Add(card);
            //catch (HasSetDuplicateException e)
            //    {

            //    }
            //}
            
        }

        public void RemoveCard(T card)
        {
            deck.Remove(card);
        }
        public void Sort()
        {
            //deck.Sort();
        }
        
    }


}
