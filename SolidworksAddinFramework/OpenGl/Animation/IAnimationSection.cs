using System;
using System.DoubleNumerics;

namespace SolidworksAddinFramework.OpenGl.Animation
{
    public interface IAnimationSection
    {
        TimeSpan Duration { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deltaTime">time from the begining of the start of this section</param>
        /// <returns></returns>
        Matrix4x4 Transform(TimeSpan deltaTime);
    }
}