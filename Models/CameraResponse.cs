using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameraWebApi.Models
{
    public class CameraResponse
    {
        public List<CameraInfo> CameraInfos { get; set; }
        public int CameraCount { get; set; }


    }
}
