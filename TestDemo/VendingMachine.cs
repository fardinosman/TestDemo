using System;
using System.Collections.Generic;

namespace TestDemo
{
    public class VendingMachine
    {
        int M100;
        int M50;
        int M20;
        int M10;
        int M5;
        int M2;
        int M1;

        int _CocaCola;

        public bool GetCocaCola()
        {
            if (_CocaCola > 0)
            {
                _CocaCola--;
                return true;
            }
            return false;
        }

        public void LoadCocaCola(int NewAmount)
        {
            if ((_CocaCola + NewAmount)> 20)
            {
                throw new Exception("Overflow");
            }
            else
            {
                _CocaCola += NewAmount;
            }
        }

        public VendingMachine()
        {
            M100 = 2;
            M50 = 2;
            M20 = 2;
            M10 = 5;
            M5 = 20;
            M2 = 100;
            M1 = 100;

            _CocaCola = 5;
        }

        //public List<int> ReturnMoney(int Money)
        //{
        //    List<int> returnMoney = new List<int>();
        //    while (Money >= 100 && M100 > 0)
        //    {

        //    }
        //}
    }
    
}