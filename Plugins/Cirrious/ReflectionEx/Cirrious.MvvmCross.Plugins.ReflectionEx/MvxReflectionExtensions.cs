﻿// MvxReflectionExtensions.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.Reflection;

namespace Cirrious.MvvmCross.Plugins.ReflectionEx
{
    public static class MvxReflectionExtensions
    {
        public static AssemblyName[] GetReferencedAssembliesEx(this Assembly assembly)
        {
            return MvxReflectionSingleton.Instance.ReflectionEx.GetReflectedAssembliesEx(assembly);
        }
    }
}