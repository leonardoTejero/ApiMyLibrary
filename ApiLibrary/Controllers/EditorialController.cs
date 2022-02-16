﻿using ApiLibrary.Handlers;
using Common.Utils.Enums;
using Common.Utils.Helpers;
using Common.Utils.Resorces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.Domain.Dto;
using MyLibrary.Domain.Dto.Editorial;
using MyLibrary.Domain.Services.Interface;
using MyVet.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Common.Utils.Constant.Const;

namespace ApiLibrary.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(CustomExceptionHandler))]
    public class EditorialController : ControllerBase
    {
        #region Attribute
        private readonly IEditorialServices _editorialServices;
        #endregion

        #region Buider
        public EditorialController(IEditorialServices editorialServices)
        {
            _editorialServices = editorialServices;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Obtener todas las editoriales
        /// </summary>
        /// <returns></returns>
        /// <response code="200">OK! </response>
        /// <response code="400">Business Exception</response>
        /// <response code="500">Oops! Can't process your request now</response>
        [HttpGet]
        [Route("GetAllEditoriales")]
        [CustomPermissionFilter(Enums.Permission.ConsultarEditorial)]
        public IActionResult GetAllEditoriales()
        {
            List<EditorialDto> list = _editorialServices.GetAllEditorial();

            ResponseDto response = new ResponseDto()
            {
                IsSuccess = true,
                Result = list,
                Message = string.Empty
            };

            return Ok(response);
        }

        /// <summary>
        /// Eliminar un editorial en específico
        /// </summary>
        /// <param name="idEditorial"></param>
        /// <returns></returns>
        /// <response code="200">OK! </response>
        /// <response code="400">Business Exception</response>
        /// <response code="500">Oops! Can't process your request now</response>
        [HttpDelete]
        [Route("DeleteEditorial")]
        [CustomPermissionFilter(Enums.Permission.EliminarEditorial)]
        public async Task<IActionResult> DeleteEditorial(int idEditorial)
        {
            IActionResult response; //bandera

            ResponseDto result = await _editorialServices.DeleteEditorialAsync(idEditorial);
            if (result.IsSuccess)
                response = Ok(result);
            else
                response = BadRequest(result);

            return response;
        }

        /// <summary>
        /// Agregar una nueva editorial 
        /// </summary>
        /// <param name="Editorial"></param>
        /// <returns></returns>
        /// <response code="200">OK! </response>
        /// <response code="400">Business Exception</response>
        /// <response code="500">Oops! Can't process your request now</response>
        [HttpPost]
        [Route("InsertEditorial")]
        [CustomPermissionFilter(Enums.Permission.CrearEditorial)]
        public async Task<IActionResult> InsertEditorial(InsertEditorialDto editorial)
        {
            IActionResult response;
            string idUser = Utils.GetClaimValue(Request.Headers["Authorization"], TypeClaims.IdUser);

            bool result = await _editorialServices.InsertEditorialAsync(editorial, Convert.ToInt32(idUser));

            ResponseDto responseDto = new ResponseDto()
            {
                IsSuccess = result,
                Result = result,
                Message = result ? GeneralMessages.ItemInserted : GeneralMessages.ItemNoInserted
            };

            if (result)
                response = Ok(responseDto);
            else
                response = BadRequest(responseDto);

            return response;
        }

        /// <summary>
        /// Actualizar una editorial en específico
        /// </summary>
        /// <param name="editorial"></param>
        /// <returns></returns>
        /// <response code="200">OK! </response>
        /// <response code="400">Business Exception</response>
        /// <response code="500">Oops! Can't process your request now</response>
        [HttpPut]
        [Route("UpdateEditorial")]
        [CustomPermissionFilter(Enums.Permission.ActualizarEditorial)]
        public async Task<IActionResult> UpdateEditorial(EditorialDto editorial)
        {
            IActionResult response;

            bool result = await _editorialServices.UpdateEditorialAsync(editorial);
            ResponseDto responseDto = new ResponseDto()
            {
                IsSuccess = result,
                Result = result,
                Message = result ? GeneralMessages.ItemUpdated : GeneralMessages.ItemNoUpdated
            };

            if (result)
                response = Ok(responseDto);
            else
                response = BadRequest(responseDto);

            return response;
        }


        #endregion
    }
}
