using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace Hian.Extensions
{
    /// <summary>
    /// Transform에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class TransformExtensions
    {
        /// <summary>
        /// Transform의 x 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetPositionX(this Transform transform, float x)
        {
            transform.position = transform.position.WithX(x);
        }

        /// <summary>
        /// Transform의 y 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetPositionY(this Transform transform, float y)
        {
            transform.position = transform.position.WithY(y);
        }

        /// <summary>
        /// Transform의 z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetPositionZ(this Transform transform, float z)
        {
            transform.position = transform.position.WithZ(z);
        }

        /// <summary>
        /// Transform의 x, y 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetPositionXY(this Transform transform, float x, float y)
        {
            transform.position = transform.position.WithXY(x, y);
        }

        /// <summary>
        /// Transform의 x, y 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="position">설정할 위치.</param>
        public static void SetPositionXY(this Transform transform, Vector2 position)
        {
            transform.position = transform.position.WithXY(position);
        }

        /// <summary>
        /// Transform의 x, z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetPositionXZ(this Transform transform, float x, float z)
        {
            transform.position = transform.position.WithXZ(x, z);
        }

        /// <summary>
        /// Transform의 x, z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="position">설정할 위치.</param>
        public static void SetPositionXZ(this Transform transform, Vector2 position)
        {
            transform.position = transform.position.WithXZ(position);
        }

        /// <summary>
        /// Transform의 y, z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetPositionYZ(this Transform transform, float y, float z)
        {
            transform.position = transform.position.WithYZ(y, z);
        }

        /// <summary>
        /// Transform의 y, z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="position">설정할 위치.</param>
        public static void SetPositionYZ(this Transform transform, Vector2 position)
        {
            transform.position = transform.position.WithYZ(position);
        }

        /// <summary>
        /// Transform의 로컬 x 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetLocalPositionX(this Transform transform, float x)
        {
            transform.localPosition = transform.localPosition.WithX(x);
        }

        /// <summary>
        /// Transform의 로컬 y 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetLocalPositionY(this Transform transform, float y)
        {
            transform.localPosition = transform.localPosition.WithY(y);
        }

        /// <summary>
        /// Transform의 로컬 z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetLocalPositionZ(this Transform transform, float z)
        {
            transform.localPosition = transform.localPosition.WithZ(z);
        }

        /// <summary>
        /// Transform의 로컬 x, y 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetLocalPositionXY(this Transform transform, float x, float y)
        {
            transform.localPosition = transform.localPosition.WithXY(x, y);
        }

        /// <summary>
        /// Transform의 로컬 x, y 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="position">설정할 위치.</param>
        public static void SetLocalPositionXY(this Transform transform, Vector2 position)
        {
            transform.position = transform.localPosition.WithXY(position);
        }

        /// <summary>
        /// Transform의 로컬 x, z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetLocalPositionXZ(this Transform transform, float x, float z)
        {
            transform.localPosition = transform.localPosition.WithXZ(x, z);
        }

        /// <summary>
        /// Transform의 로컬 x, z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="position">설정할 위치.</param>
        public static void SetLocalPositionXZ(this Transform transform, Vector2 position)
        {
            transform.position = transform.localPosition.WithXZ(position);
        }

        /// <summary>
        /// Transform의 로컬 y, z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetLocalPositionYZ(this Transform transform, float y, float z)
        {
            transform.localPosition = transform.localPosition.WithYZ(y, z);
        }

        /// <summary>
        /// Transform의 로컬 y, z 좌표를 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="position">설정할 위치.</param>
        public static void SetLocalPositionYZ(this Transform transform, Vector2 position)
        {
            transform.position = transform.localPosition.WithYZ(position);
        }

        /// <summary>
        /// Transform의 오일러 각도 x 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetEulerAnglesX(this Transform transform, float x)
        {
            transform.eulerAngles = transform.eulerAngles.WithX(x);
        }

        /// <summary>
        /// Transform의 오일러 각도 y 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetEulerAnglesY(this Transform transform, float y)
        {
            transform.eulerAngles = transform.eulerAngles.WithY(y);
        }

        /// <summary>
        /// Transform의 오일러 각도 z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetEulerAnglesZ(this Transform transform, float z)
        {
            transform.eulerAngles = transform.eulerAngles.WithZ(z);
        }

        /// <summary>
        /// Transform의 오일러 각도 x, y 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetEulerAnglesXY(this Transform transform, float x, float y)
        {
            transform.eulerAngles = transform.eulerAngles.WithXY(x, y);
        }

        /// <summary>
        /// Transform의 오일러 각도 x, y 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="eulers">설정할 각도.</param>
        public static void SetEulerAnglesXY(this Transform transform, Vector2 eulers)
        {
            transform.eulerAngles = transform.eulerAngles.WithXY(eulers);
        }

        /// <summary>
        /// Transform의 오일러 각도 x, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetEulerAnglesXZ(this Transform transform, float x, float z)
        {
            transform.eulerAngles = transform.eulerAngles.WithXZ(x, z);
        }

        /// <summary>
        /// Transform의 오일러 각도 x, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="eulers">설정할 각도.</param>
        public static void SetEulerAnglesXZ(this Transform transform, Vector2 eulers)
        {
            transform.eulerAngles = transform.eulerAngles.WithXZ(eulers);
        }

        /// <summary>
        /// Transform의 오일러 각도 y, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetEulerAnglesYZ(this Transform transform, float y, float z)
        {
            transform.eulerAngles = transform.eulerAngles.WithYZ(y, z);
        }

        /// <summary>
        /// Transform의 오일러 각도 y, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="eulers">설정할 각도.</param>
        public static void SetEulerAnglesYZ(this Transform transform, Vector2 eulers)
        {
            transform.eulerAngles = transform.eulerAngles.WithYZ(eulers);
        }

        /// <summary>
        /// Transform의 로컬 오일러 각도 x 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetLocalEulerAnglesX(this Transform transform, float x)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithX(x);
        }

        /// <summary>
        /// Transform의 로컬 오일러 각도 y 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetLocalEulerAnglesY(this Transform transform, float y)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithY(y);
        }

        /// <summary>
        /// Transform의 로컬 오일러 각도 z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetLocalEulerAnglesZ(this Transform transform, float z)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithZ(z);
        }

        /// <summary>
        /// Transform의 로컬 오일러 각도 x, y 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetLocalEulerAnglesXY(this Transform transform, float x, float y)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXY(x, y);
        }

        /// <summary>
        /// Transform의 로컬 오일러 각도 x, y 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="eulers">설정할 각도.</param>
        public static void SetLocalEulerAnglesXY(this Transform transform, Vector2 eulers)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXY(eulers);
        }

        /// <summary>
        /// Transform의 로컬 오일러 각도 x, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetLocalEulerAnglesXZ(this Transform transform, float x, float z)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXZ(x, z);
        }

        /// <summary>
        /// Transform의 로컬 오일러 각도 x, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="eulers">설정할 각도.</param>
        public static void SetLocalEulerAnglesXZ(this Transform transform, Vector2 eulers)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithXZ(eulers);
        }

        /// <summary>
        /// Transform의 로컬 오일러 각도 y, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetLocalEulerAnglesYZ(this Transform transform, float y, float z)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithYZ(y, z);
        }

        /// <summary>
        /// Transform의 로컬 오일러 각도 y, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="eulers">설정할 각도.</param>
        public static void SetLocalEulerAnglesYZ(this Transform transform, Vector2 eulers)
        {
            transform.localEulerAngles = transform.localEulerAngles.WithYZ(eulers);
        }

        /// <summary>
        /// Transform의 로컬 스케일 x 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        public static void SetLocalScaleX(this Transform transform, float x)
        {
            transform.localScale = transform.localScale.WithX(x);
        }

        /// <summary>
        /// Transform의 로컬 스케일 y 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetLocalScaleY(this Transform transform, float y)
        {
            transform.localScale = transform.localScale.WithY(y);
        }

        /// <summary>
        /// Transform의 로컬 스케일 z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetLocalScaleZ(this Transform transform, float z)
        {
            transform.localScale = transform.localScale.WithZ(z);
        }

        /// <summary>
        /// Transform의 로컬 스케일 x, y 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        public static void SetLocalScaleXY(this Transform transform, float x, float y)
        {
            transform.localScale = transform.localScale.WithXY(x, y);
        }

        /// <summary>
        /// Transform의 로컬 스케일 x, y 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="scale">설정할 스케일.</param>
        public static void SetLocalScaleXY(this Transform transform, Vector2 scale)
        {
            transform.localScale = transform.localScale.WithXY(scale);
        }

        /// <summary>
        /// Transform의 로컬 스케일 x, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetLocalScaleXZ(this Transform transform, float x, float z)
        {
            transform.localScale = transform.localScale.WithXZ(x, z);
        }

        /// <summary>
        /// Transform의 로컬 스케일 x, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="scale">설정할 스케일.</param>
        public static void SetLocalScaleXZ(this Transform transform, Vector2 scale)
        {
            transform.localScale = transform.localScale.WithXZ(scale);
        }

        /// <summary>
        /// Transform의 로컬 스케일 y, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        public static void SetLocalScaleYZ(this Transform transform, float y, float z)
        {
            transform.localScale = transform.localScale.WithYZ(y, z);
        }

        /// <summary>
        /// Transform의 로컬 스케일 y, z 값을 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="scale">설정할 스케일.</param>
        public static void SetLocalScaleYZ(this Transform transform, Vector2 scale)
        {
            transform.localScale = transform.localScale.WithYZ(scale);
        }

        /// <summary>
        /// Transform의 로컬 스케일을 균일하게 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="scale">설정할 균일 스케일.</param>
        public static void SetLocalScale(this Transform transform, float scale)
        {
            transform.localScale = transform.localScale = new Vector3(scale, scale, scale);
        }

        /// <summary>
        /// Transform의 위치, 회전, 스케일을 초기화합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="useWorldSpace">월드 공간을 사용할지 여부.</param>
        public static void Reset(this Transform transform, bool useWorldSpace = false)
        {
            if (useWorldSpace)
            {
                transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            }
            else
            {
                transform.localPosition = Vector3.zero;
                transform.localRotation = Quaternion.identity;
            }

            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// 형제 순서를 이전으로 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        public static void SetToPreviousSibling(this Transform transform)
        {
            transform.SetSiblingIndex(Mathf.Max(transform.GetSiblingIndex() - 1, 0));
        }

        /// <summary>
        /// 형제 순서를 다음으로 설정합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        public static void SetToNextSibling(this Transform transform)
        {
            int maxSiblingIndex =
                (
                    transform.parent != null
                        ? transform.parent.childCount
                        : transform.gameObject.scene.rootCount
                ) - 1;
            transform.SetSiblingIndex(Mathf.Min(transform.GetSiblingIndex() + 1, maxSiblingIndex));
        }

        /// <summary>
        /// 현재 오브젝트의 이전 Transform을 반환합니다. 이전 Transform이 없으면 현재 Transform을 반환합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <returns>이전 오브젝트의 Transform.</returns>
        public static Transform GetPreviousSiblingTransform(this Transform transform)
        {
            if (transform.GetSiblingIndex() == 0)
            {
                return null;
            }

            if (transform.parent)
            {
                return transform.parent.GetChild(transform.GetSiblingIndex() - 1);
            }
            else
            {
                return transform
                    .gameObject.scene.GetRootGameObjects()[transform.GetSiblingIndex() - 1]
                    .transform;
            }
        }

        /// <summary>
        /// 현재 오브젝트의 다음 Transform을 반환합니다. 다음 Transform이 없으면 현재 Transform을 반환합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <returns>다음 오브젝트의 Transform.</returns>
        public static Transform GetNextSiblingTransform(this Transform transform)
        {
            if (transform.parent)
            {
                if (transform.GetSiblingIndex() == transform.parent.childCount - 1)
                {
                    return null;
                }

                return transform.parent.GetChild(transform.GetSiblingIndex() + 1);
            }

            if (transform.GetSiblingIndex() == transform.gameObject.scene.rootCount - 1)
            {
                return null;
            }

            return transform
                .gameObject.scene.GetRootGameObjects()[transform.GetSiblingIndex() + 1]
                .transform;
        }

        /// <summary>
        /// 모든 형제 오브젝트(Transform 컴포넌트)를 반환합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="includeThis">이 <paramref name="transform"/> 오브젝트를 포함할지 여부.</param>
        /// <returns>형제 오브젝트 Transform.</returns>
        public static List<Transform> GetAllSiblingObjects(
            this Transform transform,
            bool includeThis = true
        )
        {
            List<Transform> siblings;

            if (transform.parent)
            {
                siblings = new List<Transform>(transform.parent.childCount);

                for (int i = 0; i < transform.parent.childCount; i++)
                {
                    Transform child = transform.parent.GetChild(i);

                    if (includeThis || !includeThis && child != transform)
                    {
                        siblings.Add(child);
                    }
                }
            }
            else
            {
                GameObject[] childs = transform.gameObject.scene.GetRootGameObjects();
                siblings = new List<Transform>(childs.Length);

                for (int i = 0; i < childs.Length; i++)
                {
                    Transform child = childs[i].transform;

                    if (includeThis || !includeThis && child != transform)
                    {
                        siblings.Add(child);
                    }
                }
            }

            return siblings;
        }

        /// <summary>
        /// 모든 자식의 목록을 가져옵니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <returns>모든 자식 목록.</returns>
        public static List<Transform> GetChilds(this Transform transform)
        {
            return transform.Cast<Transform>().ToList();
        }

        /// <summary>
        /// 임의의 자식을 가져옵니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <returns>임의의 자식.</returns>
        public static Transform GetRandomChild(this Transform transform)
        {
            return transform.GetChild(UnityEngine.Random.Range(0, transform.childCount));
        }

        /// <summary>
        /// Transform에 자식을 추가합니다.
        /// </summary>
        /// <param name="childs">추가할 자식.</param>
        /// <param name="transform">대상 Transform.</param>
        public static void AddChilds(this Transform transform, params Transform[] childs)
        {
            AddChilds(transform, (IEnumerable<Transform>)childs);
        }

        /// <summary>
        /// Transform에 자식을 추가합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="childs">추가할 자식.</param>
        public static void AddChilds(this Transform transform, IEnumerable<Transform> childs)
        {
            foreach (Transform child in childs)
            {
                child.SetParent(transform);
            }
        }

        /// <summary>
        /// 모든 자식을 제거합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        public static void DestroyChilds(this Transform transform)
        {
            GetChilds(transform).ForEach(static child => UnityObject.Destroy(child.gameObject));
        }

        /// <summary>
        /// <paramref name="index"/>부터 시작하여 모든 자식을 제거합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        public static void DestroyChilds(this Transform transform, int index)
        {
            GetChilds(transform)
                .Skip(index)
                .ForEach(static child => UnityObject.Destroy(child.gameObject));
        }

        /// <summary>
        /// <paramref name="index"/>부터 시작하여 <paramref name="count"/>개의 자식을 제거합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        public static void DestroyChilds(this Transform transform, int index, int count)
        {
            GetChilds(transform)
                .Skip(index)
                .Take(count)
                .ForEach(static child => UnityObject.Destroy(child.gameObject));
        }

        /// <summary>
        /// 조건에 따라 모든 자식을 제거합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <param name="predicate">조건.</param>
        public static void DestroyChildsWhere(
            this Transform transform,
            Predicate<Transform> predicate
        )
        {
            IEnumerable<Transform> filtered = GetChilds(transform).Where(c => predicate(c));

            foreach (Transform child in filtered)
            {
                UnityObject.Destroy(child.gameObject);
            }
        }

        /// <summary>
        /// 인덱스로 자식을 제거합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        public static void DestroyChild(this Transform transform, int index)
        {
            UnityObject.Destroy(transform.GetChild(index).gameObject);
        }

        /// <summary>
        /// 첫 번째 자식을 제거합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        public static void DestroyFirstChild(this Transform transform)
        {
            DestroyChild(transform, 0);
        }

        /// <summary>
        /// 마지막 자식을 제거합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        public static void DestroyLastChild(this Transform transform)
        {
            DestroyChild(transform, transform.childCount - 1);
        }

        /// <summary>
        /// Transform을 RectTransform 타입으로 캐스팅합니다.
        /// </summary>
        /// <param name="transform">대상 Transform.</param>
        /// <returns>캐스팅된 RectTransform 객체.</returns>
        public static RectTransform AsRect(this Transform transform)
        {
            return transform as RectTransform;
        }
    }
}
