using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct Grounded:IComponentData{}
  public class GroundedComponent : ComponentDataProxy<Grounded>{}
}