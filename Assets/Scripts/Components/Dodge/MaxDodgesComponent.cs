using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct MaxDodges : IComponentData {
    public int Value;
  }
  public class MaxDodgesComponent : ComponentDataProxy<MaxDodges> { }
}