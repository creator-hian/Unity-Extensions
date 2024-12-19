using UnityEngine;

namespace Hian.Extensions
{
    /// <summary>
    /// RectTransform에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class RectTransformExtensions
    {
        /// <summary>
        /// RectTransform의 크기 델타 x 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetSizeDeltaX(this RectTransform rectTransform, float x) =>
            rectTransform.sizeDelta = rectTransform.sizeDelta.WithX(x);

        /// <summary>
        /// RectTransform의 크기 델타 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetSizeDeltaY(this RectTransform rectTransform, float y) =>
            rectTransform.sizeDelta = rectTransform.sizeDelta.WithY(y);

        /// <summary>
        /// RectTransform의 앵커 최소 x 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetAnchorMinX(this RectTransform rectTransform, float x) =>
            rectTransform.anchorMin = rectTransform.anchorMin.WithX(x);

        /// <summary>
        /// RectTransform의 앵커 최소 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetAnchorMinY(this RectTransform rectTransform, float y) =>
            rectTransform.anchorMin = rectTransform.anchorMin.WithY(y);

        /// <summary>
        /// RectTransform의 앵커 최대 x 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetAnchorMaxX(this RectTransform rectTransform, float x) =>
            rectTransform.anchorMax = rectTransform.anchorMax.WithX(x);

        /// <summary>
        /// RectTransform의 앵커 최대 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetAnchorMaxY(this RectTransform rectTransform, float y) =>
            rectTransform.anchorMax = rectTransform.anchorMax.WithY(y);

        /// <summary>
        /// RectTransform의 오프셋 최소 x 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetOffsetMinX(this RectTransform rectTransform, float x) =>
            rectTransform.offsetMin = rectTransform.offsetMin.WithX(x);

        /// <summary>
        /// 왼쪽으로부터의 오프셋을 설정합니다. <b>SetOffsetMinX</b>와 동일합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">오프셋 값.</param>
        public static void SetLeft(this RectTransform rectTransform, float x) =>
            SetOffsetMinX(rectTransform, x);

        /// <summary>
        /// RectTransform의 오프셋 최소 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetOffsetMinY(this RectTransform rectTransform, float y) =>
            rectTransform.offsetMin = rectTransform.offsetMin.WithY(y);

        /// <summary>
        /// 아래쪽으로부터의 오프셋을 설정합니다. <b>SetOffsetMinY</b>와 동일합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">오프셋 값.</param>
        public static void SetBottom(this RectTransform rectTransform, float y) =>
            SetOffsetMinY(rectTransform, y);

        /// <summary>
        /// RectTransform의 오프셋 최대 x 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetOffsetMaxX(this RectTransform rectTransform, float x) =>
            rectTransform.offsetMax = rectTransform.offsetMax.WithX(x);

        /// <summary>
        /// 오른쪽으로부터의 오프셋을 설정합니다. <b>SetOffsetMaxX</b>와 동일합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">오프셋 값.</param>
        public static void SetRight(this RectTransform rectTransform, float x) =>
            SetOffsetMaxX(rectTransform, x);

        /// <summary>
        /// RectTransform의 오프셋 최대 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetOffsetMaxY(this RectTransform rectTransform, float y) =>
            rectTransform.offsetMax = rectTransform.offsetMax.WithY(y);

        /// <summary>
        /// 위쪽으로부터의 오프셋을 설정합니다. <b>SetOffsetMaxY</b>와 동일합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">오프셋 값.</param>
        public static void SetTop(this RectTransform rectTransform, float y) =>
            SetOffsetMaxY(rectTransform, y);

        /// <summary>
        /// RectTransform의 앵커 위치 x 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetAnchoredPositionX(this RectTransform rectTransform, float x) =>
            rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithX(x);

        /// <summary>
        /// RectTransform의 앵커 위치 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetAnchoredPositionY(this RectTransform rectTransform, float y) =>
            rectTransform.anchoredPosition = rectTransform.anchoredPosition.WithY(y);

        /// <summary>
        /// RectTransform의 앵커 위치 3D x 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetAnchoredPosition3DX(this RectTransform rectTransform, float x) =>
            rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithX(x);

        /// <summary>
        /// RectTransform의 앵커 위치 3D y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetAnchoredPosition3DY(this RectTransform rectTransform, float y) =>
            rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithY(y);

        /// <summary>
        /// RectTransform의 앵커 위치 3D z 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetAnchoredPosition3DZ(this RectTransform rectTransform, float z) =>
            rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithZ(z);

        /// <summary>
        /// RectTransform의 앵커 위치 3D x 및 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetAnchoredPosition3DXY(
            this RectTransform rectTransform,
            float x,
            float y
        ) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXY(x, y);

