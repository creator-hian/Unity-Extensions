using UnityEngine;
using UnityEngine.Rendering;

namespace Hian.Unity.Extensions
{
    /// <summary>
    /// 자주 사용되는 셰이더 프로퍼티 ID들을 미리 캐싱하여 제공하는 확장 클래스입니다.
    /// </summary>
    public static class ShaderPropertyExtensions
    {
        // Common Properties
        public static readonly int MainTexPropertyID = Shader.PropertyToID("_MainTex");
        public static readonly int ColorPropertyID = Shader.PropertyToID("_Color");
        public static readonly int EmissionColorPropertyID = Shader.PropertyToID("_EmissionColor");
        public static readonly int BumpMapPropertyID = Shader.PropertyToID("_BumpMap");
        public static readonly int MetallicPropertyID = Shader.PropertyToID("_Metallic");
        public static readonly int GlossMapPropertyID = Shader.PropertyToID("_GlossMap");
        public static readonly int GlossPropertyID = Shader.PropertyToID("_Glossiness");
        public static readonly int SmoothnessPropertyID = Shader.PropertyToID("_Smoothness");

        // Render State Properties
        public static readonly int ZWritePropertyID = Shader.PropertyToID("_ZWrite");
        public static readonly int ZTestPropertyID = Shader.PropertyToID("_ZTest");
        public static readonly int CullPropertyID = Shader.PropertyToID("_Cull");
        public static readonly int SrcBlendPropertyID = Shader.PropertyToID("_SrcBlend");
        public static readonly int DstBlendPropertyID = Shader.PropertyToID("_DstBlend");

        // Alpha Related
        public static readonly int AlphaPropertyID = Shader.PropertyToID("_Alpha");
        public static readonly int AlphaCutoffPropertyID = Shader.PropertyToID("_Cutoff");

        // Additional Maps
        public static readonly int OcclusionMapPropertyID = Shader.PropertyToID("_OcclusionMap");
        public static readonly int ParallaxMapPropertyID = Shader.PropertyToID("_ParallaxMap");
        public static readonly int HeightMapPropertyID = Shader.PropertyToID("_HeightMap");

        // UV Related
        public static readonly int MainTexSTPropertyID = Shader.PropertyToID("_MainTex_ST");
        public static readonly int UVOffsetPropertyID = Shader.PropertyToID("_UVOffset");
        public static readonly int UVScalePropertyID = Shader.PropertyToID("_UVScale");
    }
}
