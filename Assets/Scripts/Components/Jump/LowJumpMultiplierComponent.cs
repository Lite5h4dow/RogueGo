using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct LowJumpMultiplier : IComponentData {
    public float Value;
  }
  public class LowJumpMultiplierComponent : ComponentDataProxy<LowJumpMultiplier> { }
}