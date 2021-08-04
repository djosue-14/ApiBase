using System;
using APIBase.Base.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBase.Base.Extensions
{
    public class JsonResponse : IJsonResponse
    {
        public JsonResult SuccessResult(object value, string message, int? code)
        {
            code ??= StatusCodes.Status200OK;

            return SuccessResult(value, message, code.Value);
        }

        private JsonResult SuccessResult(object value, string message, int code)
            => code switch
            {
                StatusCodes.Status201Created => Created(value, message),
                StatusCodes.Status202Accepted => Accepted(value, message),
                StatusCodes.Status204NoContent => NoContent(message),
                _ => Ok(value, message)
            };

        public JsonResult ErrorResult(object value, string message, Exception exception, int? code)
        {
            code ??= StatusCodes.Status500InternalServerError;

            return ErrorResult(value, message, exception, code.Value);
        }

        private JsonResult ErrorResult(object value, string message, Exception exception, int code)
            => code switch
            {
                StatusCodes.Status400BadRequest => BadRequest(value, message, exception),
                StatusCodes.Status401Unauthorized => Unauthorized(value, message, exception),
                StatusCodes.Status403Forbidden => Conflict(value, message, exception),
                StatusCodes.Status404NotFound => NotFound(value, message, exception),
                StatusCodes.Status409Conflict => Conflict(value, message, exception),
                StatusCodes.Status422UnprocessableEntity => UnprocessableEntity(value, message, exception),
                _ => InternalServer(value, message, exception)
            };

        public JsonResult Ok(object value, string message)
            => new(SuccessObject(value, message))
            {
                StatusCode = StatusCodes.Status200OK
            };

        public JsonResult Created(object value, string message)
            => new(SuccessObject(value, message))
            {
                StatusCode = StatusCodes.Status201Created
            };

        public JsonResult Accepted(object value, string message)
            => new(SuccessObject(value, message))
            {
                StatusCode = StatusCodes.Status202Accepted
            };

        public JsonResult NoContent(string message)
            => new(SuccessObject(null, message))
            {
                StatusCode = StatusCodes.Status204NoContent
            };

        public JsonResult BadRequest(object value, string message, Exception exception)
            => new(ErrorObject(value, message, exception))
            {
                StatusCode = StatusCodes.Status400BadRequest
            };

        public JsonResult Unauthorized(object value, string message, Exception exception)
            => new(ErrorObject(value, message, exception))
            {
                StatusCode = StatusCodes.Status400BadRequest
            };

        public JsonResult Forbid(object value, string message, Exception exception)
            => new(ErrorObject(value, message, exception))
            {
                StatusCode = StatusCodes.Status403Forbidden
            };

        public JsonResult NotFound(object value, string message, Exception exception)
            => new(ErrorObject(value, message, exception))
            {
                StatusCode = StatusCodes.Status404NotFound
            };

        public JsonResult Conflict(object value, string message, Exception exception)
            => new(ErrorObject(value, message, exception))
            {
                StatusCode = StatusCodes.Status409Conflict
            };

        public JsonResult UnprocessableEntity(object value, string message, Exception exception)
            => new(ErrorObject(value, message, exception))
            {
                StatusCode = StatusCodes.Status422UnprocessableEntity
            };
        
        public JsonResult InternalServer(object value, string message, Exception exception)
            => new(ErrorObject(value, message, exception))
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

        private dynamic SuccessObject(object value, string message)
            => new
            {
                data = value,
                message = string.IsNullOrEmpty(message) ? "Solicitud procesada correctamente." : message
            };

        private dynamic ErrorObject(object value, string message, Exception exception)
            => new
            {
                data = value,
                message = string.IsNullOrEmpty(message) ? "Ocurrió un error al procesar la solicitud." : message,
                Exception = exception?.Message
            };
    }
}