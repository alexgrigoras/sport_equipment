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

using System;
using System.Collections.Generic;
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
            _trainer = trainer;          
        }

        public override void SelectFood(string food)
        {
            _food = food;
        }

        public override void SelectClothes(string clothes)
        {
            _clothes = clothes;
        }

        public override void SelectEquipment(string equipment)
        {
            _equipment = equipment;
        }

        public override void PrintTraining()
        {
            // print the data to file
        }

        #endregion
    }
}
