using System;
using System.DoubleNumerics;
using System.Reactive.Linq;
using LanguageExt;

namespace SolidworksAddinFramework.OpenGl
{
    public class EmptyRenderer : IRenderer
    {
        public IObservable<Unit> NeedsRedraw => Observable.Never(Unit.Default);

        public void Render(DateTime time, double parentOpacity = 1.0, Matrix4x4? renderTransform = null)
        {
        }

        public void ApplyTransform(Matrix4x4 transform, bool accumulate = false)
        {
        }

        public Tuple<Vector3, double> BoundingSphere => Prelude.Tuple(Vector3.Zero, 0d);
        public double Opacity { get; set; }
        public bool Visibility { get; set; }
    }
}