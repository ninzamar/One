using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace C_nine
{
    static class DrawThis
    {
        public static void Draw(IDraw objectToDraw) => objectToDraw.Draw();
    }
}
