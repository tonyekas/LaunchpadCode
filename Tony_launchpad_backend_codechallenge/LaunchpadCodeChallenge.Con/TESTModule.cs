using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchpadCodeChallenge.Con
{
    public class TESTModule
    {
        //int intergers = List [1,2,3,4];
        bool isTrue = true;
        public static decimal IntergerValues(int i, string response)
        {
            List<string> listString = new List<string>();
            float result;
            if (i < 1 && i > 4)
            {
                //filter the above values
            }
            //if (listString.Contains(stringVal))
            //{
            //      //stringVal to be implemented
            //    // Do something;
            //}
            // else
            switch (i)
            {
                case int n when n >= i && n <= i:
                    result = n * 2;
                    break;
                case int n when n >= 4:
                    result = n * 3;
                    break;
                case int n when n < 1:
                    response = "Expection";
                    break;
                default:
                    response = i.ToString();
                    break;
            }
            //i = (int)result;

            return i;
        }
    }
}
