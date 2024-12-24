using UnityEngine;

namespace Hian.Extensions
{
    /// <summary>
    /// Unity GameObject 클래스에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class GameObjectExtensions
    {
        /// <summary>
        /// 게임 오브젝트에서 <typeparamref name="T"/> 컴포넌트를 가져옵니다.
        /// 만약 존재하지 않으면, 새로운 컴포넌트를 생성하여 반환합니다.
        /// </summary>
        /// <typeparam name="T">컴포넌트 타입.</typeparam>
        /// <param name="gameObject">대상 게임 오브젝트.</param>
        /// <returns>게임 오브젝트의 <typeparamref name="T"/> 컴포넌트.</returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject)
            where T : Component
        {
            if (gameObject.TryGetComponent(out T component))
            {
                return component;
            }

            return gameObject.AddComponent<T>();
        }

        /// <summary>
        /// <paramref name="gameObject"/> 자신 또는 자�� 게임 오브젝트에서 <typeparamref name="T"/> 컴포넌트를 찾습니다.
        /// </summary>
        /// <typeparam name="T">컴포넌트 타입.</typeparam>
        /// <param name="gameObject">대상 게임 오브젝트.</param>
        /// <param name="component">찾은 <typeparamref name="T"/> 컴포넌트를 저장할 변수.</param>
        /// <param name="includeInactive">비활성화된 게임 오브젝트도 포함하여 검색할지 여부.</param>
        /// <returns><typeparamref name="T"/> 컴포넌트를 찾았으면 <see langword="true"/>, 그렇지 않으면 <see langword="false"/>를 반환합니다.</returns>
        public static bool TryGetComponentInChildren<T>(
            this GameObject gameObject,
            out T component,
            bool includeInactive = false
        )
            where T : Component
        {
            component = gameObject.GetComponentInChildren<T>(includeInactive);
            return component != null;
        }

        /// <summary>
        /// <paramref name="gameObject"/> 자신 또는 부모 게임 오브젝트에서 <typeparamref name="T"/> 컴포넌트를 찾습니다.
        /// </summary>
        /// <typeparam name="T">컴포넌트 타입.</typeparam>
        /// <param name="gameObject">대상 게임 오브젝트.</param>
        /// <param name="component">찾은 <typeparamref name="T"/> 컴포넌트를 저장할 변수.</param>
        /// <param name="includeInactive">비활성화된 게임 오브젝트도 포함하여 검색할지 여부.</param>
        /// <returns><typeparamref name="T"/> 컴포넌트를 찾았으면 <see langword="true"/>, 그렇지 않으면 <see langword="false"/>를 반환합니다.</returns>
        public static bool TryGetComponentInParent<T>(
            this GameObject gameObject,
            out T component,
            bool includeInactive = false
        )
            where T : Component
        {
            component = gameObject.GetComponentInParent<T>(includeInactive);
            return component != null;
        }

        /// <summary>
        /// 게임 오브젝트가 레이어 마스크에 속하는지 확인합니다.
        /// </summary>
        /// <param name="gameObject">대상 게임 오브젝트.</param>
        /// <param name="layerMask">레이어 마스크.</param>
        /// <returns>레이어 마스크에 게임 오브젝트의 레이어가 포함되어 있으면 <see langword="true"/>, 그렇지 않으면 <see langword="false"/>를 반환합니다.</returns>
        public static bool IsInLayerMask(this GameObject gameObject, LayerMask layerMask)
        {
            return (layerMask.value & (1 << gameObject.layer)) > 0;
        }

        /// <summary>
        /// 게임 오브젝트가 주어진 레이어들 중 하나에 속하는지 확인합니다.
        /// </summary>
        /// <param name="gameObject">대상 게임 오브젝트.</param>
        /// <param name="layerNames">레이어 이름들.</param>
        /// <returns>게임 오브젝트의 레이어가 <paramref name="layerNames"/>에 있으면 <see langword="true"/>, 그렇지 않으면 <see langword="false"/>를 반환합니다.</returns>
        public static bool IsInLayers(this GameObject gameObject, params string[] layerNames)
        {
            return IsInLayerMask(gameObject, LayerMask.GetMask(layerNames));
        }

        /// <summary>
        /// 게임 오브젝트와 모든 자식 게임 오브젝트의 레이어를 설정합니다.
        /// </summary>
        /// <param name="gameObject">대상 게임 오브젝트.</param>
        /// <param name="layer">설정할 레이어 이름.</param>
        public static void SetLayerRecursive(this GameObject gameObject, string layer)
        {
            SetLayerRecursive(gameObject, LayerMask.NameToLayer(layer));
        }

        /// <summary>
        /// 게임 오브젝트와 모든 자식 게임 오브젝트의 레이어를 설정합니다.
        /// </summary>
        /// <param name="gameObject">대상 게임 오���젝트.</param>
        /// <param name="layer">설정할 레이어.</param>
        public static void SetLayerRecursive(this GameObject gameObject, int layer)
        {
            gameObject.layer = layer;

            foreach (Transform child in gameObject.transform)
            {
                SetLayerRecursive(child.gameObject, layer);
            }
        }
    }
}
