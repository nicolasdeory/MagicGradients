﻿namespace MagicGradients
{
    public enum RadialGradientSize
    {
        ClosestSide = 1,
        ClosestCorner = 2,
        FarthestSide = 3,
        FarthestCorner = 4
    }

    public static class RadialGradientSizeExtensions
    {
        public static bool IsClosest(this RadialGradientSize size) => (int)size < 3;

        public static bool IsFarthest(this RadialGradientSize size) => (int)size >= 3;

        public static bool IsCorner(this RadialGradientSize size) => (int)size % 2 == 0;

        public static bool IsSide(this RadialGradientSize size) => (int)size % 2 != 0;
    }
}
