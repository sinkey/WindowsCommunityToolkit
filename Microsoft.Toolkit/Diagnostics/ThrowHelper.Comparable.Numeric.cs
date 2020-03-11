﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Toolkit.Extensions;

#nullable enable

namespace Microsoft.Toolkit.Diagnostics
{
    /// <summary>
    /// Helper methods to throw exceptions
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1618", Justification = "Internal helper methods")]
    internal static partial class ThrowHelper
    {
        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsCloseTo(int,int,int,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsCloseTo(int value, int target, int delta, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(int).ToTypeString()}) must be within a distance of {delta.ToAssertString()} from {target.ToAssertString()}, was {value.ToAssertString()} and had a distance of {Math.Abs((double)((long)value - target)).ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsNotCloseTo(int,int,int,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsNotCloseTo(int value, int target, int delta, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(int).ToTypeString()}) must not be within a distance of {delta.ToAssertString()} from {target.ToAssertString()}, was {value.ToAssertString()} and had a distance of {Math.Abs((double)((long)value - target)).ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsCloseTo(float,float,float,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsCloseTo(float value, float target, float delta, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(float).ToTypeString()}) must be within a distance of {delta.ToAssertString()} from {target.ToAssertString()}, was {value.ToAssertString()} and had a distance of {Math.Abs(value - target).ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsNotCloseTo(float,float,float,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsNotCloseTo(float value, float target, float delta, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(float).ToTypeString()}) must not be within a distance of {delta.ToAssertString()} from {target.ToAssertString()}, was {value.ToAssertString()} and had a distance of {Math.Abs(value - target).ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsCloseTo(double,double,double,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsCloseTo(double value, double target, double delta, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(double).ToTypeString()}) must be within a distance of {delta.ToAssertString()} from {target.ToAssertString()}, was {value.ToAssertString()} and had a distance of {Math.Abs(value - target).ToAssertString()}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentException"/> when <see cref="Guard.IsNotCloseTo(double,double,double,string)"/> fails.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentExceptionForIsNotCloseTo(double value, double target, double delta, string name)
        {
            ThrowArgumentException(name, $"Parameter {name.ToAssertString()} ({typeof(double).ToTypeString()}) must not be within a distance of {delta.ToAssertString()} from {target.ToAssertString()}, was {value.ToAssertString()} and had a distance of {Math.Abs(value - target).ToAssertString()}");
        }
    }
}
