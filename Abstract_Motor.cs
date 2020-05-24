using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Laba5_12Variant_Motor
{
    abstract class Abstract_Motor : ChangeInfa, GradeFuntion
    {
        private string name;//название
        private string code;//код
        private double d_Bore = 0;//диаметр цилиндра
        private double piston_Stroke = 0;//ход поршня
        private int numberOfEngineCylinders = 0;//количество цилиндров двигателя
        private double volumeEngine = 0;//объем двигателя
        private int number_of_valves_per_cylinder = 0;//количество клапанов на один цилиндр
        private string typeOil;//тип топлива
        private string piston_engine_layout;//компоновка поршневых двигателей
        private string timing_drive_type;//тип привода ГРМ
        private double engine_compression_ratio;//степень сжатия двигателя,клмпрессия
        private double powerEngine;//мощность двигателя

        private string[] pistonEngineLayout = {"Рядный двигатель",
            "V-образный двигатель",
            "Оппозитный двигатель",
            "VR-образный двигатель",
            "W-образный двигатель"
        };

        private Dictionary<string, string> timingDriveTypes = new Dictionary<string, string>()
        {
            {"OHV","обозначает верхнее расположение клапанов в двигателе"},
            {"OHC","обозначает верхнее расположение распредвала" },
            {"SOHC","обозначает один распределительный вал верхнего расположения" },
            {"DOHC","обозначает конструкцию газораспределительного механизма с двумя распределительными валами расположенными сверху" }
        };

        private string[] typesOil =
        {
            "gasoline","diesel","jet fuel"
        };

        public Abstract_Motor()
        {
        }

        public string Code { get => code; protected set => code = value; }
        public double D_Bore { get => d_Bore; protected set => d_Bore = value; }
        public double Piston_Stroke { get => piston_Stroke; protected set => piston_Stroke = value; }
        public int NumberOfEngineCylinders { get => numberOfEngineCylinders; protected set => numberOfEngineCylinders = value; }
        public double VolumeEngine { get => volumeEngine; protected set => volumeEngine = value; }
        public int Number_of_valves_per_cylinder { get => number_of_valves_per_cylinder; protected set => number_of_valves_per_cylinder = value; }
        public string TypeOil { get => typeOil; protected set => typeOil = value; }
        public string Piston_engine_layout { get => piston_engine_layout; protected set => piston_engine_layout = value; }
        public string Timing_drive_type { get => timing_drive_type; protected set => timing_drive_type = value; }
        public double Engine_compression_ratio { get => engine_compression_ratio; protected set => engine_compression_ratio = value; }
        public double PowerEngine { get => powerEngine; protected set => powerEngine = value; }
        public string Name { get => name; protected set => name = value; }

        public bool ChangeInfa(string name)
        {
            string pattern = @"\w+";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(name))
            {
                this.Name = name;
                return true;
            }
            else
                throw new Exception("Неправильный формат имени");
        }

        public bool ChangeInfa(string name, string code)
        {

            string pattern = @"\d{0,16}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(code) && ChangeInfa(name))
            {
                if (code.Length != 16)
                {
                    code = code.Insert(0, $"{new string('0', 16 - code.Length)}");
                }
                this.Code = code;
                return true;
            }
            else
                throw new Exception("Неправильный формат кода двигателя");
        }

        public bool ChangeInfa(string name, string code, double d_Bore)
        {
            if (d_Bore > 0 && ChangeInfa(name, code))
            {
                this.D_Bore = d_Bore;
                return true;
            }
            else
                throw new Exception("Значение диаметра цилиндра меньше нуля");
        }

        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke)
        {
            if (piston_Stroke > 0 && ChangeInfa(name, code, d_Bore))
            {
                this.Piston_Stroke = piston_Stroke;
                return true;
            }
            else
                throw new Exception("Значение переменной \"ход поршня меньше нуля\"");
        }

        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders)
        {
            if (numberOfEngineCylinders > 0 && ChangeInfa(name, code, d_Bore, piston_Stroke))
            {
                this.NumberOfEngineCylinders = numberOfEngineCylinders;
                return true;
            }
            else
                throw new Exception("Значение переменной \"количество цилиндров\" меньше нуля");
        }

        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine)
        {
            if (volumeEngine > 0 && ChangeInfa(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders))
            {
                this.VolumeEngine = volumeEngine;
                return true;
            }
            else
                throw new Exception("Значение переменной \"объем двигателя\"меньше нуля");
        }

        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine, int number_of_valves_per_cylinder)
        {
            if (number_of_valves_per_cylinder > 0 && ChangeInfa(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine))
            {
                this.Number_of_valves_per_cylinder = number_of_valves_per_cylinder;
                return true;
            }
            else
                throw new ArgumentException("1");
        }

        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine, int number_of_valves_per_cylinder, string typeOil)
        {
            for (int i = 0; i < typesOil.Length; i++)
            {
                if (typeOil == typesOil[i])
                    if (ChangeInfa(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine, number_of_valves_per_cylinder))
                    {
                        this.TypeOil = typesOil[i];
                        return true;
                    }
            }
            throw new ArgumentException("2");
        }

        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine, int number_of_valves_per_cylinder, string typeOil, string piston_engine_layout)
        {
            for (int i = 0; i < pistonEngineLayout.Length; i++)
            {
                if (piston_engine_layout.ToLower() == pistonEngineLayout[i].ToLower() && ChangeInfa(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine, number_of_valves_per_cylinder, typeOil))
                {
                    piston_engine_layout = pistonEngineLayout[i];
                    return true;
                }
            }
            throw new ArgumentException("3");
        }

        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine, int number_of_valves_per_cylinder, string typeOil, string piston_engine_layout, string timing_drive_type)
        {
            foreach (KeyValuePair<string, string> type in timingDriveTypes)
            {
                if (type.Key == timing_drive_type.ToUpper()
                    && ChangeInfa(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine, number_of_valves_per_cylinder, typeOil, piston_engine_layout))
                {
                    this.Timing_drive_type = type.Key + type.Value;
                    return true;
                }
            }
            throw new ArgumentException("4");
        }

        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine, int number_of_valves_per_cylinder, string typeOil, string piston_engine_layout, string timing_drive_type, double engine_compression_ratio)
        {
            if (engine_compression_ratio > 0 &&
                ChangeInfa(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine, number_of_valves_per_cylinder, typeOil, piston_engine_layout, timing_drive_type))
            {
                this.Engine_compression_ratio = engine_compression_ratio;
                return true;
            }
            throw new ArgumentException("5");
        }

        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine, int number_of_valves_per_cylinder, string typeOil, string piston_engine_layout, string timing_drive_type, double engine_compression_ratio, double powerEngine)
        {
            if (powerEngine > 0 && ChangeInfa(name, code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine, number_of_valves_per_cylinder, typeOil, piston_engine_layout, timing_drive_type, engine_compression_ratio))
            {
                this.PowerEngine = powerEngine;
                return true;
            }
            else
                throw new ArgumentException("6");
        }

        public void DownGrade(int percent)
        {
            this.PowerEngine = PowerEngine - PowerEngine * percent;
        }

        public void Ugrade(int percent)
        {
            this.PowerEngine = PowerEngine + PowerEngine * percent;
        }

        public override string ToString()
        {
            return string.Format("|{0,16}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|{7,10}|{8,10}|{9,10}|{10,10}|",
                code, d_Bore, piston_Stroke, numberOfEngineCylinders, volumeEngine, number_of_valves_per_cylinder, typeOil
                , piston_engine_layout, timing_drive_type, engine_compression_ratio, powerEngine);
        }

    }
}
