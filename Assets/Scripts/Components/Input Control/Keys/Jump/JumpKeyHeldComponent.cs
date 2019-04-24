using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct JumpKeyHeld:IComponentData{}
  public class JumpKeyHeldComponent : ComponentDataProxy<JumpKeyHeld>{}
}