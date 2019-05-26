/// <copyright file="AerobicUser.cs" >
/// Copyright (c) MagazinSportiv. All Right Reserved
/// </copyright>
/// <author>
/// Bodnariu Andreea, Grigoras Alexandru, Luncanu Iuliana, Suflet Ioan
/// </author>
/// <summary>
/// AerobicUser concrete class
/// </summary>

#region using

using System;
using System.Diagnostics;
using LibPrinter;

#endregion

namespace SportEquipment
{
    public class AerobicUser : User
    {
        #region Public Ovverride Methods

        public override void SelectTrainer(string trainer)
        {
            _trainer = "aerobic-" + trainer;
        }

        public override void SelectFood(string food)
        {
            _food = "aerobic-" + food;
        }

        public override void SelectClothes(string clothes)
        {
            _clothes = "aerobic-" + clothes;
        }

        public override void SelectEquipment(string equipment)
        {
            _equipment = "aerobic-" + equipment;
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

            p.Writeln("Aerobic training\n");
            p.Writeln("----------------");
            p.Writeln("Aerobics is a form of physical exercise that combines rhythmic aerobic exercise with stretching and strength training routines with the goal of improving all elements of fitness (flexibility, muscular strength, and cardio-vascular fitness). It is usually performed to music and may be practiced in a group setting led by an instructor (fitness professional), although it can be done solo and without musical accompaniment. With the goal of preventing illness and promoting physical fitness, practitioners perform various routines comprising a number of different dance-like exercises. Formal aerobics classes are divided into different levels of intensity and complexity. A well-balanced aerobics class will have five components: warm-up (5–10 minutes), cardio vascular conditioning (25–30 minutes), muscular strength and conditioning (10–15 minutes), cool-down (5–8 minutes) and stretching and flexibility (5–8 minutes). Aerobics classes may allow participants to select their level of participation according to their fitness level. Many gyms offer a variety of aerobic classes. Each class is designed for a certain level of experience and taught by a certified instructor with a specialty area related to their particular class.");
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
