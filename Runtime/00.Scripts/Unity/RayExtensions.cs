using UnityEngine;

namespace Hian.Extensions
{
    /// <summary>
    /// Ray 구조체에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class RayExtensions
    {
        /// <summary>
        /// 반전된 Ray를 생성합니다.
        /// </summary>
        /// <param name="ray">대상 Ray.</param>
        /// <param name="maxDistance">Ray의 최대 거리.</param>
        /// <returns>반전된 Ray.</returns>
        public static Ray Reversed(this Ray ray, float maxDistance)
        {
            return new Ray(ray.GetPoint(maxDistance), -ray.direction);
        }

        /// <summary>
        /// 주어진 <paramref name="angle"/>만큼 임의로 Ray 방향을 편향시킵니다.
        /// </summary>
        /// <param name="ray">대상 Ray.</param>
        /// <param name="angle">Ray가 편향될 각도.</param>
        /// <returns>편향된 Ray.</returns>
        public static Ray RandomDeflected(this Ray ray, float angle)
        {
            return RandomDeflected(ray, new Vector2(angle, angle), Vector3.up);
        }

        /// <summary>
        /// <paramref name="up"/> 축을 고려하여 주어진 <paramref name="angle"/>만큼 임의로 Ray 방향을 편향시킵니다.
        /// </summary>
        /// <param name="ray">대상 Ray.</param>
        /// <param name="angle">Ray가 편향될 각도.</param>
        /// <param name="up">위쪽 축.</param>
        /// <returns>편향된 Ray.</returns>
        public static Ray RandomDeflected(this Ray ray, float angle, Vector3 up)
        {
            return RandomDeflected(ray, new Vector2(angle, angle), up);
        }

        /// <summary>
        /// 주어진 <paramref name="angleX"/>와 <paramref name="angleY"/>만큼 임의로 Ray 방향을 편향시킵니다.
        /// </summary>
        /// <param name="ray">대상 Ray.</param>
        /// <param name="angleX">X축을 기준으로 Ray가 편향될 각도.</param>
        /// <param name="angleY">Y축을 기준으로 Ray가 편향될 각도.</param>
        /// <returns>편향된 Ray.</returns>
        public static Ray RandomDeflected(this Ray ray, float angleX, float angleY)
        {
            return RandomDeflected(ray, new Vector2(angleX, angleY), Vector3.up);
        }

        /// <summary>
        /// <paramref name="up"/> 축을 고려하여 주어진 <paramref name="angleX"/>와 <paramref name="angleY"/>만큼 임의로 Ray 방향을 편향시킵니다.
        /// </summary>
        /// <param name="ray">대상 Ray.</param>
        /// <param name="angleX">X축을 기준으로 Ray가 편향될 각도.</param>
        /// <param name="angleY">Y축을 기준으로 Ray가 편향될 각도.</param>
        /// <param name="up">위쪽 축.</param>
        /// <returns>편향된 Ray.</returns>
        public static Ray RandomDeflected(this Ray ray, float angleX, float angleY, Vector3 up)
        {
            return RandomDeflected(ray, new Vector2(angleX, angleY), up);
        }

        /// <summary>
        /// 주어진 <paramref name="angles"/>만큼 임의로 Ray 방향을 편향시킵니다.
        /// </summary>
        /// <param name="ray">대상 Ray.</param>
        /// <param name="angles">X축과 Y축을 기준으로 Ray가 편향될 각도.</param>
        /// <returns>편향된 Ray.</returns>
        public static Ray RandomDeflected(this Ray ray, Vector2 angles)
        {
            return RandomDeflected(ray, angles, Vector3.up);
        }

        /// <summary>
        /// <paramref name="up"/> 축을 고려하여 주어진 <paramref name="angles"/>만큼 임의로 Ray 방향을 편향시킵니다.
        /// </summary>
        /// <param name="ray">대상 Ray.</param>
        /// <param name="angles">X축과 Y축을 기준으로 Ray가 편향될 각도.</param>
        /// <param name="up">위쪽 축.</param>
        /// <returns>편향된 Ray.</returns>
        public static Ray RandomDeflected(this Ray ray, Vector2 angles, Vector3 up)
        {
            return new Ray(ray.origin, ray.direction.RandomDeflected(angles, up));
        }
    }
}
