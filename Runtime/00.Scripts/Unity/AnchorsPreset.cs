using UnityEngine;

namespace Hian.Extensions
{
    /// <summary>
    /// RectTransform의 앵커 프리셋을 정의합니다.
    /// </summary>
    public enum AnchorsPreset
    {
        /// <summary>
        /// 좌상단 고정 (anchorMin = (0,1), anchorMax = (0,1))
        /// 부모의 좌상단 모서리를 기준으로 UI 요소가 고정됩니다.
        /// </summary>
        TopLeft,

        /// <summary>
        /// 상단 중앙 고정 (anchorMin = (0.5,1), anchorMax = (0.5,1))
        /// 부모의 상단 중앙을 기준으로 UI 요소가 고정됩니다.
        /// </summary>
        TopCenter,

        /// <summary>
        /// 우상단 고정 (anchorMin = (1,1), anchorMax = (1,1))
        /// 부모의 우상단 모서리를 기준으로 UI 요소가 고정됩니다.
        /// </summary>
        TopRight,

        /// <summary>
        /// 좌측 중앙 고정 (anchorMin = (0,0.5), anchorMax = (0,0.5))
        /// 부모의 좌측 중앙을 기준으로 UI 요소가 고정됩니다.
        /// </summary>
        MiddleLeft,

        /// <summary>
        /// 정중앙 고정 (anchorMin = (0.5,0.5), anchorMax = (0.5,0.5))
        /// 부모의 정중앙을 기준으로 UI 요소가 고정됩니다.
        /// </summary>
        MiddleCenter,

        /// <summary>
        /// 우측 중앙 고정 (anchorMin = (1,0.5), anchorMax = (1,0.5))
        /// 부모의 우측 중앙을 기준으로 UI 요소가 고정됩니다.
        /// </summary>
        MiddleRight,

        /// <summary>
        /// 좌하단 고정 (anchorMin = (0,0), anchorMax = (0,0))
        /// 부모의 좌하단 모서리를 기준으로 UI 요소가 고정됩니다.
        /// </summary>
        BottomLeft,

        /// <summary>
        /// 하단 중앙 고정 (anchorMin = (0.5,0), anchorMax = (0.5,0))
        /// 부모의 하단 중앙을 기준으로 UI 요소가 고정됩니다.
        /// </summary>
        BottomCenter,

        /// <summary>
        /// 우하단 고정 (anchorMin = (1,0), anchorMax = (1,0))
        /// 부모의 우하단 모서리를 기준으로 UI 요소가 고정됩니다.
        /// </summary>
        BottomRight,

        /// <summary>
        /// 좌측 수직 스트레치 (anchorMin = (0,0), anchorMax = (0,1))
        /// 부모의 좌측을 기준으로 UI 요소가 수직으로 늘어납니다.
        /// </summary>
        VertStretchLeft,

        /// <summary>
        /// 중앙 수직 스트레치 (anchorMin = (0.5,0), anchorMax = (0.5,1))
        /// 부모의 중앙을 기준으로 UI 요소가 수직으로 늘어납니다.
        /// </summary>
        VertStretchCenter,

        /// <summary>
        /// 우측 수직 스트레치 (anchorMin = (1,0), anchorMax = (1,1))
        /// 부모의 우측을 기준으로 UI 요소가 수직으로 늘어납니다.
        /// </summary>
        VertStretchRight,

        /// <summary>
        /// 상단 수평 스트레치 (anchorMin = (0,1), anchorMax = (1,1))
        /// 부모의 상단을 기준으로 UI 요소가 수평으로 늘어납니다.
        /// </summary>
        HorStretchTop,

        /// <summary>
        /// 중앙 수평 스트레치 (anchorMin = (0,0.5), anchorMax = (1,0.5))
        /// 부모의 중앙을 기준으로 UI 요소가 수평으로 늘어납니다.
        /// </summary>
        HorStretchMiddle,

        /// <summary>
        /// 하단 수평 스트레치 (anchorMin = (0,0), anchorMax = (1,0))
        /// 부모의 하단을 기준으로 UI 요소가 수평으로 늘어납니다.
        /// </summary>
        HorStretchBottom,

        /// <summary>
        /// 전체 스트레치 (anchorMin = (0,0), anchorMax = (1,1))
        /// UI 요소가 부모의 전체 영역에 맞춰 늘어납니다.
        /// </summary>
        StretchAll,
    }

