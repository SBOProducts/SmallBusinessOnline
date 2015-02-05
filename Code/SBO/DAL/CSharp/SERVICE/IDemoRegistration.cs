// CREATED BY: Nathan Townsend
// CREATED DATE: 12/28/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using SBO.DO;

namespace SBO.Service
{



    /// <summary>
    /// Provides the interface for data access methods to the DemoRegistration database table
    /// </summary>
    /// <remarks>
    public interface IDemoRegistrationService
    {


        /// <summary>
        /// Creates a new DemoRegistration record
        /// </summary>
        int Create(DemoRegistrationDO DO);
        

        /// <summary>
        /// Creates a new DemoRegistration record
        /// </summary>
        int Create(DemoRegistrationDO DO, DalapiTransaction Transaction);


        /// <summary>
        /// Updates a DemoRegistration record and returns the number of records affected
        /// </summary>
        int Update(DemoRegistrationDO DO);


        /// <summary>
        /// Updates a DemoRegistration record and returns the number of records affected
        /// </summary>
        int Update(DemoRegistrationDO DO, DalapiTransaction Transaction);


        /// <summary>
        /// Deletes a DemoRegistration record
        /// </summary>
        int Delete(DemoRegistrationDO DO);

        /// <summary>
        /// Deletes a DemoRegistration record
        /// </summary>
        int Delete(DemoRegistrationDO DO, DalapiTransaction Transaction);


        /// <summary>
        /// Gets all DemoRegistration records
        /// </summary>
        DemoRegistrationDO[] GetAll();


        /// <summary>
        /// Selects DemoRegistration records by PK
        /// </summary>
        DemoRegistrationDO[] GetByPK(Int32 DemoRegistrationId);




        /// <summary>
        /// Truncates the DemoRegistration Table
        /// </summary>
        void Truncate();
        

        /// <summary>
        /// Truncates the DemoRegistration Table
        /// </summary>
        void Truncate(DalapiTransaction Transaction);

    }
}