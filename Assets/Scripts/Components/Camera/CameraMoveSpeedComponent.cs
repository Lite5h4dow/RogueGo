using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
    [Serializable]
    public struct CameraMoveSpeed : IComponentData {
        public float Value;
    }
    public class CameraMoveSpeedComponent : ComponentDataProxy<CameraMoveSpeed> { }
}