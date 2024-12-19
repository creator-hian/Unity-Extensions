using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hian.Extensions
{
    /// <summary>
    /// Unity Component 클래스에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class ComponentExtensions
    {
        /// <summary>
        /// <paramref name="component"/>의 게임 오브젝트에서 <typeparamref name="T"/> 컴포넌트를 가져옵니다.
        /// 만약 존재하지 않으면, 새로운 컴포넌트를 생성하여 반환합니다.
        /// </summary>
        /// <typeparam name="T">컴포넌트 타입.</typeparam>
        /// <param name="component">대상 컴포넌트.</param>
        /// <returns><paramref name="component"/>의 게임 오브젝트에 있는 <typeparamref name="T"/> 컴포넌트.</returns>
        public static T GetOrAddComponent<T>(this Component component)
            where T : Component
        {
            return component.gameObject.GetOrAddComponent<T>();
        }

        /// <summary>
        /// <paramref name="sourceComponent"/> 자신 또는 자식 게임 오브젝트에서 <typeparamref name="T"/> 컴포넌트를 찾습니다.
        /// </summary>
        /// <typeparam name="T">컴포넌트 타입.</typeparam>
        /// <param name="sourceComponent">검색을 시작할 컴포넌트.</param>
        /// <param name="component">찾은 <typeparamref name="T"/> 컴포넌트를 저장할 변수.</param>
        /// <param name="includeInactive">비활성화된 게임 오브젝트도 포함하여 검색할지 여부.</param>
        /// <returns><typeparamref name="T"/> 컴포넌트를 찾았으면 <see langword="true"/>, 그렇지 않으면 <see langword="false"/>를 반환합니다.</returns>
        public static bool TryGetComponentInChildren<T>(
            this Component sourceComponent,
            out T component,
            bool includeInactive = false
        )
            where T : Component
        {
            component = sourceComponent.gameObject.GetComponentInChildren<T>(includeInactive);
            return component != null;
        }

        /// <summary>
        /// <paramref name="sourceComponent"/> 자신 또는 부모 게임 오브젝트에서 <typeparamref name="T"/> 컴포넌트를 찾습니다.
        /// </summary>
        /// <typeparam name="T">컴포넌트 타입.</typeparam>
        /// <param name="sourceComponent">검색을 시작할 컴포넌트.</param>
        /// <param name="component">찾은 <typeparamref name="T"/> 컴포넌트��� 저장할 변수.</param>
        /// <param name="includeInactive">비활성화된 게임 오브젝트도 포함하여 검색할지 여부.</param>
        /// <returns><typeparamref name="T"/> 컴포넌트를 찾았으면 <see langword="true"/>, 그렇지 않으면 <see langword="false"/>를 반환합니다.</returns>
        public static bool TryGetComponentInParent<T>(
            this Component sourceComponent,
            out T component,
            bool includeInactive = false
        )
            where T : Component
        {
            component = sourceComponent.gameObject.GetComponentInParent<T>(includeInactive);
            return component != null;
        }
    }
}
