using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPG
{
    internal class Program
    {
        GameLoop gl = new GameLoop();
        static void Main(string[] args)
        {
            GameLoop gl = new GameLoop();

            gl.Awake();
            gl.Start();
            while(true)
            {
                gl.Render();
                gl.Update();
            }


        }
    }
}
