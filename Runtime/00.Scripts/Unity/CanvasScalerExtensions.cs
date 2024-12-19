using UnityEngine;
using UnityEngine.UI;

namespace Hian.Extensions
{
    /// <summary>
    /// Unity CanvasScaler 클래스에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class CanvasScalerExtensions
    {
        /// <summary>
        /// <see cref="CanvasScaler.ScaleMode.ScaleWithScreenSize"/> 모드에서 캔버스 스케일러가 계산한 스케일 팩터를 가져옵니다.
        /// </summary>
        /// <param name="scaler">대상 캔버스 스케일러.</param>
        /// <returns>계산된 스케일 팩터.</returns>
        public static float GetScaleFactor(this CanvasScaler scaler)
        {
            return Mathf.Lerp(
                Screen.width / scaler.referenceResolution.x,
                Screen.height / scaler.referenceResolution.y,
                scaler.matchWidthOrHeight
            );
        }
    }
}
