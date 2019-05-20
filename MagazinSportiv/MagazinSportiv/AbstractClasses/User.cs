/// <copyright file="User.cs" >
/// Copyright (c) MagazinSportiv. All Right Reserved
/// </copyright>
/// <author>
/// Bodnariu Andreea, Grigoras Alexandru, Luncanu Iuliana, Suflet Ioan
/// </author>
/// <summary>
/// User abstract class
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
    public abstract class User
    {
        #region Protected Fields

        protected string _trainer;
        protected string _food;
        protected string _clothes;
        protected string _equipment;

        #endregion

        #region Public Methods

        public abstract void SelectTrainer(string trainer);

        public abstract void SelectFood(string food);

        public abstract void SelectClothes(string clothes);

        public abstract void SelectEquipment(string equipment);

        public abstract void PrintTraining();

        #endregion
    }
}
