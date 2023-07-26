using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BegginerCourse.Program;

namespace BegginerCourse
{
    internal class ImageFunctions
    {
        private int _height;
        private int _width;

        public ImageFunctions(int height , int width)
        {
            _height = height;
            _width = width;
        }

        /// <summary>
        /// Will return Image type based on the image height and width
        /// </summary>
        /// <returns></returns>
        public string ImageType()
        {
            if (_height > _width)
            {
                return "The image is: " + Image.Portrait;
            }
            else
            {
                return "The image is: " + Image.Landscape;
            }
        }
    }
}
