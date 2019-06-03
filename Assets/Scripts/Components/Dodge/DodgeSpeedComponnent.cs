using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct DodgeSpeed : IComponentData {
    public float Value;
  }
  public class DodgeSpeedComponnent : ComponentDataProxy<DodgeSpeed> { }
}