using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBase.Base.Interfaces
{
    public interface IJsonResponse
    {
        /// <summary>
        /// Creates a <see cref="JsonResult"/> object associated to HTTP <see cref="StatusCodes"/>.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <param name="code">The http status code to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> object for the response.</returns>
        public JsonResult SuccessResult(object value, string message, int? code);

        /// <summary>
        /// Creates a <see cref="JsonResult"/> object associated to HTTP <see cref="StatusCodes"/>.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <param name="exception">The exception to format in the json object.</param>
        /// <param name="code">The http status code to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> object for the response.</returns>
        public JsonResult ErrorResult(object value, string message, Exception exception, int? code);
        
        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status200OK"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult Ok(object value, string message);
        
        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status201Created"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult Created(object value, string message);
        
        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status202Accepted"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult Accepted(object value, string message);

        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces an empty
        /// <see cref="StatusCodes.Status204NoContent"/> response.
        /// </summary>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> object for the response.</returns>
        public JsonResult NoContent(string message);
        
        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status400BadRequest"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <param name="exception">The exception to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult BadRequest(object value, string message, Exception exception);

        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status401Unauthorized"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <param name="exception">The exception to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult Unauthorized(object value, string message, Exception exception);
        
        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status403Forbidden"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <param name="exception">The exception to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult Forbid(object value, string message, Exception exception);
        
        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status404NotFound"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <param name="exception">The exception to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult NotFound(object value, string message, Exception exception);
        
        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status409Conflict"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <param name="exception">The exception to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult Conflict(object value, string message, Exception exception);

        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status422UnprocessableEntity"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <param name="exception">The exception to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult UnprocessableEntity(object value, string message, Exception exception);
        
        /// <summary>
        /// Creates a <see cref="JsonResult"/> object that produces a <see cref="StatusCodes.Status500InternalServerError"/> response.
        /// </summary>
        /// <param name="value">The content value to format in the json object.</param>
        /// <param name="message">The custom message to format in the json object.</param>
        /// <param name="exception">The exception to format in the json object.</param>
        /// <returns>The created <see cref="JsonResult"/> for the response.</returns>
        public JsonResult InternalServer(object value, string message, Exception exception);
    }
}