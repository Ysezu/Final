using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kura
{
    class Sp
    {
        public Bitmap CurrenSp;
        public bool Show;
        public int _x, _y, _width, _heith;
        public Sp(string filename, int x, int y)
        {
            CurrenSp = new Bitmap(filename);
            _x = x;
            _y = y;
            _width = CurrenSp.Width;
            _heith = CurrenSp.Height;
            Show = true;
        }
        public Sp(string filename, int x, int y, int w, int h)
        {
            CurrenSp = new Bitmap(filename);
            _x = x;
            _y = y;
            _width = w;
            _heith = h;
            Show = true;
        }
        public bool Spcollis(Sp s)
        {
            Sp temp = this;
            Rectangle A = new Rectangle(s._x, s._y, s._width, s._heith);
            Rectangle B = new Rectangle(temp._x, temp._y, temp._width, temp._heith);

            if (A.IntersectsWith(B))
                return true;
            else return false;
        }
    }
}
