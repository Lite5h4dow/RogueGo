using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace RogueGo{
  [Serializable]
  public struct Impact:IComponentData{
    public State.Overlap State;
    public Entity OtherEntity;
    public CollisionData Collision;
  }
}