using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Hian.Extensions
{
    /// <summary>
    /// Scene에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class SceneExtensions
    {
        /// <summary>
        /// Scene에서 <typeparamref name="T"/> 컴포넌트를 가진 게임 오브젝트를 찾습니다.
        /// </summary>
        /// <typeparam name="T">컴포넌트 타입.</typeparam>
        /// <param name="scene">대상 Scene.</param>
        /// <param name="includeInactive">비활성 게임 오브젝트를 찾을지 여부.</param>
        /// <returns>찾은 게임 오브젝트.</returns>
        public static T FindObjectOfType<T>(this Scene scene, bool includeInactive = false)
            where T : Component
        {
            foreach (
                var root in scene.GetRootGameObjects().Where(r => r.activeSelf || includeInactive)
            )
            {
                if (root.TryGetComponentInChildren<T>(out T component, includeInactive))
                    return component;
            }

            return null;
        }

        /// <summary>
        /// Scene에서 <typeparamref name="T"/> 컴포넌트를 가진 게임 오브젝트들을 찾습니다.
        /// </summary>
        /// <typeparam name="T">컴포넌트 타입.</typeparam>
        /// <param name="scene">대상 Scene.</param>
        /// <param name="includeInactive">비활성 게임 오브젝트를 찾을지 여부.</param>
        /// <returns>찾은 게임 오브젝트들.</returns>
        public static T[] FindObjectsOfType<T>(this Scene scene, bool includeInactive = false)
        {
            var filtered = scene.GetRootGameObjects().Where(r => r.activeSelf || includeInactive);
            return filtered
                .SelectMany(go => go.GetComponentsInChildren<T>(includeInactive))
                .ToArray();
        }

        /// <summary>
        /// Scene에 있는 모든 게임 오브젝트의 개수를 계산합니다.
        /// </summary>
        /// <param name="scene">대상 Scene.</param>
        /// <param name="includeInactive">비활성 게임 오브젝트를 계산할지 여부.</param>
        /// <returns></returns>
        public static int ObjectsCount(this Scene scene, bool includeInactive = false)
        {
            var filtered = scene.GetRootGameObjects().Where(r => r.activeSelf || includeInactive);
            return filtered
                .SelectMany(r => r.GetComponentsInChildren<Transform>(includeInactive))
                .Count();
        }
    }
}
