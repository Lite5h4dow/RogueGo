using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct CanEquip : IComponentData {
  }
  public class CanEquipComponent : ComponentDataProxy<CanEquip> {
  }
}