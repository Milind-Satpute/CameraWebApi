using CameraWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CameraWebApi.Interface;

namespace CameraWebApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CameraOutputController : ControllerBase
    {
        public ICameraInfo _cameraInfo = null;
        public CameraOutputController(ICameraInfo cameraInfo)
        {
            if (cameraInfo == null)
            {
                throw new ArgumentNullException("cameraInfo");
            }
            _cameraInfo = cameraInfo;
        }

        [HttpGet]
        [Route("Get/{cameraCount:int}")]
        public async Task<CameraResponse> Get(int cameraCount)
        {
            //https://localhost:5001/CameraOutput/Get/2
            var response = await _cameraInfo.GetCameraInfo(cameraCount);
            return response;
        }

        [HttpGet]
        public async Task<CameraResponse> Get()
        {
        // https://localhost:5001/CameraOutput
            var response = await _cameraInfo.GetCameraInfo();
            return response;
        }




    }


    
}
