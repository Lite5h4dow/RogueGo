using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(SimulationSystemGroup))]
  public class GroundedSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        ComponentType.Exclude(typeof(Grounded)),
        typeof(Player),
        typeof(CollidedWithGround)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach(entity => {
        PostUpdateCommands.AddComponent<Grounded>(entity, new Grounded { });

        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */
        if (Bootstrap.DeveloperSettings.DebugGroundedState) {
          Debug.Log($"<color=green>{this.GetType()}</color> Grounded");
        }
        /* ----------------- DEVELOPER SETTINGS - REMOVE ME -------------------- */

      });
    }
  }
}