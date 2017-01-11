﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayRenderer
{
    /// <summary>
    /// 光照
    /// </summary>
    public class Light
    {
        /// <summary>
        /// 方向
        /// </summary>
        public Vector3 direction;

        /// <summary>
        /// 颜色
        /// </summary>
        public Color color;

        public Light()
        {
        }

        public Light(Vector3 mDirection, Color mColor)
        {
            this.direction = mDirection;
            this.color = mColor;
        }

    }
}