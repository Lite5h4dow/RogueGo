using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo{
  public class JumpInputSystem:ComponentSystem{
    EntityQuery player;

    protected override void OnCreateManager(){
      player = GetEntityQuery(
          typeof(Player),
          typeof(JumpInput)
      );
    }

    protected override void OnUpdate(){
      Entities.With(player).ForEach((ref JumpInput jumpIn) => {
        jumpIn.Value = Input.GetAxis("Jump");
      });
    }
  }
}