using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct SwordDrawn : IComponentData {
  }

  public class SwordDrawnComponent : ComponentDataProxy<SwordDrawn> {
  }
}