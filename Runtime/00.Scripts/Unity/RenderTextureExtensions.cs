using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hian.Extensions
{
    /// <summary>
    /// RenderTexture에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class RenderTextureExtensions
    {
        /// <summary>
        /// 텍스처를 생성하고 <paramref name="renderTexture"/>의 내용을 씁니다.
        /// </summary>
        /// <param name="renderTexture">렌더 텍스처.</param>
        /// <returns>생성된 텍스처.</returns>
        public static Texture2D ToTexture2D(this RenderTexture renderTexture, TextureFormat format)
        {
            var texture = new Texture2D(renderTexture.width, renderTexture.height, format, false);
            renderTexture.WriteToTexture2D(texture);

            return texture;
        }

        /// <summary>
        /// <paramref name="renderTexture"/>의 내용을 <paramref name="texture"/>에 씁니다.
        /// </summary>
        /// <param name="renderTexture">렌더 텍스처.</param>
        /// <param name="texture">렌더 텍스처의 내용을 쓸 텍스처.</param>
        public static void WriteToTexture2D(this RenderTexture renderTexture, Texture2D texture)
        {
            var oldRenderTexture = RenderTexture.active;
            RenderTexture.active = renderTexture;

            texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
            texture.Apply();

            RenderTexture.active = oldRenderTexture;
        }

        /// <summary>
        /// 스프라이트를 생성하고 <paramref name="renderTexture"/>의 내용을 씁니다.
        /// </summary>
        /// <param name="renderTexture">렌더 텍스처.</param>
        /// <returns>생성된 스프라이트.</returns>
        public static Sprite ToSprite(this RenderTexture renderTexture, TextureFormat format)
        {
            var texture = renderTexture.ToTexture2D(format);
            return Sprite.Create(
                texture,
                new Rect(0f, 0f, texture.width, texture.height),
                new Vector2(0.5f, 0.5f)
            );
        }

        /// <summary>
        /// <paramref name="renderTexture"/>의 내용을 <paramref name="sprite"/>에 씁니다.
        /// </summary>
        /// <param name="renderTexture">렌더 텍스처.</param>
        /// <param name="sprite">렌더 텍스처의 내용을 쓸 스프라이트.</param>
        public static void WriteToSprite(this RenderTexture renderTexture, Sprite sprite)
        {
            renderTexture.WriteToTexture2D(sprite.texture);
        }
    }
}
