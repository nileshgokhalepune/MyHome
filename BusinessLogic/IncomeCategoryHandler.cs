﻿using System.Collections.Generic;
using DataAccess;
using LocalTypes;
using System.Linq;

namespace BusinessLogic
{
    /// <summary>
    /// Holds methods for sorting and making calculations on the data of income categories
    /// Is also the bridge from the UI to the Dal
    /// </summary>
    public class IncomeCategoryHandler : BaseCategoryHandler
    {
        #region CRUD Methods

        #region Read Methods

        /// <summary>
        /// Loads a specific Income Category from the cache
        /// </summary>
        /// <param name="id">The id of the Income category wanted</param>
        /// <returns>The Income category as it is in the cache</returns>
        public static IncomeCategory LoadById(int id)
        {
            return IncomeCategoryAccess.LoadById(id);
        }

        /// <summary>
        /// Loads all the Income Categories from the cache
        /// </summary>
        /// <returns>All the Income Categories as they are in the cache in generic-based
        /// list
        /// </returns>
        public override List<BaseCategory> LoadAll()
        {
            return (new IncomeCategoryAccess()).LoadAll();
        }

        #endregion

        #region Update Methods

        public override bool Save(BaseCategory categoryToSave)
        {
            return (new ExpenseCategoryAccess()).Save(categoryToSave);
        }

        #endregion
        
        #endregion
    }
}