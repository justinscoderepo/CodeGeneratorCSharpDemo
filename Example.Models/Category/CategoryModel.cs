///// <autogenerated>Remove this line to stop Code Generation</autogenerated>
///// <by>servermodel.txt</by>
///// <module>Category</module>
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryModel.cs" company="Example">
//   The category Model
// </copyright>
// <summary>
//   The category Model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Example.Models
{
    public class CategoryModel
    {
        ////region CustomCodeBlock1#
        ////endregion CustomCodeBlock1#
        /// _string_NOT_NULL_selected
        /// <summary>
        /// Gets or sets the from name.
        /// </summary>
        [Display(Name = "Name"), StringLength(20)]
        public string Name
        {
            get;
            set;
        }

        /// _string_NULL_selected
        /// <summary>
        /// Gets or sets the from description.
        /// </summary>
        [Display(Name = "Description"), StringLength(100)]
        public string Description
        {
            get;
            set;
        }

        /// _int_Primary_selected
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [Key, Display(Name = "Id")]
        public int Id
        {
            get;
            set;
        }
    }
}