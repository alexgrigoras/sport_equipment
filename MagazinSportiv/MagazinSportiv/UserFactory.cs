/// <copyright file="UserFactory.cs" >
/// Copyright (c) MagazinSportiv. All Right Reserved
/// </copyright>
/// <author>
/// Bodnariu Andreea, Grigoras Alexandru, Luncanu Iuliana, Suflet Ioan
/// </author>
/// <summary>
/// UserFactory class that creates a new user. The design pattern used is Simple Factory
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
    public class UserFactory
    {
        #region Public Methods

        /// <function>CreateUser</function>
        /// <param name="userType">The type of the user</param>
        /// <return>Returns a user object</return>
        /// <summary>Costructor of the class</summary>
        public User CreateUser(UserType userType)
        {
            User _activeUser = null;

            if (userType == UserType.FitnessUser)
            {
                _activeUser = new FitnessUser();
            }
            else if (userType == UserType.ZumbaUser)
            {
                _activeUser = new ZumbaUser();
            }
            else if (userType == UserType.AerobicUser)
            {
                _activeUser = new AerobicUser();
            }

            return _activeUser;
        } 

        #endregion
    }
}
