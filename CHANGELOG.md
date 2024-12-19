# Changelog

All notable changes to this project will be documented in this file.

## 버전 관리 정책

이 프로젝트는 Semantic Versioning을 따릅니다:

- **Major.Minor.Patch** 형식
  - **Major**: 호환성이 깨지는 변경
  - **Minor**: 하위 호환성 있는 기능 추가
  - **Patch**: 하위 호환성 있는 버그 수정
- **최신 버전이 상단에, 이전 버전이 하단에 기록됩니다.**

## [0.1.0] - 2024-12-05

### Added

- `ComponentExtensions`: `Component` 클래스에 대한 확장 메서드 추가 (컴포넌트 가져오기/추가, 자식/부모에서 검색)
- `CameraExtensions`: `Camera` 클래스에 대한 확장 메서드 추가 (배경색 설정, 렌즈 쉬프트, 픽셀 사각형 설정 등)
- `CanvasScalerExtensions`: `CanvasScaler` 클래스에 대한 확장 메서드 추가 (`ScaleWithScreenSize` 모드에서 스케일 팩터 가져오기)
- `GameObjectExtensions`: `GameObject` 클래스에 대한 확장 메서드 추가 (컴포넌트 가져오기/추가, 자식/부모에서 검색, 레이어 설정 등)
- `GraphicExtensions`: `Graphic` 클래스에 대한 확장 메서드 추가 (색상 채널 값 설정)
- `IComparableExtensions`: `IComparable` 인터페이스에 대한 확장 메서드 추가 (값이 지정된 간격 내에 있는지 확인)
- `IEnumerableExtensions`: `IEnumerable` 인터페이스에 대한 확장 메서드 추가 (임의의 요소 가져오기, 임의의 요소들 가져오기)
- `IEquatableExtensions`: `IEquatable` 인터페이스에 대한 확장 메서드 추가 (값이 지정된 배열의 모든 요소와 같은지 확인, 지정된 배열의 요소 중 하나 이상과 같은지 확인)
- `IListExtensions`: `IList` 인터페이스에 대한 확장 메서드 추가 (인덱스에 있는 요소 꺼내기, 인덱스들에 있는 요소들 꺼내기)
- `ObjectExtensions`: `Object` 클래스에 대한 확장 메서드 추가 (객체가 지정된 배열의 모든 요소와 같은지 확인, 지정된 배열의 요소 중 하나 이상과 같은지 확인)
- `QuaternionExtensions`: `Quaternion` 구조체에 대한 확장 메서드 추가 (축에 값 설정)
- `RayExtensions`: `Ray` 구조체에 대한 확장 메서드 추가 (반전된 Ray 생성, 임의로 Ray 방향을 편향시키기)
- `RectExtensions`: `Rect` 구조체에 대한 확장 메서드 추가 (중심, 위치, 높이, 너비 설정)
- `RectTransformExtensions`: `RectTransform` 클래스에 대한 확장 메서드 추가 (크기 델타 x, y 설정, 앵커 최소 x, y 설정, 앵커 최대 x, y 설정, 앵커 중심 x, y 설정, 앵커 피봇 x, y 설정, 앵커 피봇 최소 x, y 설정, 앵커 피봇 최대 x, y 설정, 앵커 피봇 최소 x, y 설정, 앵커 피봇 최대 x, y 설정)
- `RenderTextureExtensions`: `RenderTexture` 클래스에 대한 확장 메서드 추가 (텍스처 생성, 텍스처 쓰기, 스프라이트 생성)
- `SceneExtensions`: `Scene` 클래스에 대한 확장 메서드 추가 (Scene에서 컴포넌트를 가진 게임 오브젝트를 찾고, Scene에서 컴포넌트를 가진 게임 오브젝트들을 찾는 기능을 제공합니다.)
- `TransformExtensions`: `Transform` 클래스에 대한 확장 메서드 추가 (모든 자식 가져오기, 임의의 자식 가져오기, 자식 추가, 모든 자식 제거, 첫 번째 자식 제거, 마지막 자식 제거, Transform을 RectTransform 타입으로 캐스팅)

### Changed

### Fixed

## [0.0.1] - 2024-02-16

### Added

- `Vector2`, `Vector3`, `Vector4`, `Vector2Int`, `Vector3Int`  구조체에 대한 확장 메서드 추가
- `Color`, `Color32` 구조체에 대한 확장 메서드 추가
- `float`, `double` 타입에 대한 확장 메서드 추가
- `ColorExtensions`: `Color` 구조체에 대한 확장 메서드 추가 (색상 채널 설정, 보간 등)
- `Color32Extensions`: `Color32` 구조체에 대한 확장 메서드 추가 (색상 채널 설정, 보간 등)
-

### Changed

### Fixed
