using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct MovementKeyDown:IComponentData{}
  public class MovementKeyDownComponent : ComponentDataProxy<MovementKeyDown>{}
}