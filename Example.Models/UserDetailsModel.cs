///// <autogenerated>Remove this line to stop Code Generation</autogenerated>
///// <by>servermodel.txt</by>
///// <module>UserDetails</module>
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetailsModel.cs" company="Example">
//   The user Model
// </copyright>
// <summary>
//   The user Model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Example.Models
{
    public class UserDetailsModel
    {
        ////region CustomCodeBlock1#
        ////endregion CustomCodeBlock1#
        /// int_NULL_selected_Foreign
        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        [Display(Name = "Created By"), Range(int.MinValue, int.MaxValue)]
        public int? CreatedById
        {
            get;
            set;
        }

        /// _DateTime_NULL_selected
        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        [Display(Name = "Modified Date")]
        public DateTime? ModifiedDate
        {
            get;
            set;
        }

        /// _float_NULL
        /// <summary>
        /// Gets or sets the commission rate.
        /// </summary>
        [Display(Name = "Commission Rate"), Range(int.MinValue, int.MaxValue)]
        public int? CommissionRate
        {
            get;
            set;
        }

        /// int_NOT_NULL_selected_Foreign
        /// <summary>
        /// Gets or sets the flag.
        /// </summary>
        [Display(Name = "Flag"), Range(int.MinValue, int.MaxValue)]
        public int FlagId
        {
            get;
            set;
        }

        /// _string_NULL_selected
        /// <summary>
        /// Gets or sets the from logo.
        /// </summary>
        [Display(Name = "Logo"), StringLength(500)]
        public string Logo
        {
            get;
            set;
        }

        /// int_NOT_NULL_selected_Foreign
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [Display(Name = "Status"), Range(int.MinValue, int.MaxValue)]
        public int StatusId
        {
            get;
            set;
        }
    }
}