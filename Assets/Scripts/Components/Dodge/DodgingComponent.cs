using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct Dodging : IComponentData {
    public float Value;
  }

  public class DodgingComponent : ComponentDataProxy<Dodging> { }
}