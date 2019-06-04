using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct AirborneMaxAttackCount : IComponentData {
    public int Value;
  }
  public class AirborneMaxAttackCountComponent : ComponentDataProxy<AirborneMaxAttackCount> {}
}