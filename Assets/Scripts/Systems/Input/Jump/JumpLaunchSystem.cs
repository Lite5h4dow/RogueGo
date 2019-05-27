using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(MainSimulationSystemGroup))]
  public class JumpLaunchSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        typeof(JumpLaunch),
        typeof(JumpVelocity),
        typeof(Rigidbody2D)
      );
    }

    protected override void OnUpdate () {
      if (!Input.GetButton("Jump"))
        return;

      Entities.With(player).ForEach((ref JumpVelocity jumpVelocity, Rigidbody2D rb) => {
        Debug.Log("jumping");
        rb.velocity = new float2(rb.velocity.x, jumpVelocity.Value);
      });
    }
  }
}