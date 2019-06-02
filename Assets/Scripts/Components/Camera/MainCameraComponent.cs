using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
    [Serializable]
    public struct MainCamera : IComponentData { }
    public class MainCameraComponent : ComponentDataProxy<MainCamera> { }
}