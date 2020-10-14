/// <copyright file="FitnessUser.cs" >
/// Copyright (c) MagazinSportiv. All Right Reserved
/// </copyright>
/// <author>
/// Bodnariu Andreea, Grigoras Alexandru, Luncanu Iuliana, Suflet Ioan
/// </author>
/// <summary>
/// FitnessUser concrete class
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
    public class FitnessUser : User
    {
        #region Public Ovverride Methods
        
        public override void SelectTrainer(string trainer)
        {
            _trainer = "fitness-" + trainer;          
        }

        public override void SelectFood(string food)
        {
            _food = "fitness-" + food;
        }

        public override void SelectClothes(string clothes)
        {
            _clothes = "fitness-" + clothes;
        }

        public override void SelectEquipment(string equipment)
        {
            _equipment = "fitness-" + equipment;
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

            p.Writeln("Fitness training\n");
            p.Writeln("----------------");
            p.Writeln("Fitness is the quantitative representation of natural and sexual selection within evolutionary biology. It can be defined either with respect to a genotype or to a phenotype in a given environment. In either case, it describes individual reproductive success and is equal to the average contribution to the gene pool of the next generation that is made by individuals of the specified genotype or phenotype. The fitness of a genotype is manifested through its phenotype, which is also affected by the developmental environment. The fitness of a given phenotype can also be different in different selective environments.");
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
