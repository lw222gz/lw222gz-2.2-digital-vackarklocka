﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class AlarmClock
    {
        //fält
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        //egenskaper
        public int AlarmHour
        {
            get { return _alarmHour; }
            set {
                    if (value < 0 || value > 23)
                    {
                        throw new ArgumentException("Alarmtimmen är inte inom intervallet 0-23.");
                    }
                    _alarmHour = value;
                }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set {
                    if (value < 0 || value > 59)
                    {
                        throw new ArgumentException("Alarmminuten är inte inom intervallet 0-59.");
                    }
                    _alarmMinute = value;
                }
        }

        public int Hour
        {
            get { return _hour; }
            set {
                    if (value < 0 || value > 23)
                    {
                    throw new ArgumentException("Timmen är inte inom intervallet 0-23.");
                    }
                    _hour = value;
                }
        }

        public int Minute
        {
            get { return _minute; }
            set {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Minuten är inte inom intervallet 0-59.");
                }
                _minute = value;
            }
        }


        //konstruktorerna
        public AlarmClock() : this(0,0)
        {
            // denna ska vara tom och kalla på konstruktorn med 2 parametrar
        }

        public AlarmClock(int hour, int minute) : this(hour, minute,0,0)
        {
            // Denn ska också vara tom och ska kalla på konstruktorn med 4 parametrar
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;            
        }

        //metoderna
        public bool TickTock()
        {

            if (Minute < 59)
            {
                ++Minute;
            }
            else
            {
                Minute = 0;
                if (Hour < 23)
                {
                    ++Hour;
                }
                else
                {
                    Hour = 0;
                }
            }
            return AlarmHour == Hour && AlarmMinute == Minute;                                
            // metod som anropas för at få klockan gå en minut, ska retunera true om den nya tiden översstämmer med alarmtiden annars ska den retunera false.
            // metoden ansvarar för att öka minuternas värde med 1. 
        }

        public override string ToString()
        {

            StringBuilder Display = new StringBuilder();


            Display.AppendFormat("{0,5}:0{1} <{2}:0{3}>", Hour, Minute, AlarmHour, AlarmMinute);

            if (Minute >= 10)
            {
                Display.Remove(6, 1);
            }

            if (AlarmMinute >= 10)
            {
                Display.Remove(12, 1);
            }

            return Display.ToString();
            //metod som har till uppgift att retunera en sträng som representerar värdet av en instans av klassen AlarmClock. 
            //DEN FÅR INTE GÖRA NÅGRA UTSKRIFTER I KONSOLL FÖNSTRET!
            // om timmen är ett ental så ska det INTE inledas med noll medans om minuten är av ett ental så ska det inledas med 0
            // te x. 7:04 eller 13:37
        }
    
    }
}