        /// <summary>
        /// RectTransform의 앵커 위치 3D x 및 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="position">설정할 위치.</param>
        public static void SetAnchoredPosition3DXY(
            this RectTransform rectTransform,
            Vector2 position
        ) =>
            rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXY(
                position.x,
                position.y
            );

        /// <summary>
        /// RectTransform의 앵커 위치 3D x 및 z 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetAnchoredPosition3DXZ(
            this RectTransform rectTransform,
            float x,
            float z
        ) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXZ(x, z);

        /// <summary>
        /// RectTransform의 앵커 위치 3D x 및 z 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="position">설정할 위치.</param>
        public static void SetAnchoredPosition3DXZ(
            this RectTransform rectTransform,
            Vector2 position
        ) =>
            rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithXZ(
                position.x,
                position.y
            );

        /// <summary>
        /// RectTransform의 앵커 위치 3D y 및 z 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetAnchoredPosition3DYZ(
            this RectTransform rectTransform,
            float y,
            float z
        ) => rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithYZ(y, z);

        /// <summary>
        /// RectTransform의 앵커 위치 3D y 및 z 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="position">설정할 위치.</param>
        public static void SetAnchoredPosition3DYZ(
            this RectTransform rectTransform,
            Vector2 position
        ) =>
            rectTransform.anchoredPosition3D = rectTransform.anchoredPosition3D.WithYZ(
                position.x,
                position.y
            );

        /// <summary>
        /// RectTransform의 피벗 x 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetPivotX(this RectTransform rectTransform, float x) =>
            rectTransform.pivot = rectTransform.pivot.WithX(x);

        /// <summary>
        /// RectTransform의 피벗 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetPivotY(this RectTransform rectTransform, float y) =>
            rectTransform.pivot = rectTransform.pivot.WithY(y);

        /// <summary>
        /// 최소 및 최대 지점을 변경하지 않고 RectTransform의 피벗 x 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetPivotOnlyX(this RectTransform rectTransform, float x)
        {
            var deltaPercent = rectTransform.pivot.x - x;
            rectTransform.SetPivotX(x);
            rectTransform.SetAnchoredPositionX(
                rectTransform.anchoredPosition.x - rectTransform.sizeDelta.x * deltaPercent
            );
        }

        /// <summary>
        /// 최소 및 최대 지점을 변경하지 않고 RectTransform의 피벗 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetPivotOnlyY(this RectTransform rectTransform, float y)
        {
            var deltaPercent = rectTransform.pivot.y - y;
            rectTransform.SetPivotY(y);
            rectTransform.SetAnchoredPositionY(
                rectTransform.anchoredPosition.y - rectTransform.sizeDelta.y * deltaPercent
            );
        }

        /// <summary>
        /// 최소 및 최대 지점을 변경하지 않고 RectTransform의 피벗 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="pivot">설정할 값.</param>
        public static void SetPivotOnly(this RectTransform rectTransform, Vector2 pivot) =>
            SetPivotOnly(rectTransform, pivot.x, pivot.y);

        /// <summary>
        /// 최소 및 최대 지점을 변경하지 않고 RectTransform의 피벗 x 및 y 값을 설정합니다.
        /// </summary>
        /// <param name="rectTransform">대상 RectTransform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetPivotOnly(this RectTransform rectTransform, float x, float y)
        {
            SetPivotOnlyX(rectTransform, x);
            SetPivotOnlyY(rectTransform, y);
        }
    }
}
