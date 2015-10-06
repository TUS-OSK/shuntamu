﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuntamu.View
{
    /// <summary>
    /// 静止する Map要素
    /// </summary>
    class MotionlessObject : MapElementBase
    {
        public MotionlessObject(Point top, Size size)
            : base(top, size)
        {
        }
    }
}
