using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct DodgeRechargeTime : IComponentData {
    public float Value;
  }
  public class DodgeRechargeTimeComponent : ComponentDataProxy<DodgeRechargeTime> { }
}