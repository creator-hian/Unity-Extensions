using UnityEngine;
using UnityEngine.Rendering;

namespace Hian.Unity.Extensions
{
    /// <summary>
    /// Renderer 컴포넌트에 대한 확장 메서드들을 제공하는 클래스입니다.
    /// </summary>
    public static class RendererExtensions
    {
        /// <summary>
        /// Renderer의 머티리얼 중 '_Color' 프로퍼티를 가진 머티리얼들의 ZWrite를 활성화합니다.
        /// 이는 머티리얼이 Z 버퍼에 깊이값을 쓸 수 있게 하여, 이후 렌더링 처리에 영향을 줄 수 있습니다.
        /// 예를 들어, 투명 오브젝트들의 올바른 레이어링을 보장하는 데 사용될 수 있습니다.
        /// </summary>
        public static void EnableZWrite(this Renderer renderer)
        {
            foreach (Material material in renderer.materials)
            {
                if (material.HasProperty(ShaderPropertyExtensions.ColorPropertyID))
                {
                    material.SetInt(ShaderPropertyExtensions.ZWritePropertyID, 1);
                    material.renderQueue = (int)RenderQueue.Transparent;
                }
            }
        }

        /// <summary>
        /// Renderer의 머티리얼 중 '_Color' 프로퍼티를 가진 머티리얼들의 ZWrite를 비활성화합니다.
        /// 이는 머티리얼이 Z 버퍼에 깊이값을 쓰지 않게 하여, 이후 렌더링이 가려지는 것을 방지할 수 있습니다.
        /// 반투명 오브젝트나 레이어드 오브젝트를 렌더링할 때 유용할 수 있습니다.
        /// </summary>
        public static void DisableZWrite(this Renderer renderer)
        {
            foreach (Material material in renderer.materials)
            {
                if (material.HasProperty(ShaderPropertyExtensions.ColorPropertyID))
                {
                    material.SetInt(ShaderPropertyExtensions.ZWritePropertyID, 0);
                    material.renderQueue = (int)RenderQueue.Transparent + 100;
                }
            }
        }
    }
}
