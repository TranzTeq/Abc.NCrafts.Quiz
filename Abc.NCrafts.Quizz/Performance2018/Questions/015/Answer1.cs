﻿using System;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._015
{
    public class Answer1
    {
        public decimal Run()
        {
            // begin
            var n = new NCrafts();
            return DoSomething(n);
            // end
        }

        private decimal DoSomething(NCrafts s) => s.Sum;

        public struct NCrafts
        {
            public decimal Field1;
            public decimal Field2;
            public decimal Field3;

            public decimal Sum => Field1 + Field2 + Field3;
        }
    }
}
