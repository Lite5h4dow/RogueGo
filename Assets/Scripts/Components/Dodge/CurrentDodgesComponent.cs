using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct CurrentDodges : IComponentData {
    public int Value;
  }
  public class CurrentDodgesComponent : ComponentDataProxy<CurrentDodges> { }
}