    /// <summary>
    /// AnchorsPreset에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class AnchorsPresetExtensions
    {
        /// <summary>
        /// 프리셋에 해당하는 최소 앵커 값을 반환합니다.
        /// </summary>
        public static Vector2 GetAnchorMin(this AnchorsPreset preset)
        {
            return preset switch
            {
                AnchorsPreset.TopLeft => new Vector2(0, 1),
                AnchorsPreset.TopCenter => new Vector2(0.5f, 1),
                AnchorsPreset.TopRight => new Vector2(1, 1),
                AnchorsPreset.MiddleLeft => new Vector2(0, 0.5f),
                AnchorsPreset.MiddleCenter => new Vector2(0.5f, 0.5f),
                AnchorsPreset.MiddleRight => new Vector2(1, 0.5f),
                AnchorsPreset.BottomLeft => new Vector2(0, 0),
                AnchorsPreset.BottomCenter => new Vector2(0.5f, 0),
                AnchorsPreset.BottomRight => new Vector2(1, 0),
                AnchorsPreset.VertStretchLeft => new Vector2(0, 0),
                AnchorsPreset.VertStretchCenter => new Vector2(0.5f, 0),
                AnchorsPreset.VertStretchRight => new Vector2(1, 0),
                AnchorsPreset.HorStretchTop => new Vector2(0, 1),
                AnchorsPreset.HorStretchMiddle => new Vector2(0, 0.5f),
                AnchorsPreset.HorStretchBottom => new Vector2(0, 0),
                AnchorsPreset.StretchAll => new Vector2(0, 0),
                _ => Vector2.zero,
            };
        }

        /// <summary>
        /// 프리셋에 해당하는 최대 앵커 값을 반환합니다.
        /// </summary>
        public static Vector2 GetAnchorMax(this AnchorsPreset preset)
        {
            return preset switch
            {
                AnchorsPreset.TopLeft => new Vector2(0, 1),
                AnchorsPreset.TopCenter => new Vector2(0.5f, 1),
                AnchorsPreset.TopRight => new Vector2(1, 1),
                AnchorsPreset.MiddleLeft => new Vector2(0, 0.5f),
                AnchorsPreset.MiddleCenter => new Vector2(0.5f, 0.5f),
                AnchorsPreset.MiddleRight => new Vector2(1, 0.5f),
                AnchorsPreset.BottomLeft => new Vector2(0, 0),
                AnchorsPreset.BottomCenter => new Vector2(0.5f, 0),
                AnchorsPreset.BottomRight => new Vector2(1, 0),
                AnchorsPreset.VertStretchLeft => new Vector2(0, 1),
                AnchorsPreset.VertStretchCenter => new Vector2(0.5f, 1),
                AnchorsPreset.VertStretchRight => new Vector2(1, 1),
                AnchorsPreset.HorStretchTop => new Vector2(1, 1),
                AnchorsPreset.HorStretchMiddle => new Vector2(1, 0.5f),
                AnchorsPreset.HorStretchBottom => new Vector2(1, 0),
                AnchorsPreset.StretchAll => new Vector2(1, 1),
                _ => Vector2.zero,
            };
        }

        /// <summary>
        /// 프리셋에 해당하는 기본 피벗 값을 반환합니다.
        /// </summary>
        public static Vector2 GetDefaultPivot(this AnchorsPreset preset)
        {
            return preset switch
            {
                AnchorsPreset.TopLeft => new Vector2(0, 1),
                AnchorsPreset.TopCenter => new Vector2(0.5f, 1),
                AnchorsPreset.TopRight => new Vector2(1, 1),
                AnchorsPreset.MiddleLeft => new Vector2(0, 0.5f),
                AnchorsPreset.MiddleCenter => new Vector2(0.5f, 0.5f),
                AnchorsPreset.MiddleRight => new Vector2(1, 0.5f),
                AnchorsPreset.BottomLeft => new Vector2(0, 0),
                AnchorsPreset.BottomCenter => new Vector2(0.5f, 0),
                AnchorsPreset.BottomRight => new Vector2(1, 0),
                AnchorsPreset.VertStretchLeft => new Vector2(0, 0.5f),
                AnchorsPreset.VertStretchCenter => new Vector2(0.5f, 0.5f),
                AnchorsPreset.VertStretchRight => new Vector2(1, 0.5f),
                AnchorsPreset.HorStretchTop => new Vector2(0.5f, 1),
                AnchorsPreset.HorStretchMiddle => new Vector2(0.5f, 0.5f),
                AnchorsPreset.HorStretchBottom => new Vector2(0.5f, 0),
                AnchorsPreset.StretchAll => new Vector2(0.5f, 0.5f),
                _ => Vector2.zero,
            };
        }
    }
}
