using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct Ground:IComponentData{}
  public class GroundComponent : ComponentDataProxy<Ground>{}
}