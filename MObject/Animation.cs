﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manim.MObject
{
    /// <summary>
    /// The base interface for every visual animation
    /// </summary>
    public interface IAnimation
    {
        /// <summary>
        /// The length of the animation in seconds
        /// </summary>
        public float Length { get; set; }
        /// <summary>
        /// The time in seconds when the animation starts
        /// </summary>
        public float StartTime { get; set; }

        /// <summary>
        /// The animation timing function
        /// </summary>
        public AnimationCurve Curve { get; set; }
        /// <summary>
        /// The objects affected by this animation
        /// </summary>
        public MObject[] Objects { get; set; }
    }

    /// <summary>
    /// An animation to fade in or out an object
    /// </summary>
    public class FadeAnimation : IAnimation
    {
        /// <summary>
        /// The length of the animation in seconds
        /// </summary>
        public float Length { get; set; }
        /// <summary>
        /// The time in seconds when the animation starts
        /// </summary>
        public float StartTime { get; set; }

        /// <summary>
        /// The animation timing function
        /// </summary>
        public AnimationCurve Curve { get; set; }
        /// <summary>
        /// The objects affected by this animation
        /// </summary>
        public MObject[] Objects { get; set; }

        public FadeAnimation(MObject[] objects, float length = 1, float startTime = 0, AnimationCurve? curve = null)
        {
            Length = length;
            if (Length < 0) throw new ArgumentException("Animation end must be after its start");
            StartTime = startTime;
            Curve = curve ?? new AnimationCurve();
            Objects = objects;
            if (Objects.Length == 0) throw new ArgumentException("Animation must affect at least one object");
        }
    }
}
