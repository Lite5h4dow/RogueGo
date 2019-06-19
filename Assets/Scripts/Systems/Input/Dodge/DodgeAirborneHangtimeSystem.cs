using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(MainSimulationSystemGroup))]
  [UpdateAfter(typeof(DodgeMovementSystem))]
  public class DodgeAirborneHangtimeSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        typeof(Dodging),
        typeof(Rigidbody2D),
        ComponentType.Exclude(typeof(CollidedWithGround))
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Rigidbody2D rigid) => {
        rigid.velocity = new Vector2(rigid.velocity.x, 0);
      });
    }
  }
}