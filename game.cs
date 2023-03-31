using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace ProGrafica
{
    class game:GameWindow
    {
        public game(int widht, int height, string title):base(widht, height, GraphicsMode.Default, title)
        {
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            //Code goes here
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Begin(PrimitiveType.Triangles);

                GL.Color3(1.0f, 0.0f, 0.0f);
                GL.Vertex2(-0.5f, -0.5f);
                GL.Color3(0.0f, 1.0f, 0.0f);
                GL.Vertex2(0.5f, -0.5f);
                GL.Color3(0.0f, 0.0f, 1.0f);
                GL.Vertex2(0.0f, 0.5f);            

            GL.End();

            Context.SwapBuffers();
        }
    }
}
