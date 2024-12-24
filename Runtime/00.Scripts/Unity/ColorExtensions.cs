using UnityEngine;

namespace Hian.Extensions
{
    public static class ColorExtensions
    {
        #region With

        /// <summary>
        /// 색상의 지정된 채널에 값을 설정합니다.
        /// 이 메서드는 새로운 Color를 반환하며, 원래의 Color는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="channel">값을 설정할 채널의 인덱스 (0: r, 1: g, 2: b, 3: a).</param>
        /// <param name="value">설정할 값.</param>
        /// <returns>지정된 채널의 값이 변경된 새 Color.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">채널 인덱스가 0, 1, 2, 3이 아닌 경우 발생합니다.</exception>
        public static Color With(this Color color, int channel, float value)
        {
            return channel switch
            {
                0 => color.WithR(value),
                1 => color.WithG(value),
                2 => color.WithB(value),
                3 => color.WithA(value),
                _ => throw new System.ArgumentOutOfRangeException(
                    "channel",
                    "채널 인덱스는 0, 1, 2, 3 중 하나여야 합니다."
                ),
            };
        }

        /// <summary>
        /// 색상의 r 채널에 값을 설정합니다.
        /// 이 메서드는 새로운 Color를 반환하며, 원래의 Color는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="r">설정할 r 값.</param>
        /// <returns>r 값이 변경된 새 Color.</returns>
        public static Color WithR(this Color color, float r)
        {
            return new Color(r, color.g, color.b, color.a);
        }

        /// <summary>
        /// 색상의 g 채널에 값을 설정합니다.
        /// 이 메서드는 새로운 Color를 반환하며, 원래의 Color는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="g">설정할 g 값.</param>
        /// <returns>g 값이 변경된 새 Color.</returns>
        public static Color WithG(this Color color, float g)
        {
            return new Color(color.r, g, color.b, color.a);
        }

        /// <summary>
        /// 색상의 b 채널에 값을 설정합니다.
        /// 이 메서드는 새로운 Color를 반환하며, 원래의 Color는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="b">설정할 b 값.</param>
        /// <returns>b 값이 변경된 새 Color.</returns>
        public static Color WithB(this Color color, float b)
        {
            return new Color(color.r, color.g, b, color.a);
        }

        /// <summary>
        /// 색상의 a 채널에 값을 설정합니다.
        /// 이 메서드는 새로운 Color를 반환하며, 원래의 Color는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="a">설정할 a 값.</param>
        /// <returns>a 값이 변경된 새 Color.</returns>
        public static Color WithA(this Color color, float a)
        {
            return new Color(color.r, color.g, color.b, a);
        }

        /// <summary>
        /// 색상의 두 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="channel1">값을 설정할 첫 번째 채널의 인덱스.</param>
        /// <param name="value1">설정할 첫 번째 채널의 값.</param>
        /// <param name="channel2">값을 설정할 두 번째 채널의 인덱스.</param>
        /// <param name="value2">설정할 두 번째 채널의 값.</param>
        /// <returns>지정된 두 채널의 값이 변경된 새 Color.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">채널 인덱스가 0, 1, 2, 3이 아닌 경우 발생합니다.</exception>
        public static Color With(
            this Color color,
            int channel1,
            float value1,
            int channel2,
            float value2
        )
        {
            color[channel1] = value1;
            color[channel2] = value2;
            return color;
        }

        /// <summary>
        /// 색상의 r, g 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="r">설정할 r 값.</param>
        /// <param name="g">설정할 g 값.</param>
        /// <returns>r, g 값이 변경된 새 Color.</returns>
        public static Color WithRG(this Color color, float r, float g)
        {
            return color.With(0, r, 1, g);
        }

        /// <summary>
        /// 색상의 r, b 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="r">설정할 r 값.</param>
        /// <param name="b">설정할 b 값.</param>
        /// <returns>r, b 값이 변경된 새 Color.</returns>
        public static Color WithRB(this Color color, float r, float b)
        {
            return color.With(0, r, 2, b);
        }

