using UnityEngine;
using UnityEngine.UI;

namespace Hian.Extensions
{
    /// <summary>
    /// Unity Camera 클래스에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class CameraExtensions
    {
        /// <summary>
        /// 카메라의 배경색의 빨간색 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="r">설정할 빨간색 채널 값.</param>
        public static void SetBackgroundColorR(this Camera camera, float r) =>
            camera.backgroundColor = camera.backgroundColor.WithR(r);

        /// <summary>
        /// 카메라의 배경색의 녹색 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="g">설정할 녹색 채널 값.</param>
        public static void SetBackgroundColorG(this Camera camera, float g) =>
            camera.backgroundColor = camera.backgroundColor.WithG(g);

        /// <summary>
        /// 카메라의 배경색의 파란색 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="b">설정할 파란색 채널 값.</param>
        public static void SetBackgroundColorB(this Camera camera, float b) =>
            camera.backgroundColor = camera.backgroundColor.WithB(b);

        /// <summary>
        /// 카메라의 배경색의 알파 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="a">설정할 알파 채널 값.</param>
        public static void SetBackgroundColorA(this Camera camera, float a) =>
            camera.backgroundColor = camera.backgroundColor.WithA(a);

        /// <summary>
        /// 카메라의 배경색의 빨간색과 녹색 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="r">설정할 빨간색 채널 값.</param>
        /// <param name="g">설정할 녹색 채널 값.</param>
        public static void SetBackgroundColorRG(this Camera camera, float r, float g) =>
            camera.backgroundColor = camera.backgroundColor.WithRG(r, g);

        /// <summary>
        /// 카메라의 배경색의 빨간색과 파란색 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="r">설정할 빨간색 채��� 값.</param>
        /// <param name="b">설정할 파란색 채널 값.</param>
        public static void SetBackgroundColorRB(this Camera camera, float r, float b) =>
            camera.backgroundColor = camera.backgroundColor.WithRB(r, b);

        /// <summary>
        /// 카메라의 배경색의 빨간색과 알파 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="r">설정할 빨간색 채널 값.</param>
        /// <param name="a">설정할 알파 채널 값.</param>
        public static void SetBackgroundColorRA(this Camera camera, float r, float a) =>
            camera.backgroundColor = camera.backgroundColor.WithRA(r, a);

        /// <summary>
        /// 카메라의 배경색의 녹색과 파란색 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="g">설정할 녹색 채널 값.</param>
        /// <param name="b">설정할 파란색 채널 값.</param>
        public static void SetBackgroundColorGB(this Camera camera, float g, float b) =>
            camera.backgroundColor = camera.backgroundColor.WithGB(g, b);

        /// <summary>
        /// 카메라의 배경색의 녹색과 알파 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="g">설정할 녹색 채널 값.</param>
        /// <param name="a">설정할 알파 채널 값.</param>
        public static void SetBackgroundColorGA(this Camera camera, float g, float a) =>
            camera.backgroundColor = camera.backgroundColor.WithGA(g, a);

        /// <summary>
        /// 카메라의 배경색의 파란색과 알파 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="b">설정할 파란색 채널 값.</param>
        /// <param name="a">설정할 알파 채널 값.</param>
        public static void SetBackgroundColorBA(this Camera camera, float b, float a) =>
            camera.backgroundColor = camera.backgroundColor.WithBA(b, a);

        /// <summary>
        /// 카메라의 배경색의 빨간색, 녹색, 파란색 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="r">설정할 빨간색 채널 값.</param>
        /// <param name="g">설정할 녹색 채널 값.</param>
        /// <param name="b">설정할 파란색 채널 값.</param>
        public static void SetBackgroundColorRGB(this Camera camera, float r, float g, float b) =>
            camera.backgroundColor = camera.backgroundColor.WithRGB(r, g, b);

        /// <summary>
        /// 카메라의 배경색의 빨간색, 녹색, 알파 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="r">설정할 빨간색 채널 값.</param>
        /// <param name="g">설정할 녹색 채널 값.</param>
        /// <param name="a">설정할 알파 채널 값.</param>
        public static void SetBackgroundColorRGA(this Camera camera, float r, float g, float a) =>
            camera.backgroundColor = camera.backgroundColor.WithRGA(r, g, a);

        /// <summary>
        /// 카메라의 배경색의 빨간색, 파란색, 알파 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="r">설정할 빨간색 채널 값.</param>
        /// <param name="b">설정할 파란색 채널 값.</param>
        /// <param name="a">설정할 알파 채널 값.</param>
        public static void SetBackgroundColorRBA(this Camera camera, float r, float b, float a) =>
            camera.backgroundColor = camera.backgroundColor.WithRBA(r, b, a);

        /// <summary>
        /// 카메라의 배경색의 녹색, 파란색, 알파 채널을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="g">설정할 녹색 채널 값.</param>
        /// <param name="b">설정할 파란색 채널 값.</param>
        /// <param name="a">설정할 알파 채널 값.</param>
        public static void SetBackgroundColorGBA(this Camera camera, float g, float b, float a) =>
            camera.backgroundColor = camera.backgroundColor.WithGBA(g, b, a);

        /// <summary>
        /// 렌즈 쉬프트의 x 구성 요소를 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="x">설정할 x 구성 요소 값.</param>
        public static void SetLensShiftX(this Camera camera, float x) =>
            camera.lensShift = camera.lensShift.WithX(x);

        /// <summary>
        /// 렌즈 쉬프트의 y 구성 요소를 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="y">설정할 y 구성 요소 값.</param>
        public static void SetLensShiftY(this Camera camera, float y) =>
            camera.lensShift = camera.lensShift.WithY(y);

        /// <summary>
        /// 카메라의 픽셀 사각형 중심을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="center">설정할 중심 값.</param>
        public static void SetPixelRectCenter(this Camera camera, Vector2 center) =>
            camera.pixelRect = camera.pixelRect.WithCenter(center);

        /// <summary>
        /// 카메라의 픽셀 사각형 위치를 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="position">설정할 위치 값.</param>
        public static void SetPixelRectPosition(this Camera camera, Vector2 position) =>
            camera.pixelRect = camera.pixelRect.WithPosition(position);

        /// <summary>
        /// 카메라의 픽셀 사각형 높이를 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="height">설정할 높이 값.</param>
        public static void SetPixelRectHeight(this Camera camera, float height) =>
            camera.pixelRect = camera.pixelRect.WithHeight(height);

        /// <summary>
        /// 카메라의 픽셀 사각형 너비를 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="width">설정할 너비 값.</param>
        public static void SetPixelRectWidth(this Camera camera, float width) =>
            camera.pixelRect = camera.pixelRect.WithWidth(width);

        /// <summary>
        /// 카메라의 픽셀 사각형 최대 지점을 설정���니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="max">설정할 최대 지점 값.</param>
        public static void SetPixelRectMax(this Camera camera, Vector2 max) =>
            camera.pixelRect = camera.pixelRect.WithMax(max);

        /// <summary>
        /// 카메라의 픽셀 사각형 최소 지점을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="min">설정할 최소 지점 값.</param>
        public static void SetPixelRectMin(this Camera camera, Vector2 min) =>
            camera.pixelRect = camera.pixelRect.WithMin(min);

        /// <summary>
        /// 카메라의 픽셀 사각형 크기를 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="size">설정할 크기 값.</param>
        public static void SetPixelRectSize(this Camera camera, Vector2 size) =>
            camera.pixelRect = camera.pixelRect.WithSize(size);

        /// <summary>
        /// 카메라의 픽셀 사각형 x 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="x">설정할 x 값.</param>
        public static void SetPixelRectX(this Camera camera, float x) =>
            camera.pixelRect = camera.pixelRect.WithX(x);

        /// <summary>
        /// 카메라의 픽셀 사각형 y 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="y">설정할 y 값.</param>
        public static void SetPixelRectY(this Camera camera, float y) =>
            camera.pixelRect = camera.pixelRect.WithY(y);

        /// <summary>
        /// 카메라의 픽셀 사각형 x 최대 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="xMax">설정할 x 최대 값.</param>
        public static void SetPixelRectXMax(this Camera camera, float xMax) =>
            camera.pixelRect = camera.pixelRect.WithXMax(xMax);

        /// <summary>
        /// 카메라의 픽셀 사각형 y 최대 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="yMax">설정할 y 최대 값.</param>
        public static void SetPixelRectYMax(this Camera camera, float yMax) =>
            camera.pixelRect = camera.pixelRect.WithYMax(yMax);

        /// <summary>
        /// 카메라의 픽셀 사각형 x 최소 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="xMin">설정할 x 최소 값.</param>
        public static void SetPixelRectXMin(this Camera camera, float xMin) =>
            camera.pixelRect = camera.pixelRect.WithXMin(xMin);

        /// <summary>
        /// 카메라의 픽셀 사각형 y 최소 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="yMin">설정할 y 최소 값.</param>
        public static void SetPixelRectYMin(this Camera camera, float yMin) =>
            camera.pixelRect = camera.pixelRect.WithYMin(yMin);

        /// <summary>
        /// 카메라의 사각형 중심 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="center">설정할 중심 값.</param>
        public static void SetRectCenter(this Camera camera, Vector2 center) =>
            camera.rect = camera.rect.WithCenter(center);

        /// <summary>
        /// 카메라의 사각형 위치 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="position">설정할 위치 값.</param>
        public static void SetRectPosition(this Camera camera, Vector2 position) =>
            camera.rect = camera.rect.WithPosition(position);

        /// <summary>
        /// 카메라의 사각형 높이 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="height">설정할 높이 값.</param>
        public static void SetRectHeight(this Camera camera, float height) =>
            camera.rect = camera.rect.WithHeight(height);

        /// <summary>
        /// 카메라의 사각형 너비 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="width">설정할 너비 값.</param>
        public static void SetRectWidth(this Camera camera, float width) =>
            camera.rect = camera.rect.WithWidth(width);

        /// <summary>
        /// 카메라의 사각형 최대 지점 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="max">설정할 최대 지점 값.</param>
        public static void SetRectMax(this Camera camera, Vector2 max) =>
            camera.rect = camera.rect.WithMax(max);

        /// <summary>
        /// 카메라의 사각형 최소 지점 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="min">설정할 최소 지점 값.</param>
        public static void SetRectMin(this Camera camera, Vector2 min) =>
            camera.rect = camera.rect.WithMin(min);

        /// <summary>
        /// 카메라의 사각형 크기 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="size">설정할 크기 값.</param>
        public static void SetRectSize(this Camera camera, Vector2 size) =>
            camera.rect = camera.rect.WithSize(size);

        /// <summary>
        /// 카메라의 사각형 x 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="x">설정할 x 값.</param>
        public static void SetRectX(this Camera camera, float x) =>
            camera.rect = camera.rect.WithX(x);

        /// <summary>
        /// 카메라의 사각형 y 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="y">설정할 y 값.</param>
        public static void SetRectY(this Camera camera, float y) =>
            camera.rect = camera.rect.WithY(y);

        /// <summary>
        /// 카메라의 사각형 x 최대 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="xMax">설정할 x 최대 값.</param>
        public static void SetRectXMax(this Camera camera, float xMax) =>
            camera.rect = camera.rect.WithXMax(xMax);

        /// <summary>
        /// 카메라의 사각형 y 최대 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="yMax">설정할 y 최대 값.</param>
        public static void SetRectYMax(this Camera camera, float yMax) =>
            camera.rect = camera.rect.WithYMax(yMax);

        /// <summary>
        /// 카메라의 사각형 x 최소 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="xMin">설정할 x 최소 값.</param>
        public static void SetRectXMin(this Camera camera, float xMin) =>
            camera.rect = camera.rect.WithXMin(xMin);

        /// <summary>
        /// 카메라의 사각형 y 최소 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="yMin">설정할 y 최소 값.</param>
        public static void SetRectYMin(this Camera camera, float yMin) =>
            camera.rect = camera.rect.WithYMin(yMin);

        /// <summary>
        /// 카메라의 센서 크기 x 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="x">설정할 x 값.</param>
        public static void SetSensorSizeX(this Camera camera, float x) =>
            camera.sensorSize = camera.sensorSize.WithX(x);

        /// <summary>
        /// 카메라의 센서 크기 y 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="y">설정할 y 값.</param>
        public static void SetSensorSizeY(this Camera camera, float y) =>
            camera.sensorSize = camera.sensorSize.WithY(y);

        /// <summary>
        /// 카메라의 투명도 정렬 축 x 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="x">설정할 x 값.</param>
        public static void SetTransparencySortAxisX(this Camera camera, float x) =>
            camera.transparencySortAxis = camera.transparencySortAxis.WithX(x);

        /// <summary>
        /// 카메라의 투명도 정렬 축 y 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="y">설정할 y 값.</param>
        public static void SetTransparencySortAxisY(this Camera camera, float y) =>
            camera.transparencySortAxis = camera.transparencySortAxis.WithY(y);

        /// <summary>
        /// 카메라의 투명도 정렬 축 z 값을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="z">설정할 z 값.</param>
        public static void SetTransparencySortAxisZ(this Camera camera, float z) =>
            camera.transparencySortAxis = camera.transparencySortAxis.WithZ(z);

        /// <summary>
        /// 카메라의 투명도 정렬 x 및 y 축을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="x">설정할 x 축 값.</param>
        /// <param name="y">설정할 y 축 값.</param>
        public static void SetTransparencySortAxisXY(this Camera camera, float x, float y) =>
            camera.transparencySortAxis = camera.transparencySortAxis.WithXY(x, y);

        /// <summary>
        /// 카메라의 투명도 정렬 x 및 y 축을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="vector">설정할 벡터 값.</param>
        public static void SetTransparencySortAxisXY(this Camera camera, Vector2 vector) =>
            camera.transparencySortAxis = camera.transparencySortAxis.WithXY(vector.x, vector.y);

        /// <summary>
        /// 카메라의 투명도 정렬 x 및 z 축을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="x">설정할 x 축 값.</param>
        /// <param name="z">설정할 z 축 값.</param>
        public static void SetTransparencySortAxisXZ(this Camera camera, float x, float z) =>
            camera.transparencySortAxis = camera.transparencySortAxis.WithXZ(x, z);

        /// <summary>
        /// 카메라의 투명도 정렬 x 및 z 축을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="vector">설정할 벡터 값.</param>
        public static void SetTransparencySortAxisXZ(this Camera camera, Vector2 vector) =>
            camera.transparencySortAxis = camera.transparencySortAxis.WithXZ(vector.x, vector.y);

        /// <summary>
        /// 카메라의 투명도 정렬 y 및 z 축을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="y">설정할 y 축 값.</param>
        /// <param name="z">설정할 z 축 값.</param>
        public static void SetTransparencySortAxisYZ(this Camera camera, float y, float z) =>
            camera.transparencySortAxis = camera.transparencySortAxis.WithYZ(y, z);

        /// <summary>
        /// 카메라의 투명도 정렬 y 및 z 축을 설정합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="vector">설정할 벡터 값.</param>
        public static void SetTransparencySortAxisYZ(this Camera camera, Vector2 vector) =>
            camera.transparencySortAxis = camera.transparencySortAxis.WithYZ(vector.x, vector.y);

        /// <summary>
        /// <paramref name="canvasScaler"/>를 고려하여 전달된 월드 <paramref name="position"/>을 스크린 공간으로 변환합니다.
        /// </summary>
        /// <param name="camera">대상 카메라.</param>
        /// <param name="position">원하는 월드 위치.</param>
        /// <param name="canvasScaler">고려할 캔버스 스케일러.</param>
        /// <returns>스크린 공간 위치.</returns>
        public static Vector3 WorldToScreenPoint(
            this Camera camera,
            Vector3 position,
            CanvasScaler canvasScaler
        )
        {
            var screenPosition = camera.WorldToScreenPoint(position);

            var multiplier = canvasScaler.GetScaleFactor();
            screenPosition.x /= multiplier;
            screenPosition.y /= multiplier;

            return screenPosition;
        }
    }
}
