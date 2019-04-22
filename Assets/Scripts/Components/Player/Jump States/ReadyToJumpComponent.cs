using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogurGo{
  [Serializable]
  public struct ReadyToJump:IComponentData{}
  public class ReadyToJumpComponent : ComponentDataProxy<ReadyToJump>{}
}