        /// <summary>
        /// 색상의 r, a 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="r">설정할 r 값.</param>
        /// <param name="a">설정할 a 값.</param>
        /// <returns>r, a 값이 변경된 새 Color.</returns>
        public static Color WithRA(this Color color, float r, float a)
        {
            return color.With(0, r, 3, a);
        }

        /// <summary>
        /// 색상의 g, b 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="g">설정할 g 값.</param>
        /// <param name="b">설정할 b 값.</param>
        /// <returns>g, b 값이 변경된 새 Color.</returns>
        public static Color WithGB(this Color color, float g, float b)
        {
            return color.With(1, g, 2, b);
        }

        /// <summary>
        /// 색상의 g, a 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="g">설정할 g 값.</param>
        /// <param name="a">설정할 a 값.</param>
        /// <returns>g, a 값이 변경된 새 Color.</returns>
        public static Color WithGA(this Color color, float g, float a)
        {
            return color.With(1, g, 3, a);
        }

        /// <summary>
        /// 색상의 b, a 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="b">설정할 b 값.</param>
        /// <param name="a">설정할 a 값.</param>
        /// <returns>b, a 값이 변경된 새 Color.</returns>
        public static Color WithBA(this Color color, float b, float a)
        {
            return color.With(2, b, 3, a);
        }

        /// <summary>
        /// 색상의 세 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="channel1">값을 설정할 첫 번째 채널의 인덱스.</param>
        /// <param name="value1">설정할 첫 번째 채널의 값.</param>
        /// <param name="channel2">값을 설정할 두 번째 채널의 인덱스.</param>
        /// <param name="value2">설정할 두 번째 채널의 값.</param>
        /// <param name="channel3">값을 설정할 세 번째 채널의 인덱스.</param>
        /// <param name="value3">설정할 세 번째 채널의 값.</param>
        /// <returns>지정된 세 채널의 값이 변경된 새 Color.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">채널 인덱스가 0, 1, 2, 3이 아닌 경우 발생합니다.</exception>
        public static Color With(
            this Color color,
            int channel1,
            float value1,
            int channel2,
            float value2,
            int channel3,
            float value3
        )
        {
            color[channel1] = value1;
            color[channel2] = value2;
            color[channel3] = value3;
            return color;
        }

        /// <summary>
        /// 색상의 r, g, b 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="r">설정할 r 값.</param>
        /// <param name="g">설정할 g 값.</param>
        /// <param name="b">설정할 b 값.</param>
        /// <returns>r, g, b 값이 변경된 새 Color.</returns>
        public static Color WithRGB(this Color color, float r, float g, float b)
        {
            return color.With(0, r, 1, g, 2, b);
        }

        /// <summary>
        /// 색상의 r, g, a 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="r">설정할 r 값.</param>
        /// <param name="g">설정할 g 값.</param>
        /// <param name="a">설정할 a 값.</param>
        /// <returns>r, g, a 값이 변경된 새 Color.</returns>
        public static Color WithRGA(this Color color, float r, float g, float a)
        {
            return color.With(0, r, 1, g, 3, a);
        }

        /// <summary>
        /// 색상의 r, b, a 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="r">설정할 r 값.</param>
        /// <param name="b">설정할 b 값.</param>
        /// <param name="a">설정할 a 값.</param>
        /// <returns>r, b, a 값이 변경된 새 Color.</returns>
        public static Color WithRBA(this Color color, float r, float b, float a)
        {
            return color.With(0, r, 2, b, 3, a);
        }

        /// <summary>
        /// 색상의 g, b, a 채널에 값을 설정합니다.
        /// </summary>
        /// <param name="color">대상 색상.</param>
        /// <param name="g">설정할 g 값.</param>
        /// <param name="b">설정할 b 값.</param>
        /// <param name="a">설정할 a 값.</param>
        /// <returns>g, b, a 값이 변경된 새 Color.</returns>
        public static Color WithGBA(this Color color, float g, float b, float a)
        {
            return color.With(1, g, 2, b, 3, a);
        }

        #endregion
    }
}
