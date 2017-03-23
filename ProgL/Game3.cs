using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgL
{
    class Game3 : Game2
    {
        public List<int> history;
        public Game3(int GetLenght)
            : base(GetLenght)
        {
            history = new List<int>();
        }


        public override void MovingTheKnuckles(string q)
        {

            if ((q == "r"))
            {
                if ((history.Count > 0))
                {
                    Rollback();
                }
            }
            else
            {
                if (CheckTheKnuckle(q) == true)
                {
                    base.MovingTheKnuckles(q);
                    history.Add(Int32.Parse(q));
                }
            }
        }

        public void Rollback()
        {
            int q = 0, x = 0, y = 0, xo = 0, yo = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(1); j++)
                {
                    if (ArrOfKnuckles[i, j] == history[history.Count - 1])
                    {
                        x = i;
                        y = j;
                    }
                    if (ArrOfKnuckles[i, j] == 0)
                    {
                        xo = i;
                        yo = j;
                    }
                }
            }
            q = ArrOfKnuckles[x, y];
            ArrOfKnuckles[x, y] = ArrOfKnuckles[xo, yo];
            ArrOfKnuckles[xo, yo] = q;
            history.Remove(history[history.Count - 1]);
        }
    }
}
