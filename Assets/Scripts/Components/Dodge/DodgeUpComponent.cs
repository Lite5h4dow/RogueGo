using System;

using Unity.Entities;
using Unity.Mathematics;

using UnityEngine;

namespace RogueGo {
  [Serializable]
  public struct DodgeUp : IComponentData {}
  public class DodgeUpComponent : ComponentDataProxy<DodgeUp> {}
}