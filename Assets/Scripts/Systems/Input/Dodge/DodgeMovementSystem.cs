using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(MainSimulationSystemGroup))]
  public class DodgeMovementSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(Dodging),
        typeof(DodgeSpeed),
        typeof(DodgeDirection),
        typeof(Rigidbody2D)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((Rigidbody2D rb2d, ref DodgeDirection dd, ref DodgeSpeed ds) => {
        rb2d.velocity = new Vector2(dd.Value * ds.Value, rb2d.velocity.y);
      });
    }
  }
}