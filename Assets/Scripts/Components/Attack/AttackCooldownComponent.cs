using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct AttackCooldown : IComponentData {
    public float Value;
  }
  public class AttackCooldownComponent : ComponentDataProxy<AttackCooldown> {}
}