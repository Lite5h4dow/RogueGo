using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class FallGravityMultiplierSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        ComponentType.Exclude(typeof(CollidedWithGround)),
        typeof(FallMultiplier),
        typeof(Player),
        typeof(Rigidbody2D)

      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Rigidbody2D rb, ref FallMultiplier fm) => {
        if (!Input.GetButton("Jump"))
          return;

        if (rb.velocity.y >= 0)
          return;

        rb.velocity += Vector2.up * Physics2D.gravity.y * fm.Value * Time.deltaTime;
      });
    }
  }
}