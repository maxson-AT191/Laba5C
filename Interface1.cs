using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_12Variant_Motor
{
    interface ChangeInfa
    {
        public bool ChangeInfa(string name);
        public bool ChangeInfa(string name, string code);
        public bool ChangeInfa(string name, string code,double d_Bore);
        public bool ChangeInfa(string name, string code, double d_Bore,double piston_Stroke);
        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke,int numberOfEngineCylinders);
        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders,double volumeEngine);
        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine
            ,int number_of_valves_per_cylinder);
        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine
            , int number_of_valves_per_cylinder, string typeOil);
        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine
           , int number_of_valves_per_cylinder, string typeOil, string piston_engine_layout);
        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine
           , int number_of_valves_per_cylinder, string typeOil, string piston_engine_layout, string timing_drive_type);
        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine
           , int number_of_valves_per_cylinder, string typeOil, string piston_engine_layout, string timing_drive_type
            ,double engine_compression_ratio);
        public bool ChangeInfa(string name, string code, double d_Bore, double piston_Stroke, int numberOfEngineCylinders, double volumeEngine
           , int number_of_valves_per_cylinder, string typeOil, string piston_engine_layout, string timing_drive_type
            , double engine_compression_ratio, double powerEngine);
    }
}
