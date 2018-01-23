using PatternsExample.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.SingletonExample
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        public State State { get; private set; }

        private Singleton() { }

        public void SetState(State state)
        {
            this.State = state;
        }

        public static Singleton GetInstance => instance;

    }
}
