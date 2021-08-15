using CameraWebApi.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameraWebApi.Models
{
    public class CameraService : ICameraInfo
    {
       
        public Task<CameraResponse> GetCameraInfo(int cameraCount)
        {
            var cameraInfos = GetCameraData().Take(cameraCount).ToList();

            if (cameraInfos != null)
            {
                return Task.FromResult(new CameraResponse()
                {
                    CameraInfos = cameraInfos,
                    CameraCount = cameraInfos.Count
                });
            }
            return Task.FromResult(new CameraResponse());
        }

        public Task<CameraResponse> GetCameraInfo()
        {
            var cameraInfos = GetCameraData().ToList();

            if (cameraInfos != null)
            {
                return Task.FromResult(new CameraResponse()
                {
                    CameraInfos = cameraInfos,
                    CameraCount = cameraInfos.Count
                });
            }
            return Task.FromResult(new CameraResponse());
        }

        public Task<CameraResponse> AddCamera(CameraDetail cameraDetail)
        {
            throw new System.NotImplementedException();
        }

        private List<CameraInfo> GetCameraData()
        {
            return new List<CameraInfo>()
            {
                new CameraInfo()
                {
                    ImageUrl= "/abc.com/url1234",
                    IsSuccessful=true
                },
                new CameraInfo()
                {
                    ImageUrl= "/abc.com/url123444",
                    IsSuccessful=false
                },
                new CameraInfo()
                {
                    ImageUrl= "/abc.com/url123455",
                    IsSuccessful=true
                },
                new CameraInfo()
                {
                    ImageUrl= "/abc.com/url1234666",
                    IsSuccessful=true
                }
            };
        }
    }
}
