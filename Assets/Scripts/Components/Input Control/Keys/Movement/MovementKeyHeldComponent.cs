using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct MovementKeyHeld:IComponentData{}
  public class MovementKeyHeldComponent : ComponentDataProxy<MovementKeyHeld>{}
}