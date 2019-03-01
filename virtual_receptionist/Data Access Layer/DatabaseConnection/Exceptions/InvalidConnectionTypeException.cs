﻿using System;

namespace virtual_receptionist.DataAccessLayer.DatabaseConnection.Exceptions
{
    /// <summary>
    /// Adatbázis kapcsolódás típus kivétel
    /// </summary>
    public class InvalidConnectionTypeException : Exception
    {
        #region Konstruktor

        /// <summary>
        /// Adatbázis kapcsolódás típus kivétel
        /// </summary>
        public InvalidConnectionTypeException() : base("Érvénytelen adatbázis kapcsolódás típus!")
        {
        }

        #endregion
    }
}