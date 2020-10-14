/// <copyright file="ZumbaUser.cs" >
/// Copyright (c) MagazinSportiv. All Right Reserved
/// </copyright>
/// <author>
/// Bodnariu Andreea, Grigoras Alexandru, Luncanu Iuliana, Suflet Ioan
/// </author>
/// <summary>
/// ZumbaUser concrete class
/// </summary>

#region using

using LibPrinter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace SportEquipment
{
    public class ZumbaUser : User
    {
        #region Public Ovverride Methods

        public override void SelectTrainer(string trainer)
        {
            _trainer = "zumba-" + trainer;
        }

        public override void SelectFood(string food)
        {
            _food = "zumba-" + food;
        }

        public override void SelectClothes(string clothes)
        {
            _clothes = "zumba-" + clothes;
        }

        public override void SelectEquipment(string equipment)
        {
            _equipment = "zumba-" + equipment;
        }

        public override void PrintTraining()
        {
            // print the training data to file
            string dateTime = DateTime.Now.ToString("dddd_dd_MMMM_yyyy_HH_mm");
            string fileName = "workouts/workout_" + dateTime + ".txt";

            System.IO.Directory.CreateDirectory("workouts");

            Printer p = new Printer(fileName);

            if (!p.OpenFile())
            {
                throw new Exception("Directorul sau fisierul este invalid");
            }

            p.Writeln("Zumba training\n");
            p.Writeln("----------------");
            p.Writeln("Zumba is an exercise fitness program created by Colombian-American dancer and choreographer Alberto Perez during the 1990s.[1] A Zumba class combines fast and slow rhythms that tone and sculpt the body using principles from aerobic and fitness to achieve cardio and muscle-toning benefits.[2] . In every Zumba lesson four core rhythms are always present: merengue, salsa, cumbia and reggaeton. Besides, there are other six official rhythms that might be incorporated in the instructor playlist, these are: belly dance, flamenco, tango, samba, soca and quebradita.[3] Once the instructor has included the four core rhythms in the playlist, he/she can choose out of the other six official rhythms or other internationally famous songs to finish off his/her 1 hour Zumba playlist. Other very popular rhythms that could be found in a Zumba class are: dancehall, dembow, bhangra, hip-hop, bachata, mambo. The Zumba trademark is owned by Zumba Fitness, LLC, which does not charge licensing fees to gyms or fitness centers.[4] Approximately 15 million people take weekly Zumba classes in over 200,000 locations across 180 countries.[5] The Brazilian pop singer Claudia Leitte is the international ambassador for Zumba Fitness.[6]");
            p.Writeln("----------------\n");
            p.Writeln("Selected workout:");
            p.Writeln("- Trainer: " + _trainer);
            p.Writeln("- Food: " + _food);
            p.Writeln("- Clothes: " + _clothes);
            p.Writeln("- Equipment: " + _equipment);

            p.CloseFile();

            Process.Start("notepad.exe", fileName);
        }

        #endregion
    }
}
