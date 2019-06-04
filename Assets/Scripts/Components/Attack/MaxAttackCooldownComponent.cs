using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct MaxAttackCooldown : IComponentData {
    public float Value;
  }
  public class MaxAttackCooldownComponent : ComponentDataProxy<MaxAttackCooldown> {}
}