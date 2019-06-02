using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct FallMultiplier : IComponentData {
    public float Value;
  }
  public class FallMultiplierComponent : ComponentDataProxy<FallMultiplier> { }
}