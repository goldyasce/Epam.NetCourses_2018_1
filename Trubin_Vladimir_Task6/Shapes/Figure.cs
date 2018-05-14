using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures.Interfaces;

namespace Shapes
{
        public abstract class Figure
        {
            public abstract void Draw(ICanvas canvas);
        }
}
