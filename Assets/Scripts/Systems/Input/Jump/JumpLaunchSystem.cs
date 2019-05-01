using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo{
  [UpdateInGroup(typeof(MainPresentationSystemGroup))]
  public class JumpLaunchSystem:ComponentSystem{
    EntityQuery player;
    EntityQuery key;

    protected override void OnCreateManager(){
      player = GetEntityQuery(
        typeof(Player),
        typeof(JumpLaunch),
        typeof(JumpVelocity),
        typeof(Rigidbody2D)
      );

      key = GetEntityQuery(
        typeof(JumpKeyHeld)
      );

      RequireForUpdate(player);
      RequireForUpdate(key);
    }

    protected override void OnUpdate(){
      Entities.With(player).ForEach((ref JumpVelocity velocity, Rigidbody2D rigid) => {
        rigid.velocity = new float2(rigid.velocity.x, velocity.Value);
      });
    }
  }
}