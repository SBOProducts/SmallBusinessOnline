// CREATED BY: Nathan Townsend
// CREATED DATE: 12/28/2014
// DO NOT MODIFY THIS CODE
// CHANGES WILL BE LOST WHEN THE GENERATOR IS RUN AGAIN
// GENERATION TOOL: Dalapi Code Generator (DalapiPro.com)



using System;

namespace SBO.DO
{
    /// <summary>
    /// Encapsulates a row of data in the DemoRegistration table
    /// </summary>
    public partial class DemoRegistrationDO
    {

        public virtual Int32 DemoRegistrationId {get; set;}
        public virtual String CompanyName {get; set;}
        public virtual String Name {get; set;}
        public virtual String Email {get; set;}
        public virtual String Phone {get; set;}
        public virtual DateTime Submitted {get; set;}
        public virtual String Code {get; set;}

    }
}