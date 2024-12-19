using UnityEngine;

namespace Hian.Extensions
{
    /// <summary>
    /// Rect 구조체에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class RectExtensions
    {
        /// <summary>
        /// Rect의 중심을 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="center">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithCenter(this Rect rect, Vector2 center)
        {
            rect.center = center;
            return rect;
        }

        /// <summary>
        /// Rect의 위치를 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="position">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithPosition(this Rect rect, Vector2 position)
        {
            rect.position = position;
            return rect;
        }

        /// <summary>
        /// Rect의 높이를 설정합���다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="height">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithHeight(this Rect rect, float height)
        {
            rect.height = height;
            return rect;
        }

        /// <summary>
        /// Rect의 너비를 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="width">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithWidth(this Rect rect, float width)
        {
            rect.width = width;
            return rect;
        }

        /// <summary>
        /// Rect의 최대 지점을 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="max">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithMax(this Rect rect, Vector2 max)
        {
            rect.max = max;
            return rect;
        }

        /// <summary>
        /// Rect의 최소 지점을 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="min">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithMin(this Rect rect, Vector2 min)
        {
            rect.min = min;
            return rect;
        }

        /// <summary>
        /// Rect의 크기를 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="size">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithSize(this Rect rect, Vector2 size)
        {
            rect.size = size;
            return rect;
        }

        /// <summary>
        /// Rect의 x 좌표를 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="x">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithX(this Rect rect, float x)
        {
            rect.x = x;
            return rect;
        }

        /// <summary>
        /// Rect의 y 좌표를 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="y">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithY(this Rect rect, float y)
        {
            rect.y = y;
            return rect;
        }

        /// <summary>
        /// Rect의 x 최대 좌표를 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="xMax">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithXMax(this Rect rect, float xMax)
        {
            rect.xMax = xMax;
            return rect;
        }

        /// <summary>
        /// Rect의 x 최소 좌표를 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="xMin">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithXMin(this Rect rect, float xMin)
        {
            rect.xMin = xMin;
            return rect;
        }

        /// <summary>
        /// Rect의 y 최대 좌표를 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="yMax">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithYMax(this Rect rect, float yMax)
        {
            rect.yMax = yMax;
            return rect;
        }

        /// <summary>
        /// Rect의 y 최소 좌표를 설정합니다.
        /// </summary>
        /// <param name="rect">대상 Rect.</param>
        /// <param name="yMin">설정할 값.</param>
        /// <returns>변경된 <paramref name="rect"/>의 복사본.</returns>
        public static Rect WithYMin(this Rect rect, float yMin)
        {
            rect.yMin = yMin;
            return rect;
        }
    }
}
