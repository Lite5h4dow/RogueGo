using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct ReadyToDodge : IComponentData {
    public float Value;
  }

  public class ReadyToDodgeComponenet : ComponentDataProxy<ReadyToDodge> {}
}