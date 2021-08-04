using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Http;

namespace APIBase.Base.Interfaces
{
    public interface IFileResponse
    {
        /// <summary>
        /// Returns a file with the specified <paramref name="fileContents" /> as content (<see cref="StatusCodes.Status200OK"/>),
        /// and the specified <paramref name="contentType" /> as the Content-Type.
        /// This supports range requests (<see cref="StatusCodes.Status206PartialContent"/> or
        /// <see cref="StatusCodes.Status416RangeNotSatisfiable"/> if the range is not satisfiable).
        /// </summary>
        /// <param name="fileContents">The file contents.</param>
        /// <param name="contentType">The Content-Type of the file.</param>
        /// <returns>The created <see cref="FileContentResult"/> for the response.</returns>
        [NonAction]
        public FileContentResult FileResult(byte[] fileContents, string contentType);

        /// <summary>
        /// Returns a file with the specified <paramref name="fileContents" /> as content (<see cref="StatusCodes.Status200OK"/>),
        /// and the specified <paramref name="contentType" /> as the Content-Type.
        /// This supports range requests (<see cref="StatusCodes.Status206PartialContent"/> or
        /// <see cref="StatusCodes.Status416RangeNotSatisfiable"/> if the range is not satisfiable).
        /// </summary>
        /// <param name="fileContents">The file contents.</param>
        /// <param name="contentType">The Content-Type of the file.</param>
        /// <param name="enableRangeProcessing">Set to <c>true</c> to enable range requests processing.</param>
        /// <returns>The created <see cref="FileContentResult"/> for the response.</returns>
        [NonAction]
        public FileContentResult FileResult(byte[] fileContents, string contentType, bool enableRangeProcessing);

        /// <summary>
        /// Returns a file with the specified <paramref name="fileContents" /> as content (<see cref="StatusCodes.Status200OK"/>), the
        /// specified <paramref name="contentType" /> as the Content-Type and the specified <paramref name="fileDownloadName" /> as the suggested file name.
        /// This supports range requests (<see cref="StatusCodes.Status206PartialContent"/> or
        /// <see cref="StatusCodes.Status416RangeNotSatisfiable"/> if the range is not satisfiable).
        /// </summary>
        /// <param name="fileContents">The file contents.</param>
        /// <param name="contentType">The Content-Type of the file.</param>
        /// <param name="fileDownloadName">The suggested file name.</param>
        /// <returns>The created <see cref="FileContentResult"/> for the response.</returns>
        [NonAction]
        public FileContentResult FileResult(byte[] fileContents, string contentType, string fileDownloadName);

        /// <summary>
        /// Returns a file with the specified <paramref name="fileContents" /> as content (<see cref="StatusCodes.Status200OK"/>), the
        /// specified <paramref name="contentType" /> as the Content-Type and the specified <paramref name="fileDownloadName" /> as the suggested file name.
        /// This supports range requests (<see cref="StatusCodes.Status206PartialContent"/> or
        /// <see cref="StatusCodes.Status416RangeNotSatisfiable"/> if the range is not satisfiable).
        /// </summary>
        /// <param name="fileContents">The file contents.</param>
        /// <param name="contentType">The Content-Type of the file.</param>
        /// <param name="fileDownloadName">The suggested file name.</param>
        /// <param name="enableRangeProcessing">Set to <c>true</c> to enable range requests processing.</param>
        /// <returns>The created <see cref="FileContentResult"/> for the response.</returns>
        [NonAction]
        public FileContentResult FileResult(byte[] fileContents, string contentType, string fileDownloadName,
            bool enableRangeProcessing);

        /// <summary>
        /// Returns a file with the specified <paramref name="fileContents" /> as content (<see cref="StatusCodes.Status200OK"/>), 
        /// and the specified <paramref name="contentType" /> as the Content-Type.
        /// This supports range requests (<see cref="StatusCodes.Status206PartialContent"/> or
        /// <see cref="StatusCodes.Status416RangeNotSatisfiable"/> if the range is not satisfiable).
        /// </summary>
        /// <param name="fileContents">The file contents.</param>
        /// <param name="contentType">The Content-Type of the file.</param>
        /// <param name="lastModified">The <see cref="DateTimeOffset"/> of when the file was last modified.</param>
        /// <param name="entityTag">The <see cref="EntityTagHeaderValue"/> associated with the file.</param>
        /// <returns>The created <see cref="FileContentResult"/> for the response.</returns>
        [NonAction]
        public FileContentResult FileResult(byte[] fileContents, string contentType, DateTimeOffset? lastModified,
            EntityTagHeaderValue entityTag);

