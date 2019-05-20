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

        /// <function>SelectTrainer</function>
        /// <param name="trainer">The name of the trainer</param>
        /// <summary>Select the name of the trainer</summary>
        public abstract void SelectTrainer(string trainer);

        /// <function>SelectFood</function>
        /// <param name="food">The name of the food</param>
        /// <summary>Select the name of the food</summary>
        public abstract void SelectFood(string food);

        /// <function>SelectClothes</function>
        /// <param name="clothes">The name of the clothes</param>
        /// <summary>Select the name of the clothes</summary>
        public abstract void SelectClothes(string clothes);

        /// <function>SelectEquipment</function>
        /// <param name="equipment">The name of the trainer</param>
        /// <summary>Select the name of the trainer</summary>
        public abstract void SelectEquipment(string equipment);

        /// <function>PrintTraining</function>
        /// <summary>Print the training  to the file</summary>
        public abstract void PrintTraining();

        #endregion
    }
}
