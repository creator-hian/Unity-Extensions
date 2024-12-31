using UnityEngine;

namespace Hian.Extensions
{
    /// <summary>
    /// LayerMask에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class LayerMaskExtensions
    {
        /// <summary>
        /// 레이어 마스크에 레이어를 추가합니다.
        /// </summary>
        /// <param name="layerMask">레이어를 추가할 레이어 마스크.</param>
        /// <param name="layers">추가할 레이어.</param>
        /// <returns>업데이트된 레이어 마스크.</returns>
        public static LayerMask WithLayers(this LayerMask layerMask, params int[] layers)
        {
            foreach (int layer in layers)
            {
                layerMask |= 1 << layer;
            }

            return layerMask;
        }

        /// <summary>
        /// 레이어 마스크에 레이어를 추가합니다.
        /// </summary>
        /// <param name="layerMask">레이어를 추가할 레이어 마스크.</param>
        /// <param name="layerNames">추가할 레이어의 이름.</param>
        /// <returns>업데이트된 레이어 마스크.</returns>
        public static LayerMask WithLayers(this LayerMask layerMask, params string[] layerNames)
        {
            foreach (string name in layerNames)
            {
                int layer = LayerMask.NameToLayer(name);
                layerMask |= 1 << layer;
            }

            return layerMask;
        }

        /// <summary>
        /// 레이어 마스크에서 레이어를 제거합니다.
        /// </summary>
        /// <param name="layerMask">레이어를 제거할 레이어 마스크.</param>
        /// <param name="layers">제거할 레이어.</param>
        /// <returns>업데이트된 레이어 마스크.</returns>
        public static LayerMask WithoutLayers(this LayerMask layerMask, params int[] layers)
        {
            foreach (int layer in layers)
            {
                layerMask &= ~(1 << layer);
            }

            return layerMask;
        }

        /// <summary>
        /// 레이어 마스크에서 레이어를 제거합니다.
        /// </summary>
        /// <param name="layerMask">레이어를 제거할 레이어 마스크.</param>
        /// <param name="layerNames">제거할 레이어의 이름.</param>
        /// <returns>업데이트된 레이어 마스크.</returns>
        public static LayerMask WithoutLayers(this LayerMask layerMask, params string[] layerNames)
        {
            foreach (string name in layerNames)
            {
                int layer = LayerMask.NameToLayer(name);
                layerMask &= ~(1 << layer);
            }

            return layerMask;
        }

        /// <summary>
        /// 레이어 마스크에 지정된 레이어 번호가 포함되어 있는지 확인합니다.
        /// </summary>
        /// <param name="mask">확인할 레이어 마스크.</param>
        /// <param name="layerNumber">확인할 레이어 번호.</param>
        /// <returns>레이어가 포함되어 있으면 true, 그렇지 않으면 false를 반환합니다.</returns>
        public static bool Contains(this LayerMask mask, int layerNumber)
        {
            return mask == (mask | (1 << layerNumber));
        }

        /// <summary>
        /// 레이어 마스크에 지정된 레이어 이름이 포함되어 있는지 확인합니다.
        /// </summary>
        /// <param name="mask">확인할 레이어 마스크.</param>
        /// <param name="layerName">확인할 레이어 이름.</param>
        /// <returns>레이어가 포함되어 있으면 true, 그렇지 않으면 false를 반환합니다.</returns>
        public static bool Contains(this LayerMask mask, string layerName)
        {
            int layer = LayerMask.NameToLayer(layerName);
            return Contains(mask, layer);
        }
    }
}
