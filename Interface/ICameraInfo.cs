using CameraWebApi.Models;
using System.Threading.Tasks;

namespace CameraWebApi.Interface
{
    public interface ICameraInfo
    {
        public Task<CameraResponse> GetCameraInfo();
        public Task<CameraResponse> GetCameraInfo(int cameraCount);
        public Task<CameraResponse> AddCamera(CameraDetail cameraDetail);



    }
}
