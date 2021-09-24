using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PolicyAdmin.QuotesMS.API.Interface;
using PolicyAdmin.QuotesMS.API.Models;
using PolicyAdmin.QuotesMS.API.Models.Enum;
using PolicyAdmin.QuotesMS.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PolicyAdmin.QuotesMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    public class QuotesController : Controller
    {
        private readonly IQuoteRepository _repository;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger("RollingFile");

        private readonly IHttpClientFactory _clientFactory;
        
        public QuotesController(IQuoteRepository repository, IHttpClientFactory clientFactory)
        {
            _repository = repository;
            _clientFactory = clientFactory;
        }
        private async Task<HttpResponseMessage> CheckTokenValidity(string scheme, string token)
        {
            // var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:5001/api/Auth/Verify");
            // request.Headers.Add("Accept", "application/json");
            // request.Headers.Add("Authorization", token);
            var client = _clientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44365/api/Auth/Verify");

            HttpResponseMessage response = await client.SendAsync(request);


            return response;

        }

        [HttpGet]
        [Route("getQuotesForPolicy/{PropertyValue}/{BusinessValue}/{PropertyType}")]
        public async Task<IActionResult> getQuotesForPolicy(int propertyValue, int businessValue, string propertyType, [FromHeader] string authorization)
        {
            _log4net.Info("GetQuotesForPolicy action method started with PropertyValue=" + propertyValue + " BusinessValue=" + businessValue + " PropertyType=" + propertyType);
            if (AuthenticationHeaderValue.TryParse(authorization, out var headerValue))
            {
                var result = await CheckTokenValidity(headerValue.Scheme, headerValue.Parameter);
                if (result != null && result.StatusCode != HttpStatusCode.OK)
                {
                    return Unauthorized("Authorization Failed! Might be due to invalid token!");
                }
            }
            _log4net.Info("Received Request for Quote");

            PropertyType pt = (PropertyType)Enum.Parse(typeof(PropertyType), propertyType);
            //if (propertyType.Equals(PropertyType.Building))
            var quotes = await _repository.GetQuotes(pt,  propertyValue,  businessValue);

            if (quotes == null)
                return new BadRequestResult();
            else
                return new OkObjectResult(quotes);


        }
        //[HttpGet]
        //public async Task<IEnumerable<QuoteMaster>> getAllQuotes()
        //{
        //    IEnumerable<QuoteMaster> quotes = await _repository.GetAllQuotes();
        //    return quotes;
        //}
    }
}
