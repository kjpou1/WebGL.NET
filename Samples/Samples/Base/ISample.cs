using WaveEngine.Common.Graphics;
using WaveEngine.Common.Math;
using WebAssembly;

namespace Samples
{
    public interface ISample
    {
        string Description { get; }

        double OldMilliseconds { get; set; }

        void Run(JSObject canvas, float canvasWidth, float canvasHeight, Vector4 clearColor);

        void Update(double elapsedTime);

        void Draw();
    }
}