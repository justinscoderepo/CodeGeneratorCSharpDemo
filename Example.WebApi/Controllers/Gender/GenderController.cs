///// <autogenerated>Remove this line to stop Code Generation</autogenerated>
///// <by>servercontroller.txt</by>
///// <module>Gender</module>
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
    ///<summary> The gender controller. </summary>
    [ApiController]
    [Route("gender")]
    public class GenderController : ApiBaseController
    {
        private const string groupName = "Gender";
        private IGenderService _logic;
        ////region CustomCodeBlockPrivateVariables#
        ////endregion CustomCodeBlockPrivateVariables#
        ///<summary> The gender constructor. </summary>
        public GenderController(IGenderService logic////region CustomCodeBlockInjection#
        ////endregion CustomCodeBlockInjection#
        )
        {
            _logic = logic;
        ////region CustomCodeBlockCBody#
        ////endregion CustomCodeBlockCBody#
        }

        /// <summary>Get the gender list.</summary>
        /// <param name = "model">The gender model.</param>
        /// <returns>The <see cref = "IActionResult"/>.</returns>
        [HttpGet("")]
        [SwaggerOperation(Tags = new[]{groupName})]
        public IActionResult Get([FromQuery] GenderModel model = null, [FromQuery] PaginationModel paginationModel = null, [FromQuery] SortModel sortModel = null)
        {
            if (model == null)
            {
                model = new GenderModel();
            }

            ////region CustomCodeBlockBeforeGet#
            ////endregion CustomCodeBlockBeforeGet#
            var results = _logic.Get(model, paginationModel, sortModel);
            ////region CustomCodeBlockAfterGet#
            ////endregion CustomCodeBlockAfterGet#
            return this.Ok(results);
        }

        /// <summary>Create the gender.</summary>
        /// <param name = "model">gender model.</param>
        /// <returns>The <see cref = "IActionResult"/>.</returns>
        [HttpPost("")]
        [SwaggerOperation(Tags = new[]{groupName})]
        public IActionResult Create([FromForm] GenderModel model)
        {
            var row = this.SaveRow(model);
            return this.Ok(row);
        }

        /// <summary>Update the gender.</summary>
        /// <param name = "model">gender model.</param>
        /// <returns>The <see cref = "IActionResult"/>.</returns>
        [HttpPut("")]
        [SwaggerOperation(Tags = new[]{groupName})]
        public IActionResult Save([FromForm] GenderModel model)
        {
            var row = this.SaveRow(model);
            return this.Ok(row);
        }

        /// <summary>Remove gender.</summary>
        /// <param name = "model">gender model.</param>
        /// <returns>The <see cref = "IActionResult"/>.</returns>
        [HttpDelete("")]
        [SwaggerOperation(Tags = new[]{groupName})]
        public IActionResult Remove([FromForm] GenderModel model = null)
        {
            if (model == null)
            {
                return this.Ok(new DeleteResponseModel("Can't save items due to missing some information or invalid data", false));
            }

            var results = _logic.Delete(model);
            return this.Ok(results);
        }

        /// <summary>Save gender.</summary>
        /// <param name = "model">gender model.</param>
        /// <returns>The <see cref = "GenderModel"/>.</returns>
        private RawResponseModel<GenderModel> SaveRow(GenderModel model)
        {
            if (model == null)
            {
                return new RawResponseModel<GenderModel>(null, "model can't be null!", false);
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