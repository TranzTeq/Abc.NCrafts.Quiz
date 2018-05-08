﻿using System;

namespace Abc.NCrafts.Quizz.Performance2018.Questions._000
{
    [CorrectAnswer(Difficulty = Difficulty.Easy)]
    public class Answer2
    {
        public readonly SomeGuids Guids = new SomeGuids(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());

        public void Run()
        {
            // begin
            var result = Guids.GetC();
            // end
            Logger.Log(result.ToString());
        }

        public readonly struct SomeGuids
        {
            public readonly Guid A;
            public readonly Guid B;
            public readonly Guid C;
            public readonly Guid D;

            public SomeGuids(Guid a, Guid b, Guid c, Guid d)
                => (A, B, C, D) = (a, b, c, d);

            public Guid GetC() => C;
        }
    }
}