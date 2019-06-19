using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class LowJumpGravityMultiplierSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        ComponentType.Exclude(typeof(CollidedWithGround)),
        typeof(LowJumpMultiplier),
        typeof(Player),
        typeof(Rigidbody2D)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Rigidbody2D rb, ref LowJumpMultiplier ljm) => {
        if (Input.GetButton("Jump"))
          return;

        if (rb.velocity.y <= 0)
          return;

        rb.velocity += Vector2.up * Physics2D.gravity.y * ljm.Value * Time.deltaTime;
      });
    }
  }
}