using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct AttackCounter : IComponentData {
    public int Value;
  }
  public class AttackCounterComponent : ComponentDataProxy<AttackCounter> {}
}