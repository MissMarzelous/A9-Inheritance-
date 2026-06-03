using System;

namespace Assignment9_Inheritance
{
    /// <summary>
    /// Base class representing Daytona State College.
    /// Provides the school name and a default address.
    /// Derived classes can override giveAddress() for campus-specific locations.
    /// </summary>
    class DSC
    {
        // Private field storing the school name
        private string schoolName = "Daytona State College";

        /// <summary>
        /// Returns the name of the school.
        /// </summary>
        public string GetSchoolName()
        {
            return schoolName;
        }

        /// <summary>
        /// Sets the name of the school.
        /// </summary>
        public void SetSchoolName(string name)
        {
            schoolName = name;
        }

        /// <summary>
        /// Virtual method — returns the default DSC main campus address.
        /// Derived classes override this to return their own address.
        /// </summary>
        public virtual string GiveAddress()
        {
            return "1200 W. International Speedway Blvd., Daytona Beach, Florida 32114";
        }
    }
}
