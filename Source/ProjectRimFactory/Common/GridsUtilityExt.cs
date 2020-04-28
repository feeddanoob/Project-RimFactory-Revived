﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace ProjectRimFactory.Common
{
    public static class GridsUtilityExt
    {
        public static T GetFirst<T>(this IntVec3 c, Map map) where T : Thing
        {
            foreach (var th in map.thingGrid.ThingsListAt(c))
            {
                if (th is T t)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
