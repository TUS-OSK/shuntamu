﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shuntamu.View
{
    class Map:List<Square>,IDrawable
    {
        public void Draw()
        {
            foreach (var Itr in this)
            {
                Itr.Draw();
            }
        }
    }
}
