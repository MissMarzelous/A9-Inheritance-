using System;

namespace Assignment9_Inheritance
{
    /// <summary>
    /// Represents a specific DSC campus.
    /// Inherits from DSC and overrides GiveAddress() and ToString()
    /// to provide campus-specific information.
    /// </summary>
    class Campus : DSC
    {
        /// <summary>Gets or sets the name of this campus.</summary>
        public string CampusName { get; set; }

        /// <summary>
        /// Initializes a Campus with the given campus name.
        /// </summary>
        public Campus(string campusName)
        {
            CampusName = campusName;
        }

        /// <summary>
        /// Returns the departments offered at this campus.
        /// </summary>
        public string GetDepartments()
        {
            return "Computer Science, the Police Academy, and Emergency Care.";
        }

        /// <summary>
        /// Overrides GiveAddress() to return this campus's specific address.
        /// </summary>
        public override string GiveAddress()
        {
            return "1770 Williamson Blvd., Daytona Beach, Florida 32117";
        }

        /// <summary>
        /// Overrides ToString() to return a formatted campus summary
        /// including school name, campus name, address, and departments.
        /// </summary>
        public override string ToString()
        {
            return GetSchoolName() + "  " + CampusName +
                   "\nThe school is located at " + GiveAddress() +
                   "\nThe school offers departments in " + GetDepartments();
        }
    }
}
