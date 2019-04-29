using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct CollidedWithPlayer:IComponentData{
      public Impact Value;
  }
  public class CollidedWithPlayerComponent : ComponentDataProxy<CollidedWithPlayer>{}
}