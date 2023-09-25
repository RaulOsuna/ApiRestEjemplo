using APIRest.DAL;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace APIRest.Controllers
{
    [ApiController]
    [Route("[controller]/v1")]
    public class ApiController : Controller
    {
        [HttpPost]
        [Route("PostPromocion")]
        public ResponseData PostPromocion([FromBody] Promociones Api)
        {

            //your code here
            ApiDAL ApiDAL = new ApiDAL();
            ResponseData response = new ResponseData();
            try
            {
                
                response = ApiDAL.PostPromocionDAL(Api);
            }
            catch (Exception e)
            {

                response.ResponseCode = 500;
                response.Message = e.Message;
            }
            

            return response;
        }
        [HttpPut]
        [Route("putPromocion")]
        public ResponseData PutPromocion([FromBody] Promociones Api)
        {

            //your code here
            ApiDAL ApiDAL = new ApiDAL();
            ResponseData response = new ResponseData();
            try
            {

                response = ApiDAL.PutPromocionDAL(Api);
            }
            catch (Exception e)
            {

                response.ResponseCode = 500;
                response.Message = e.Message;
            }


            return response;
        }
        [HttpGet]
        [Route("getPromocion")]
        public Promociones GetPromocion([FromBody] IdPromocion Api)
        {

            //your code here
            ApiDAL ApiDAL = new ApiDAL();
            Promociones response = new Promociones();
            try
            {

                response = ApiDAL.GetPromocionDAL(Api.Id);
            }
            catch (Exception e)
            {

                response.ResponseCode = 500;
                response.Message = e.Message;
            }


            return response;
        }
        [HttpDelete]
        [Route("deletePromocion")]
        public ResponseData DeletePromocion([FromBody] IdPromocion Api)
        {

            //your code here
            ApiDAL ApiDAL = new ApiDAL();
            ResponseData response = new ResponseData();
            try
            {

                response = ApiDAL.DeletePromocionDAL(Api.Id);
            }
            catch (Exception e)
            {

                response.ResponseCode = 500;
                response.Message = e.Message;
            }


            return response;
        }
    }
}
