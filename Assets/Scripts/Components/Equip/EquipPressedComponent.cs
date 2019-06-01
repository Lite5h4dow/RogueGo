using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct EquipPressed : IComponentData {
  }
  public class EquipPressedComponent : ComponentDataProxy<EquipPressed> {
  }
}