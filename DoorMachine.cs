using System;
namespace tpmodul_4
{
	public class DoorMachine
	{
        private enum State
        {
            TERKUNCI,
            TERBUKA
        }

        private State currentState;

        public DoorMachine()
        {
            currentState = State.TERKUNCI;
            Console.WriteLine("Pintu terkunci");
        }

        public void bukaPintu()
        {
            currentState = State.TERBUKA;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}

