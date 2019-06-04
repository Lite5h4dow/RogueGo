using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct DodgeDirection : IComponentData {
    public int Value;
  }
  public class DodgeDirectionComponent : ComponentDataProxy<DodgeDirection> {}
}