using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct GroundedMaxAttackCount : IComponentData {
    public int Value;
  }
  public class GroundedMaxAttackCountComponenet : ComponentDataProxy<GroundedMaxAttackCount> {}
}