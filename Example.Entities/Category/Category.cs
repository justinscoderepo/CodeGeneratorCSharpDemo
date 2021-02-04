///// <autogenerated>Remove this line to stop Code Generation</autogenerated>
///// <by>serverentity.txt</by>
///// <module>Category</module>
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="Example">
//   The category Entity
// </copyright>
// <summary>
//   The category Entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example.Data.Entities
{
    [Table("ml_category")]
    public class Category
    {
        /// <summary>
        /// Gets or sets the from name.
        /// </summary>
        [Column("ca_name"), Description("Name"), Required, MaxLength(20)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Column("ca_description"), Description("Description"), MaxLength(100)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ca_id")]
        [Display(Name = "Id")]
        public int Id
        {
            get;
            set;
        }

        /// _DateTime_NULL_base
        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        [Column("ca_createddate"), Description("Created Date")]
        public DateTime? Createddate
        {
            get;
            set;
        }

        /// _DateTime_NULL_base
        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        [Column("ca_modifieddate"), Description("Modified Date")]
        public DateTime? Modifieddate
        {
            get;
            set;
        }
    ////region CustomCodeBlock4#
    ////endregion CustomCodeBlock4#
    ////region CustomCodeBlock5#
    ////endregion CustomCodeBlock5#
    }
}