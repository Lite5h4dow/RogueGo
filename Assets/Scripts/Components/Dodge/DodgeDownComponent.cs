using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct DodgeDown : IComponentData {}
  public class DodgeDownComponent : ComponentDataProxy<DodgeDown> {}
}