using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
    [Serializable]
    public struct CameraLead : IComponentData {
        public Vector2 Value;
    }
    public class CameraLeadComponent : ComponentDataProxy<CameraLead> { }
}