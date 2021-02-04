///// <autogenerated>Remove this line to stop Code Generation</autogenerated>
///// <by>servercontroller.txt</by>
///// <module>Category</module>
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Example.Models;
using Example.Models.Common;
using Example.Business.Contracts;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace Example.WebApi.Controllers
{
    ///<summary> The category controller. </summary>
    [ApiController]
    [Route("category")]
    public class CategoryController : ApiBaseController
    {
        private const string groupName = "Category";
        private ICategoryService _logic;
        ////region CustomCodeBlockPrivateVariables#
        ////endregion CustomCodeBlockPrivateVariables#
        ///<summary> The category constructor. </summary>
        public CategoryController(ICategoryService logic////region CustomCodeBlockInjection#
        ////endregion CustomCodeBlockInjection#
        )
        {
            _logic = logic;
        ////region CustomCodeBlockCBody#
        ////endregion CustomCodeBlockCBody#
        }

        /// <summary>Get the category list.</summary>
        /// <param name = "model">The category model.</param>
        /// <returns>The <see cref = "IActionResult"/>.</returns>
        [HttpGet("")]
        [SwaggerOperation(Tags = new[]{groupName})]
        public IActionResult Get([FromQuery] CategoryModel model = null)
        {
            if (model == null)
            {
                model = new CategoryModel();
            }

            ////region CustomCodeBlockBeforeGet#
            ////endregion CustomCodeBlockBeforeGet#
            var results = _logic.Get(model);
            ////region CustomCodeBlockAfterGet#
            ////endregion CustomCodeBlockAfterGet#
            return this.Ok(results);
        }

        /// <summary>Create the category.</summary>
        /// <param name = "model">category model.</param>
        /// <returns>The <see cref = "IActionResult"/>.</returns>
        [HttpPost("")]
        [SwaggerOperation(Tags = new[]{groupName})]
        public IActionResult Create([FromForm] CategoryModel model)
        {
            var row = this.SaveRow(model);
            return this.Ok(row);
        }

        /// <summary>Update the category.</summary>
        /// <param name = "model">category model.</param>
        /// <returns>The <see cref = "IActionResult"/>.</returns>
        [HttpPut("")]
        [SwaggerOperation(Tags = new[]{groupName})]
        public IActionResult Save([FromForm] CategoryModel model)
        {
            var row = this.SaveRow(model);
            return this.Ok(row);
        }

        /// <summary>Remove category.</summary>
        /// <param name = "model">category model.</param>
        /// <returns>The <see cref = "IActionResult"/>.</returns>
        [HttpDelete("")]
        [SwaggerOperation(Tags = new[]{groupName})]
        public IActionResult Remove([FromForm] CategoryModel model = null)
        {
            if (model == null)
            {
                return this.Ok(new DeleteResponseModel("Can't save items due to missing some information or invalid data", false));
            }

            var results = _logic.Delete(model);
            return this.Ok(results);
        }

        /// <summary>Save category.</summary>
        /// <param name = "model">category model.</param>
        /// <returns>The <see cref = "CategoryModel"/>.</returns>
        private RawResponseModel<CategoryModel> SaveRow(CategoryModel model)
        {
            if (model == null)
            {
                return new RawResponseModel<CategoryModel>(null, "model can't be null!", false);
            }

            ////region CustomCodeBlockBeforeSave#
            ////endregion CustomCodeBlockBeforeSave#
            var result = _logic.Save(model);
            var primaryId = result.Data.Id;
            ////region CustomCodeBlockSubICollectionSave#
            ////endregion CustomCodeBlockSubICollectionSave#
            return result;
        }
    }
}