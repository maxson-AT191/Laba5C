using System;

namespace Laba5_12Variant_Motor
{
    class Program
    {
        delegate Abstract_Motor CreateMotor(Abstract_Motor[] abstract_Motors);
        delegate void Infa();
        static void Main(string[] args)
        {
            Abstract_Motor[] abstract_Motors = new Abstract_Motor[3];
            Infa infa = null;
            CreateMotor createMotor = null;
            createMotor += InternalCombustionEngine.CreateNew;
            createMotor += DieselEngine.CreateNew;
            createMotor += JetEngine.CreateNew;
            createMotor(abstract_Motors);
            infa += () => { Console.WriteLine(abstract_Motors[0].ToString()); };
            infa += () => { Console.WriteLine(abstract_Motors[1].ToString()); };
            infa += () => { Console.WriteLine(abstract_Motors[2].ToString()); };
            infa.Invoke();
        }
    }
}
