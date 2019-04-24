using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct MovementKeyUp:IComponentData{}
  public class MovementKeyUpComponent : ComponentDataProxy<MovementKeyUp>{}
}