using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_12Variant_Motor
{
    class InternalCombustionEngine : Abstract_Motor
    {
        public InternalCombustionEngine()
        {
        }
        public InternalCombustionEngine(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine, int number_of_valves_per_cylinder, string piston_engine_layout, string timing_drive_type, double engine_compression_ratio, double poewrEngine)
        {
            try
            {
                ChangeInfa(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine, number_of_valves_per_cylinder, "gasoline", piston_engine_layout, timing_drive_type, engine_compression_ratio, poewrEngine);
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exception.Message);
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
        public static InternalCombustionEngine CreateNew()
        {
            string name;
            string code;
            double d_Bore;
            double piston_Stroke;
            int numberOfEngineCylinders;
            double volumeEngine;
            int number_of_valves_per_cylinder;
            string piston_engine_layout;
            string timing_drive_type;
            double engine_compression_ratio;
            double powerEngine;
            Console.WriteLine(new string('=', 30) + "Двигатель внутренего сгорания" + new string('=', 30));
            Console.WriteLine("Введите название двивигателя");
            name = Console.ReadLine();
            Console.WriteLine("Ввеите код двигателя");
            code = Console.ReadLine();
            Console.WriteLine("Введите диаметр цилиндра");
            d_Bore = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ход поршня");
            piston_Stroke = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество цилиндров двигателя");
            numberOfEngineCylinders = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем двигателя");
            volumeEngine = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество клапанов на один цилиндр");
            number_of_valves_per_cylinder = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите компоновка поршневых двигателей(Рядный двигатель,оппозитный двигатель,V-,VR-,W-образные двигатели)");
            piston_engine_layout = Console.ReadLine();
            Console.WriteLine("Введите тип привода ГРМ(OHV,OHC,SOHC,DOHC)");
            timing_drive_type = Console.ReadLine();
            Console.WriteLine("Введите степень сжатия двигателя");
            engine_compression_ratio = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите мощность двигателя");
            powerEngine = double.Parse(Console.ReadLine());
            return new InternalCombustionEngine(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine, number_of_valves_per_cylinder,
                piston_engine_layout, timing_drive_type, engine_compression_ratio, powerEngine);
        }
        public static InternalCombustionEngine CreateNew(Abstract_Motor[] abstract_Motors)
        {
            string name;
            string code;
            double d_Bore;
            double piston_Stroke;
            int numberOfEngineCylinders;
            double volumeEngine;
            int number_of_valves_per_cylinder;
            string piston_engine_layout;
            string timing_drive_type;
            double engine_compression_ratio;
            double powerEngine;
            Console.WriteLine(new string('=', 30) + "Двигатель внутренего сгорания" + new string('=', 30));
            Console.WriteLine("Введите название двивигателя");
            name = Console.ReadLine();
            Console.WriteLine("Ввеите код двигателя");
            code = Console.ReadLine();
            Console.WriteLine("Введите диаметр цилиндра");
            d_Bore = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ход поршня");
            piston_Stroke = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество цилиндров двигателя");
            numberOfEngineCylinders = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем двигателя");
            volumeEngine = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество клапанов на один цилиндр");
            number_of_valves_per_cylinder = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите компоновка поршневых двигателей(Рядный двигатель,оппозитный двигатель,V-,VR-,W-образные двигатели)");
            piston_engine_layout = Console.ReadLine();
            Console.WriteLine("Введите тип привода ГРМ(OHV,OHC,SOHC,DOHC)");
            timing_drive_type = Console.ReadLine();
            Console.WriteLine("Введите степень сжатия двигателя");
            engine_compression_ratio = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите мощность двигателя");
            powerEngine = double.Parse(Console.ReadLine());
            InternalCombustionEngine internalCombustionEngine = new InternalCombustionEngine(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine, number_of_valves_per_cylinder,
                piston_engine_layout, timing_drive_type, engine_compression_ratio, powerEngine);
            for (int i = 0; i < abstract_Motors.Length; i++)
            {
                if (abstract_Motors[i] != null)
                    abstract_Motors[i] = internalCombustionEngine;
            }
            //Console.WriteLine(internalCombustionEngine);
            return internalCombustionEngine;
        }
    }
}