        /// <summary>
        /// Returns a file with the specified <paramref name="fileContents" /> as content (<see cref="StatusCodes.Status200OK"/>), 
        /// and the specified <paramref name="contentType" /> as the Content-Type.
        /// This supports range requests (<see cref="StatusCodes.Status206PartialContent"/> or
        /// <see cref="StatusCodes.Status416RangeNotSatisfiable"/> if the range is not satisfiable).
        /// </summary>
        /// <param name="fileContents">The file contents.</param>
        /// <param name="contentType">The Content-Type of the file.</param>
        /// <param name="lastModified">The <see cref="DateTimeOffset"/> of when the file was last modified.</param>
        /// <param name="entityTag">The <see cref="EntityTagHeaderValue"/> associated with the file.</param>
        /// <param name="enableRangeProcessing">Set to <c>true</c> to enable range requests processing.</param>
        /// <returns>The created <see cref="FileContentResult"/> for the response.</returns>
        [NonAction]
        public FileContentResult FileResult(byte[] fileContents, string contentType, DateTimeOffset? lastModified,
            EntityTagHeaderValue entityTag, bool enableRangeProcessing);

        /// <summary>
        /// Returns a file with the specified <paramref name="fileContents" /> as content (<see cref="StatusCodes.Status200OK"/>), the 
        /// specified <paramref name="contentType" /> as the Content-Type, and the specified <paramref name="fileDownloadName" /> as the suggested file name.
        /// This supports range requests (<see cref="StatusCodes.Status206PartialContent"/> or
        /// <see cref="StatusCodes.Status416RangeNotSatisfiable"/> if the range is not satisfiable).
        /// </summary>
        /// <param name="fileContents">The file contents.</param>
        /// <param name="contentType">The Content-Type of the file.</param>
        /// <param name="fileDownloadName">The suggested file name.</param>
        /// <param name="lastModified">The <see cref="DateTimeOffset"/> of when the file was last modified.</param>
        /// <param name="entityTag">The <see cref="EntityTagHeaderValue"/> associated with the file.</param>
        /// <returns>The created <see cref="FileContentResult"/> for the response.</returns>
        [NonAction]
        public FileContentResult FileResult(byte[] fileContents, string contentType, string fileDownloadName,
            DateTimeOffset? lastModified, EntityTagHeaderValue entityTag);

        /// <summary>
        /// Returns a file with the specified <paramref name="fileContents" /> as content (<see cref="StatusCodes.Status200OK"/>), the 
        /// specified <paramref name="contentType" /> as the Content-Type, and the specified <paramref name="fileDownloadName" /> as the suggested file name.
        /// This supports range requests (<see cref="StatusCodes.Status206PartialContent"/> or
        /// <see cref="StatusCodes.Status416RangeNotSatisfiable"/> if the range is not satisfiable).
        /// </summary>
        /// <param name="fileContents">The file contents.</param>
        /// <param name="contentType">The Content-Type of the file.</param>
        /// <param name="fileDownloadName">The suggested file name.</param>
        /// <param name="lastModified">The <see cref="DateTimeOffset"/> of when the file was last modified.</param>
        /// <param name="entityTag">The <see cref="EntityTagHeaderValue"/> associated with the file.</param>
        /// <param name="enableRangeProcessing">Set to <c>true</c> to enable range requests processing.</param>
        /// <returns>The created <see cref="FileContentResult"/> for the response.</returns>
        [NonAction]
        public FileContentResult FileResult(byte[] fileContents, string contentType, string fileDownloadName,
            DateTimeOffset? lastModified, EntityTagHeaderValue entityTag, bool enableRangeProcessing);
        
        //public FileContentResult FileResult(byte[] fileContents, bool download = false, string name = null);

        //public FileContentResult FileResult(byte[] fileContents, string mimeType, string description);
    }
}