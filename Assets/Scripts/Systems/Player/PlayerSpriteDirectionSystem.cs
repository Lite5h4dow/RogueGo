using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class PlayerSpriteDirectionSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery (
        typeof (Player),
        typeof (Rigidbody2D),
        typeof (SpriteRenderer)
      );
    }

    protected override void OnUpdate () {
      Entities.With (player).ForEach ((
        Rigidbody2D rigidbody,
        SpriteRenderer sprite
      ) => {
        if (rigidbody.velocity.x > 0)
          sprite.flipX = false;

        if (rigidbody.velocity.x < 0)
          sprite.flipX = true;
      });
    }
  }
}