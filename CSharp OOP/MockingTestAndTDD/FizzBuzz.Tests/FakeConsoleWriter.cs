using System;
using FizzBuzz.Contracts;

namespace FizzBuzz.Tests
{
    public class FakeConsoleWriter :IWriter
    {
        public FakeConsoleWriter()
        {
        }

        public void WriteLine(string input)
        {
            Result += input;
        }

        public string Result { get; set; }
    }
}
