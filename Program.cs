﻿using InstrumentLibrary.Models;
using System;

namespace InstrumentLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instrument item = new Instrument();
            Guitar myGuitar = new Guitar("Gibson");
            Mandolin myMandolin = new Mandolin("Kentucky KM-140");
            Ukulele myUkulele = new Ukulele("Ortega");

            myUkulele.serialNumber = "abc123";

            myGuitar.Play();
            myMandolin.Play();
            myUkulele.Play();
        }
    }
}
