using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct MaxDodgeTime : IComponentData {
    public float Value;
  }
  public class MaxDodgeTimeComponent : ComponentDataProxy<MaxDodgeTime> {}
}