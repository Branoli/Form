using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgL
{
    class Knuckle
    {
        public int this[int i, int j]
        {
            get
            {
                return ArrOfKnuckles[i, j];
            }
            set
            {
                ArrOfKnuckles[i, j] = value;
            }
        }
        protected int[,] ArrOfKnuckles;
        protected int ZeroX;
        protected int ZeroY;
        protected int QX;
        protected int QY;

        public Knuckle(int GetLEnght)
        {
            ArrOfKnuckles = new int[GetLEnght, GetLEnght];
            ArrOfKnuckle();
        }


        protected bool CheckTheKnuckle(string q)
        {
            for (int i = 0; i < ArrOfKnuckles.GetLength(1); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(0); j++)
                {
                    if (ArrOfKnuckles[i, j] == Int32.Parse(q))
                    {
                        QX = i;
                        QY = j;
                    }
                    if (ArrOfKnuckles[i, j] == 0)
                    {
                        ZeroX = i;
                        ZeroY = j;
                    }
                }
            }
            if (Math.Sqrt(Math.Pow(ZeroX - QX, 2) + Math.Pow(ZeroY - QY, 2)) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual void MovingTheKnuckles(string q)
        {
            int v = 0;
            v = ArrOfKnuckles[QX, QY];
            ArrOfKnuckles[QX, QY] = ArrOfKnuckles[ZeroX, ZeroY];
            ArrOfKnuckles[ZeroX, ZeroY] = v;
        }
        protected void ArrOfKnuckle()
        {
            int x = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(1); j++)
                {
                    ArrOfKnuckles[i, j] = x;
                    x++;
                }
            }
        }
    }
}
