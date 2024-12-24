using UnityEngine;
using UnityEngine.UI;

namespace Hian.Extensions
{
    /// <summary>
    /// Unity Graphic 클래스에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class GraphicExtensions
    {
        /// <summary>
        /// 그래픽 객체의 색상의 빨간색 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="r">설정할 값.</param>
        public static void SetColorR(this Graphic graphic, float r)
        {
            graphic.color = graphic.color.WithR(r);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 녹색 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="g">설정할 값.</param>
        public static void SetColorG(this Graphic graphic, float g)
        {
            graphic.color = graphic.color.WithG(g);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 파란색 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="b">설정할 값.</param>
        public static void SetColorB(this Graphic graphic, float b)
        {
            graphic.color = graphic.color.WithB(b);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 알파 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="a">설정할 값.</param>
        public static void SetColorA(this Graphic graphic, float a)
        {
            graphic.color = graphic.color.WithA(a);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 빨간색과 녹색 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="r">빨간색 채널에 설정할 값.</param>
        /// <param name="g">녹색 채널에 설정할 값.</param>
        public static void SetColorRG(this Graphic graphic, float r, float g)
        {
            graphic.color = graphic.color.WithRG(r, g);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 빨간색과 파란색 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="r">빨간색 채널에 설정할 값.</param>
        /// <param name="b">파란색 채널에 설정할 값.</param>
        public static void SetColorRB(this Graphic graphic, float r, float b)
        {
            graphic.color = graphic.color.WithRB(r, b);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 빨간색과 알파 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="r">빨간색 채널에 설정할 값.</param>
        /// <param name="a">알파 채널에 설정할 값.</param>
        public static void SetColorRA(this Graphic graphic, float r, float a)
        {
            graphic.color = graphic.color.WithRA(r, a);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 녹색과 파란색 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="g">녹색 채널에 설정할 값.</param>
        /// <param name="b">파란색 채널에 설정할 값.</param>
        public static void SetColorGB(this Graphic graphic, float g, float b)
        {
            graphic.color = graphic.color.WithGB(g, b);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 녹색과 알파 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="g">녹색 채널에 설정할 값.</param>
        /// <param name="a">알파 채널에 설정할 값.</param>
        public static void SetColorGA(this Graphic graphic, float g, float a)
        {
            graphic.color = graphic.color.WithGA(g, a);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 파란색과 알파 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="b">파란색 채널에 설정할 값.</param>
        /// <param name="a">알파 채널에 설정할 값.</param>
        public static void SetColorBA(this Graphic graphic, float b, float a)
        {
            graphic.color = graphic.color.WithBA(b, a);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 빨간색, 녹색 및 파란색 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="r">빨간색 채널에 설정할 값.</param>
        /// <param name="g">녹색 채널에 설정할 값.</param>
        /// <param name="b">파란색 채널에 설정할 값.</param>
        public static void SetColorRGB(this Graphic graphic, float r, float g, float b)
        {
            graphic.color = graphic.color.WithRGB(r, g, b);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 빨간색, 녹색 및 파란색 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="color">설정할 색상.</param>
        public static void SetColorRGB(this Graphic graphic, Color color)
        {
            graphic.color = color.WithA(graphic.color.a);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 빨간색, 녹색 및 알파 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="r">빨간색 채널에 설정할 값.</param>
        /// <param name="g">녹색 채널에 설정할 값.</param>
        /// <param name="a">알파 채널에 설정할 값.</param>
        public static void SetColorRGA(this Graphic graphic, float r, float g, float a)
        {
            graphic.color = graphic.color.WithRGA(r, g, a);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 빨간색, 파란색 및 알파 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="r">빨간색 채널에 설정할 값.</param>
        /// <param name="b">파란색 채널에 설정할 값.</param>
        /// <param name="a">알파 채널에 설정할 값.</param>
        public static void SetColorRBA(this Graphic graphic, float r, float b, float a)
        {
            graphic.color = graphic.color.WithRBA(r, b, a);
        }

        /// <summary>
        /// 그래픽 객체의 색상의 녹색, 파란색 및 알파 채널 값을 설정합니다.
        /// </summary>
        /// <param name="graphic">대상 그래픽.</param>
        /// <param name="g">녹색 채널에 설정할 값.</param>
        /// <param name="b">파란색 채널에 설정할 값.</param>
        /// <param name="a">알파 채널에 설정할 값.</param>
        public static void SetColorGBA(this Graphic graphic, float g, float b, float a)
        {
            graphic.color = graphic.color.WithGBA(g, b, a);
        }
    }
}
