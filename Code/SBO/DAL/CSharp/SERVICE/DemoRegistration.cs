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
    /// Provides data access methods for the DemoRegistration database table
    /// </summary>
    /// <remarks>
    public class DemoRegistrationService: IDemoRegistrationService
    {

        private string pid;

        /// <summary>
        /// Creates a new instance of the DemoRegistration service using the named connection string
        /// </summary>
        public DemoRegistrationService(string ConnectionStringName)
        {
            pid = ConnectionStringName;
        }


        /// <summary>
        /// Creates a new DemoRegistration record
        /// </summary>
        public int Create(DemoRegistrationDO DO)
        {
            return Create(null); 
        }
        

        /// <summary>
        /// Creates a new DemoRegistration record
        /// </summary>
        public int Create(DemoRegistrationDO DO, DalapiTransaction Transaction)
        {
            SqlParameter _CompanyName = new SqlParameter("CompanyName", SqlDbType.VarChar);
            SqlParameter _Name = new SqlParameter("Name", SqlDbType.VarChar);
            SqlParameter _Email = new SqlParameter("Email", SqlDbType.VarChar);
            SqlParameter _Phone = new SqlParameter("Phone", SqlDbType.VarChar);
            SqlParameter _Submitted = new SqlParameter("Submitted", SqlDbType.DateTime);
            SqlParameter _Code = new SqlParameter("Code", SqlDbType.VarChar);
            
            _CompanyName.Value = DO.CompanyName;
            _Name.Value = DO.Name;
            _Email.Value = DO.Email;
            _Phone.Value = DO.Phone;
            _Submitted.Value = DO.Submitted;
            _Code.Value = DO.Code;
            
            SqlParameter[] _params = new SqlParameter[] {
                _CompanyName,
                _Name,
                _Email,
                _Phone,
                _Submitted,
                _Code
            };


            return DataCommon.ExecuteScalar(String.Format("[{0}].[DemoRegistration_Insert]", pid), _params, pid, Transaction);
            
        }


        /// <summary>
        /// Updates a DemoRegistration record and returns the number of records affected
        /// </summary>
        public int Update(DemoRegistrationDO DO)
        {
             return Update(DO, null);
        }


        /// <summary>
        /// Updates a DemoRegistration record and returns the number of records affected
        /// </summary>
        public int Update(DemoRegistrationDO DO, DalapiTransaction Transaction)
        {
            SqlParameter _DemoRegistrationId = new SqlParameter("DemoRegistrationId", SqlDbType.Int);
            SqlParameter _CompanyName = new SqlParameter("CompanyName", SqlDbType.VarChar);
            SqlParameter _Name = new SqlParameter("Name", SqlDbType.VarChar);
            SqlParameter _Email = new SqlParameter("Email", SqlDbType.VarChar);
            SqlParameter _Phone = new SqlParameter("Phone", SqlDbType.VarChar);
            SqlParameter _Submitted = new SqlParameter("Submitted", SqlDbType.DateTime);
            SqlParameter _Code = new SqlParameter("Code", SqlDbType.VarChar);
            
            _DemoRegistrationId.Value = DO.DemoRegistrationId;
            _CompanyName.Value = DO.CompanyName;
            _Name.Value = DO.Name;
            _Email.Value = DO.Email;
            _Phone.Value = DO.Phone;
            _Submitted.Value = DO.Submitted;
            _Code.Value = DO.Code;
            
            SqlParameter[] _params = new SqlParameter[] {
                _DemoRegistrationId,
                _CompanyName,
                _Name,
                _Email,
                _Phone,
                _Submitted,
                _Code
            };

            return DataCommon.ExecuteScalar(String.Format("[{0}].[DemoRegistration_Update]", pid), _params, pid, Transaction);
        }


        /// <summary>
        /// Deletes a DemoRegistration record
        /// </summary>
        public int Delete(DemoRegistrationDO DO)
        {
            return Delete(DO, null);
        }

        /// <summary>
        /// Deletes a DemoRegistration record
        /// </summary>
        public int Delete(DemoRegistrationDO DO, DalapiTransaction Transaction)
        {
            SqlParameter _DemoRegistrationId = new SqlParameter("DemoRegistrationId", SqlDbType.Int);
            
            _DemoRegistrationId.Value = DO.DemoRegistrationId;
            
            SqlParameter[] _params = new SqlParameter[] {
                _DemoRegistrationId
            };


            return DataCommon.ExecuteScalar(String.Format("[{0}].[DemoRegistration_Delete]", pid), _params, pid, Transaction);
        }


        /// <summary>
        /// Gets all DemoRegistration records
        /// </summary>
        public DemoRegistrationDO[] GetAll()
        {

            SafeReader sr = DataCommon.ExecuteSafeReader(String.Format("[{0}].[DemoRegistration_GetAll]", pid), new SqlParameter[] { }, pid);
            
            List<DemoRegistrationDO> objs = new List<DemoRegistrationDO>();
            
            while(sr.Read()){

                DemoRegistrationDO obj = new DemoRegistrationDO();
                
                obj.DemoRegistrationId = sr.GetInt32(sr.GetOrdinal("DemoRegistrationId"));
                obj.CompanyName = sr.GetString(sr.GetOrdinal("CompanyName"));
                obj.Name = sr.GetString(sr.GetOrdinal("Name"));
                obj.Email = sr.GetString(sr.GetOrdinal("Email"));
                obj.Submitted = sr.GetDateTime(sr.GetOrdinal("Submitted"));
                if (sr.IsDBNull(sr.GetOrdinal("Phone"))) { obj.Phone = null; } else { obj.Phone = sr.GetString(sr.GetOrdinal("Phone")); }
                if (sr.IsDBNull(sr.GetOrdinal("Code"))) { obj.Code = null; } else { obj.Code = sr.GetString(sr.GetOrdinal("Code")); }


                objs.Add(obj);
            }

            return objs.ToArray();
        }


        /// <summary>
        /// Selects DemoRegistration records by PK
        /// </summary>
        public DemoRegistrationDO[] GetByPK(Int32 DemoRegistrationId)
        {

            SqlParameter _DemoRegistrationId = new SqlParameter("DemoRegistrationId", SqlDbType.Int);
			
            _DemoRegistrationId.Value = DemoRegistrationId;
			
            SqlParameter[] _params = new SqlParameter[] {
                _DemoRegistrationId
            };


            SafeReader sr = DataCommon.ExecuteSafeReader(String.Format("[{0}].[DemoRegistration_GetByPK]", pid), _params, pid);


            List<DemoRegistrationDO> objs = new List<DemoRegistrationDO>();
			
            while(sr.Read())
            {
                DemoRegistrationDO obj = new DemoRegistrationDO();
				
                obj.DemoRegistrationId = sr.GetInt32(sr.GetOrdinal("DemoRegistrationId"));
                obj.CompanyName = sr.GetString(sr.GetOrdinal("CompanyName"));
                obj.Name = sr.GetString(sr.GetOrdinal("Name"));
                obj.Email = sr.GetString(sr.GetOrdinal("Email"));
                obj.Submitted = sr.GetDateTime(sr.GetOrdinal("Submitted"));
                if (sr.IsDBNull(sr.GetOrdinal("Phone"))) { obj.Phone = null; } else { obj.Phone = sr.GetString(sr.GetOrdinal("Phone")); }
                if (sr.IsDBNull(sr.GetOrdinal("Code"))) { obj.Code = null; } else { obj.Code = sr.GetString(sr.GetOrdinal("Code")); }

                objs.Add(obj);
            }

            return objs.ToArray();
        }




        /// <summary>
        /// Truncates the DemoRegistration Table
        /// </summary>
        public void Truncate()
        {
            Truncate(null);
        }


        /// <summary>
        /// Truncates the DemoRegistration Table
        /// </summary>
        public void Truncate(DalapiTransaction Transaction)
        {
            DataCommon.TruncateTable(pid, "DemoRegistration", Transaction);
        }

    }
}