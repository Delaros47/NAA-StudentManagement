using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementUI.Common.Functions
{
    #region Comment
    /*
     * Here will create an extension method that's why we make it our class as static
     */
    #endregion
    public static class EnumFunctions
    {
        #region Comment
        /*
         * Here we will create GetAttribute extension method it will go to FormType then it will get Description for any Form, for example School is "School Record" and memberInfo will get any FormType enum what we want for Example School then then attributes go to School enum then get the attribute of it but it asks type we wrote T and it asks that do you want to get inherited attributes as well we don't want so we write false and in the end we
         */
        #endregion
        private static T GetAttribute<T>(this Enum value) where T:Attribute
        {
            if (value == null) return null;
            var memberInfo = value.GetType().GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes[0];
        }

        #region Comment
        /*
         * Here we create another extension method this one will go and GetAttribute method then on ToName method it will return exactly attribute of Description as string if our Attribute is null then it will just simply return School itself if not then it will return 
         */
        #endregion
        public static string ToName(this Enum value)
        {
            if (value == null) return null;
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }


    }
}
