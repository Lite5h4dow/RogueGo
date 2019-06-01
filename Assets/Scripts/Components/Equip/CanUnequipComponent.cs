using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct CanUnequip : IComponentData {
  }
  public class CanUnequipComponent : ComponentDataProxy<CanUnequip> {
  }
}